using System;
using System.Collections.Generic;
using System.Text;

namespace Klod.Validation
{
    //comment for test only.
	/// <summary>
	/// Abstract class that represent a map or the rules definitions.
	/// </summary>
	public abstract class RuleMap
	{
		private string _name; //name of the rule map
		private int _contraintsCount; //constrants count for loop
		private string[] _constraints;
		private string[] _properties;
		private string[] _values;
		private string[] _valueTypes;
		private string[] _operators;
		private string[] _typeToValidate;

		public virtual string Name
		{
			set { _name = value; }
			get { return _name; }
		}
		public virtual int ConstraintCount
		{
			set { _contraintsCount = value; }
			get { return _contraintsCount; }
		}
		public virtual string[] Constraints
		{
			set { _constraints = value; }
			get { return _constraints; }
		}
		public virtual string[] Properties
		{
			set { _properties = value; }
			get { return _properties; }
		}
		public virtual string[] Values
		{
			set { _values = value; }
			get { return _values; }
		}
		public virtual  string[] ValueTypes
		{
			set { _valueTypes = value; }
			get { return _valueTypes; }
		}
		public virtual string[] Operators
		{
			set { _operators = value; }
			get { return _operators; }
		}
		public virtual string[] TypeToValidate
		{
			set { _typeToValidate = value; }
			get { return _typeToValidate; }
		}

		protected RuleMap() { }

	}
}
