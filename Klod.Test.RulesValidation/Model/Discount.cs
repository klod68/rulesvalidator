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
	public class Discount
	{
		private decimal _maxValue;
		private decimal _minValue;
		private decimal _vipValue;

		public decimal MaxValue
		{
			set { _maxValue = value; }
			get { return _maxValue; }
		}
		public decimal MinValue
		{
			set { _minValue = value; }
			get { return _minValue; }
		}
		public decimal VipValue
		{
			set { _vipValue = value; }
			get { return _vipValue; }
		}
		public Discount() { }
		public Discount(decimal minValue, decimal maxValue)
		{
			_minValue = minValue;
			_maxValue = maxValue;
		}
		public Discount(decimal minValue, decimal maxValue,decimal vipValue)
		{
			_minValue = minValue;
			_maxValue = maxValue;
			_vipValue = vipValue;
		}
	}
}
