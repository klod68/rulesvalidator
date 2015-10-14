using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Klod.Validation.Classes.Rules
{
    //TODO: WARNING: Abstract class in this module? Please check this!
    public abstract class XmlConstraint:ConstraintBase
	{
		public XmlConstraint() : base() { }
		public XmlConstraint(string name, string property, object value, ConstraintOperator op, Type valueType, Type typeToValidate)
			:base(name, property, value, op, valueType, typeToValidate) {}
	   
		/// <summary>
		/// Check the validity of an object against the constraint values.
		/// </summary>
		/// <param name="objectToValidate"></param>
		/// <returns></returns>
		public override bool IsValid(object objectToValidate)
		{
			//check if the object is of the correct type
			if (TypeToValidate.FullName != objectToValidate.GetType().FullName)
				return false;
			//check if the property value is of the correct type
			if (objectToValidate.GetType().GetProperty(Property).GetValue(objectToValidate,null).GetType().FullName != ValueType.FullName)
				return false;

			//return the result of the requested comparison
			return ComparisonResult(objectToValidate);

		}
		/// <summary>
		/// Return the result of the constraint comparison operation.
		/// </summary>
		/// <param name="objectToValidate"></param>
		/// <returns></returns>
		protected abstract bool ComparisonResult(object objectToValidate);

	
		/// <summary>
		/// Parse the constraint string to set the class properties.
		/// </summary>
		public override void  ParseConstraintString()
		{
			XmlTextReader node = new XmlTextReader(ConstraintString,XmlNodeType.Element,null);
			XmlDocument doc = new XmlDocument();
			XmlNode xmlConstraint = doc.ReadNode(node);
			
			base.Name = xmlConstraint.Attributes["name"].Value;
			base.Property = xmlConstraint.Attributes["property"].Value;
			base.Operator = (ConstraintOperator)Enum.Parse(typeof(Klod.Validation.ConstraintOperator),xmlConstraint.Attributes["operator"].Value);
			base.TypeToValidate = Type.GetType(xmlConstraint.Attributes["typeToValidate"].Value);
			base.Value = xmlConstraint.Attributes["value"].Value;
			base.ValueType = Type.GetType(xmlConstraint.Attributes["valueType"].Value);
		}

		/// <summary>
		/// Serialize the class properties in the constraint string.
		/// </summary>
		/// <returns></returns>
		public override string  SerializePropertiesToConstraintString()
		{
			if (ConstraintString == string.Empty)
				ConstraintString = XmlSerialization();
			return ConstraintString;
		}
		/// <summary>
		/// Private method to make an XML fragment with the class properties.
		/// </summary>
		/// <returns></returns>
		private string XmlSerialization()
		{
			StringBuilder xml = new StringBuilder();
			xml.Append("<constraint name='");
			xml.Append(Name);
			xml.Append("' property=");
			xml.Append(Property);
			xml.Append(" value='");
			xml.Append(Value);
			xml.Append("' operator='");
			xml.Append(Operator.ToString());
			xml.Append("' valueType='");
			xml.Append(ValueType.FullName);
			xml.Append("' typeToValidate='");
			xml.Append(TypeToValidate);
			xml.Append("' />");
			return xml.ToString();
		}
	}
}
