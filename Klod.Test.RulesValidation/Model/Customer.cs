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
	public class Customer
	{
		private string _type;
		private string _ageRange;
		private string _name;
		private string _size;

		public string CustomerType
		{
			set{_type=value;}
			get { return _type; }
		}
		public string AgeRange
		{
			set { _ageRange = value; }
			get { return _ageRange; }
		}

		public string Size
		{
			set { _size = value; }
			get { return _size; }
		}

		public Customer() { }
		public Customer(string name, string type, string ageRange)
		{
			_name = name;
			_type = type;
			_ageRange = ageRange;
		}
		public Customer(string name, string type, string ageRange,string size)
		{
			_name = name;
			_type = type;
			_ageRange = ageRange;
			_size = size;
		}
	}
}
