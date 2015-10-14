using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Klod.Validation.Classes.Rules
{
	public class XmlOptionsSetConstraint:XmlConstraint
	{
		public XmlOptionsSetConstraint() : base() { }
		public XmlOptionsSetConstraint(string name, string property, object value, ConstraintOperator op, Type valueType, Type typeToValidate)
			: base(name, property, value, op, valueType, typeToValidate) { }

		protected override bool ComparisonResult(object objectToValidate)
		{
			//get object value
			object objValue = objectToValidate.GetType().GetProperty(Property).GetValue(objectToValidate, null);
			
			//split the options values
			string[] conValuesString = Value.ToString().Split('|');
			//set the object array for convert the values to its proper type
			int options = conValuesString.GetLength(0);
			object[] conValues = new object[options];

			//execute the proper comparison method
			MethodInfo equalMethod = null;
			equalMethod = objValue.GetType().GetMethod("op_Equality");

			//made an array for the 'op_' method parameters
			object[] objsToCompare = new object[2];
			objsToCompare[0] = objValue;

			for (int i = 0; i < options; i++)
			{
				conValues[i] = Convert.ChangeType(conValuesString[i], ValueType);
				objsToCompare[1] = conValues[i];
				if((bool)equalMethod.Invoke(objValue, objsToCompare))
				{
					return true;	
				}
			}
			return false;
		}
	}
}
