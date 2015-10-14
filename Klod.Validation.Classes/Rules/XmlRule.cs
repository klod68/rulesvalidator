using System;
using System.Collections.Generic;
using System.Text;

namespace Klod.Validation.Classes.Rules
{
	public class XmlRule:RuleBase
	{

		public XmlRule() : base() { }
		public XmlRule(RuleMap map)
			: base(map)
		{
		}
	   
		//check the the constraints
		public override bool Check(IList<object> objects)
		{
			try
			{
				foreach(ConstraintBase c in Constraints)
				{
					bool objFound = false;
					for (int i = 0; i < objects.Count; i++)
					{
						if (c.TypeToValidate.FullName == objects[i].GetType().FullName)
						{
							objFound = true;
							if (!c.IsValid(objects[i]))
								return false;
							else
								break;
						}						
					}
					if (!objFound)
						return false;
				}
				return true;
			}
			catch
			{
				return false;
			}
		}

		protected override void LoadConstraints()
		{
            try
            {//load all constraints
                for (int i = 0; i < base.RuleMap.ConstraintCount; i++)
                {
                    ConstraintOperator op = (ConstraintOperator)Enum.Parse(Type.GetType("Klod.Validation.ConstraintOperator,Klod.Validation"), base.RuleMap.Operators[i]);
                    ConstraintBase constraint = MakeConstraint(op);
                    constraint.Name = base.RuleMap.Constraints[i];
                    constraint.Operator = op;
                    constraint.Property = base.RuleMap.Properties[i];
                    constraint.TypeToValidate = Type.GetType(base.RuleMap.TypeToValidate[i]);
                    constraint.Value = base.RuleMap.Values[i];
                    constraint.ValueType = Type.GetType(base.RuleMap.ValueTypes[i]);

                    Add(constraint.Name, constraint);
                }
            }
            catch (Exception e) 
            {
                throw new Exception(e.Message);
            }
		}
		protected override ConstraintBase MakeConstraint(ConstraintOperator op)
		{
			//return a contraint based on the operator type
			switch (op)
			{
				case ConstraintOperator.Range:
					return new XmlRangeConstraint();
				case ConstraintOperator.OptionsSet:
					return new XmlOptionsSetConstraint();
				default:
					return new XmlExactConstraint();
			}
		}
		
	}
}
