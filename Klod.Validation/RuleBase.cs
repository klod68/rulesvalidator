using System;
using System.Collections.Generic;
using System.Text;

namespace Klod.Validation
{
	/// <summary>
	/// Abstract class that represent a rule. A rule is a set of constraints.
	/// The rule use a RuleMap object to store rules definitions.
	/// </summary>
	public abstract class RuleBase
	{
		private Dictionary<string, ConstraintBase> _constraints;
		private RuleMap _ruleMap;

		public ConstraintBase[] Constraints
		{
			get 
			{
				ConstraintBase[] constraints = new ConstraintBase[_constraints.Count];
				_constraints.Values.CopyTo(constraints, 0);
				
				return constraints; 
			}
		}
		protected RuleMap RuleMap
		{
			set { _ruleMap = value; }
			get { return _ruleMap; }
		}
		protected RuleBase() 
		{
			_constraints = new Dictionary<string, ConstraintBase>();
		}
		public RuleBase(RuleMap map):this()
		{
			_ruleMap = map;
			//create contraints and add them to the _contraints collection
			//template method
			LoadConstraints();

		}

		protected void Add(string itemName, ConstraintBase ruleItem)
		{
			_constraints.Add(itemName, ruleItem);
		}
		protected bool Remove(string itemName)
		{
			return _constraints.Remove(itemName);
		}
		protected ConstraintBase Get(string itemName)
		{
			try
			{
				return _constraints[itemName];
			}
			catch 
			{
				return null;
			}
		}

		public abstract bool Check(IList<object> objects);
		protected abstract void LoadConstraints();
		protected abstract ConstraintBase MakeConstraint(ConstraintOperator op);
	}
}
