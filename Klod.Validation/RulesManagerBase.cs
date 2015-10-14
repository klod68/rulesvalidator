using System;
using System.Collections.Generic;
using System.Text;

namespace Klod.Validation
{
	/// <summary>
	///Abstract class representing a Rule manager. It's an implementation of the Command GoF pattern.
	///Its main method is Validate() that receives a rule name and a set of objects for properties validation.
	/// </summary>
	public abstract class RulesManagerBase
	{
		private RulesRepository _repository;
		#region constructor
		public RulesManagerBase()
		{
			//template method, implemented by its childs
			_repository = MakeRulesRepository();
		}
		#endregion

		#region validate methods
		public bool Validate(string ruleName, IList<Object> objects)
		{
			try
			{

				//get rule from the main repository
				RuleBase rule = _repository.GetRule(ruleName);
				//return true if all objects properties validates with thre rules contraints
				return rule.Check(objects);
			}
			catch { return false; }
		}
		
		#endregion
	
		#region factory methods
		//template method/factory method
		protected abstract RulesRepository MakeRulesRepository();
		#endregion
	}
}
