using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using Klod.Validation.Configuration;

namespace Klod.Validation
{
	//2010.05.23 ok crr
	/// <summary>
	/// Base abstract class to store rules map of contraints.
	/// </summary>
	public abstract class RulesRepository
	{
		private Dictionary<string, RuleMap> _mapPool;

		public RulesRepository()
		{
			//construct the pool for the rules map
			_mapPool = new Dictionary<string, RuleMap>();
			//load the maps in the pool
			LoadRuleMaps();
		}

        protected Dictionary<string, RuleMap> MapPool
        {
            get
            {
                return _mapPool;
            }
            set
            {
                _mapPool = value;
            }
        }

        protected abstract void LoadRuleMaps();
		
		public RuleBase GetRule(string ruleName)
		{
			//get map for the rule
			RuleMap map = GetRuleMap(ruleName);
			//make a rule object to validate the objects parameters
			return MakeRule(map);
		}		
		
		protected RuleMap GetRuleMap(string ruleName) 
		{
			try
			{
				if (_mapPool.ContainsKey(ruleName))
					return _mapPool[ruleName];
				return null;
			}
			catch (Exception ex)
			{
				throw new Exception("Error getting the map for the object...", ex);
			}
		}
		
		

		//protect the real address
		protected virtual string GetMappingsFileAddress()
		{
			return Config.Default.FilesMapAddresss;
		}
		protected abstract RuleMap MakeRuleMap(XmlNode mapNode);
		protected abstract RuleBase MakeRule(RuleMap map);
		
	}
}
