using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Klod.Validation.Classes.Rules;
using Klod.Validation.Classes.Configuration;

namespace Klod.Validation.Classes.Mapping
{
	/// <summary>
	/// XML implementation of the RulesRepository
	/// </summary>
	public class XmlRulesRepository:RulesRepository
	{
        private const string ERR_LOADING_XML = "Error loading the mapping file.";

        public XmlRulesRepository()
			:base(){}

        protected override void LoadRuleMaps()
        {
            try
            {
                //load the xml rules map file
                XmlDocument _mappingsFile = new XmlDocument();
                _mappingsFile.Load(GetMappingsFileAddress());

                //get the collecton of rules map
                XmlNodeList _ruleNodes = _mappingsFile.SelectNodes("//" + Config.Default.RuleElement);
                //Caching: put the maps of every object in a pool
                foreach (XmlNode _ruleNode in _ruleNodes)
                {
                    //get the name of the rule, it will be used as a key
                    string _mapKey = _ruleNode.Attributes[Config.Default.RuleNameAttribute].Value;
                    //get every rule node in the file and store it in the pool
                    RuleMap _ruleMap = MakeRuleMap(_ruleNode);
                    MapPool.Add(_mapKey, _ruleMap);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ERR_LOADING_XML + "\n" + ex.Message);
            }
        }
        protected override RuleMap MakeRuleMap(XmlNode mapNode)
		{
			return new XmlRuleMap(mapNode);
		}
		protected override RuleBase MakeRule(RuleMap map)
		{
			return new XmlRule(map);
		}
	}
}
