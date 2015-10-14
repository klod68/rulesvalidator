using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Klod.Test.RulesValidation.Model
{
	public class AnyClass
	{
		private string _name;
		private int _value;

		public string Name
		{
			set { _name = value; }
			get { return _name; }
		}
		public int Value
		{
			set { _value = value; }
			get { return _value; }
		}
		public AnyClass() { }
		public AnyClass(string name, int value)
		{
			_name = name;
			_value = value;
		}
	}
}
