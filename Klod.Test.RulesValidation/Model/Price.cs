using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klod.Test.RulesValidation.Model
{
	public class Price
	{
		decimal _total;
		decimal _retailPrice;
		decimal _discount;

		public Price(){}
		public Price(decimal retailPrice)
		{
			_retailPrice=retailPrice;
		}
		public Price(decimal retailPrice,decimal discount)
		{
			_retailPrice=retailPrice;
			_discount=discount;
			_total=_retailPrice-_discount;
		}

		public Decimal Total
		{
			set;get;
		}
		public Decimal RetailPrice
		{
			set;get;
		}
		public Decimal Discount
		{
			set;get;
		}	
	}
}