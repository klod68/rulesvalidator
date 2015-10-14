using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Reflection;

namespace Klod.Validation.Classes.Rules
{
	public class XmlExactConstraint:XmlConstraint
	{
		public XmlExactConstraint() : base() { }
		public XmlExactConstraint(string name, string property, object value, ConstraintOperator op, Type valueType, Type typeToValidate)
			: base(name, property, value, op, valueType, typeToValidate) { }

		protected override bool ComparisonResult(object objectToValidate)
		{
			//get object and constraint values
			object objValue = objectToValidate.GetType().GetProperty(Property).GetValue(objectToValidate, null);
			object conValue = Convert.ChangeType(Value, ValueType);

			//made an array for the 'op_' methods parameters
			object[] objs = new object[2];
			objs[0] = objValue;
			objs[1] = conValue;

			MethodInfo method = null;
			string operatorMethod = string.Empty;
			//set the operation to exectue
			switch (Operator)
			{
				case ConstraintOperator.Equal:
					operatorMethod = "op_Equality";
					break;
				case ConstraintOperator.GreaterThanOrEqual:
					operatorMethod = "op_GreaterThanOrEqual";
					break;
				case ConstraintOperator.LessThanOrEqual:
					operatorMethod = "op_LessThanOrEqual";
					break;
				case ConstraintOperator.GreaterThan:
					operatorMethod = "op_GreaterThan";
					break;
				case ConstraintOperator.LessThan:
					operatorMethod = "op_LessThan";
					break;
				case ConstraintOperator.NotEqual:
					operatorMethod = "op_Inequality";
					break;
				default:
					return false;
			}
			//execute the proper comparison method
			method = objValue.GetType().GetMethod(operatorMethod);
			return (bool)method.Invoke(objValue, objs);
		}
	}
}
