using System;
using System.Collections.Generic;
using System.Text;

namespace Klod.Validation
{
	/// <summary>
	///Abstract class representing a comparison expression. A constraint have a property, a value and operator. 
	///The main method is the IsValid() that check values in the property of an object, based on the designated operator.
	/// </summary>
	public abstract class ConstraintBase
	{
		private string _name;
		private string _property;
		private object _value;
		private ConstraintOperator _operator;
		private Type _valueType;
		private Type _typeToValidate;
		private string _constraintString;

		public ConstraintBase() { }
		//WARNING: 
		//Rule: avoid virtual overridable methods in constructors.
		//Rational: the subclass isn't initialized when execution the below methods. Doing It, frequently result in subclass constructor errors 
		//or unexpected initialization. The order of initialization runs as: base.Constructor -> Hook method -> subclass.Contructor.
		//Comment: In that scenario (template method in the base constructor class) and different use of the template method pattern,
		//the child constructor doesn't act as a true initializer, the base class impose some policy for initialization. 
		//Then why code initialization under subclass constructors? The subclasses must adapt to initialization policy of parents
		//and go with empty constructors or code that does't nullifies the policy. 
		//READ article in my blog https://claudiorivera.net about Template Methods in Constructors.
		public ConstraintBase(string name, string property, object value, ConstraintOperator op, Type valueType, Type typeToValidate)
		{
			_name = name;
			_property = property;
			_value = value;
			_operator = op;
			_valueType = valueType;
			_typeToValidate = typeToValidate;
			
			_constraintString = SerializePropertiesToConstraintString();
			ParseConstraintString();

		}
		public string ConstraintString
		{
			set {_constraintString = value;}
			get { return _constraintString; }
		}
		public string Name
		{
			set { _name = value; }
			get { return _name; }
		}
		public string Property
		{
			set { _property = value; }
			get { return _property; }
		}
		public object Value
		{
			set { _value = value; }
			get{return _value;}
		}
		public ConstraintOperator Operator
		{
			set { _operator = value; }
			get { return _operator; }
		}
		public Type ValueType
		{
			set { _valueType = value; }
			get { return _valueType; }
		}
		public Type TypeToValidate
		{
			set { _typeToValidate = value; }
			get { return _typeToValidate; }
		}

		public abstract bool IsValid(object objectToValidate);
		public abstract void ParseConstraintString();
		public abstract string SerializePropertiesToConstraintString();
	}
}
