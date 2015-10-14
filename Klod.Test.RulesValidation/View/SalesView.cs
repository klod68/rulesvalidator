using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klod.Test.RulesValidation.View
{
    public class SalesView
    {
        public SalesView() { }

        public string CustomerType { get; set; }
        public string AgeRange { get; set; }
        public decimal DiscountMin { get; set; }
        public decimal DiscountMax { get; set; }
        public decimal VipDiscount { get; set; }
        public string Size { get; set; }
    }
}