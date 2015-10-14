using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Klod.Validation.Classes.Configuration;

using Klod.Validation.Configuration;

namespace Klod.Validation.Classes.Mapping
{
	public class XmlRuleMap:RuleMap
	{
		private XmlNode _ruleXML;
		const string ERR_INSTANCE_CREATION = "Cannot create an instance of XmlRuleMap."; //use a resource file

		protected XmlRuleMap() { }
		public XmlRuleMap(XmlNode ruleNode)
		{
			try
			{
				//set rules complete node
				_ruleXML = ruleNode;
				this.Name = _ruleXML.Attributes[Config.Default.RuleNameAttribute].Value;
				XmlNode constraintsXML = _ruleXML.SelectSingleNode(Config.Default.RuleConstraintsElement);
				if (constraintsXML != null)
				{
                    //initialialize all the string property collections for the xml constraints attributes
                    //only consider valid children
                    int count = constraintsXML.ChildNodes.Count;
					this.ConstraintCount = count;
					this.Constraints = new string[count];
					this.Properties = new string[count];
					this.Values = new string[count];
					this.ValueTypes = new string[count];
					this.Operators = new string[count];
					this.TypeToValidate = new string[count];

					//set all attribute values
					for (int i = 0; i < count; i++)
					{
						//check if there's a comment to skip
						if (constraintsXML.ChildNodes[i].NodeType.ToString().Contains("Comment"))
							continue;
						this.Constraints[i] = constraintsXML.ChildNodes[i].Attributes[Config.Default.ConstraintNameAttribute].Value;
						this.Properties[i] = constraintsXML.ChildNodes[i].Attributes[Config.Default.ConstraintPropertyAttribute].Value;
						this.Values[i] = constraintsXML.ChildNodes[i].Attributes[Config.Default.ConstraintValueAttribute].Value;
						this.ValueTypes[i] = constraintsXML.ChildNodes[i].Attributes[Config.Default.ConstraintValueTypeAttribute].Value;
						this.Operators[i] = constraintsXML.ChildNodes[i].Attributes[Config.Default.ConstraintOperatorAttribute].Value;
						this.TypeToValidate[i] = constraintsXML.ChildNodes[i].Attributes[Config.Default.ContraintTypeToValidateAttribute].Value;
					}
				}

			}
			catch (Exception ex)
			{
				
				throw new Exception (ERR_INSTANCE_CREATION,ex);
			}
		}
	}
}
