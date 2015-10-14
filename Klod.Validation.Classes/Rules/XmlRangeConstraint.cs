using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace Klod.Validation.Classes.Rules
{
	public class XmlRangeConstraint:XmlConstraint
	{
		public XmlRangeConstraint() : base() { }
		public XmlRangeConstraint(string name, string property, object value, ConstraintOperator op, Type valueType, Type typeToValidate)
			: base(name, property, value, op, valueType, typeToValidate) { }

		protected override bool ComparisonResult(object objectToValidate)
		{
			//get object and constraint values
			object objValue = objectToValidate.GetType().GetProperty(Property).GetValue(objectToValidate, null);
			//split the two range values
			string[] conValuesString = Value.ToString().Split('|');
			//set the object array for convert the values to its proper type
			object[] conValues = new object[2];
			conValues[0] = Convert.ChangeType(conValuesString[0], ValueType);
			conValues[1] = Convert.ChangeType(conValuesString[1], ValueType);
			

			//made an array for the 'op_' methods parameters
			object[] objsMinValue = new object[2];
			objsMinValue[0] = objValue;
			objsMinValue[1] = conValues[0];

			object[] objsMaxValue = new object[2];
			objsMaxValue[0] = objValue;
			objsMaxValue[1] = conValues[1];

			MethodInfo greaterThanOrEqualMethod = null;
			MethodInfo lessThanOrEqualMethod = null;
			
			//execute the proper comparison method
			greaterThanOrEqualMethod = objValue.GetType().GetMethod("op_GreaterThanOrEqual");
			lessThanOrEqualMethod = objValue.GetType().GetMethod("op_LessThanOrEqual");

			return (bool)greaterThanOrEqualMethod.Invoke(objValue, objsMinValue) && (bool)lessThanOrEqualMethod.Invoke(objValue, objsMaxValue);
		}
	}
}
