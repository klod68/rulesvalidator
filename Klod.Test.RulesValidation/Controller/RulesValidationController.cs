using System.Collections.Generic;
using Klod.Test.RulesValidation.Model;
using Klod.Test.RulesValidation.View;
using Klod.Validation;
using System.Configuration;

namespace Klod.Test.RulesValidation.Controller
{
    public static class RulesValidationController
    {
        public static bool Rule1Validation(SalesView sales)
        {
            Customer customer = new Customer("", sales.CustomerType, sales.AgeRange);
            Discount discount = new Discount(sales.DiscountMin, sales.DiscountMax);

            RulesManagerBase ruleMan = RulesValidationFactory.MakeRulesManager();
            
            IList<object> list = new List<object>();
            list.Add(customer);
            list.Add(discount);
            return ruleMan.Validate(ConfigurationManager.AppSettings["Rule1"], list);
        }
        public static bool Rule2Validation(SalesView sales)
        {
            Customer customer = new Customer("", sales.CustomerType, sales.AgeRange);

            RulesManagerBase ruleMan = RulesValidationFactory.MakeRulesManager();

            IList<object> list = new List<object>();
            list.Add(customer);
            return ruleMan.Validate(ConfigurationManager.AppSettings["Rule2"], list);
        }
        public static bool Rule3Validation(SalesView sales)
        {
            Customer customer = new Customer("", sales.CustomerType, sales.AgeRange);
            Discount discount = new Discount(0,0,sales.VipDiscount);

            RulesManagerBase ruleMan = RulesValidationFactory.MakeRulesManager();

            IList<object> list = new List<object>();
            list.Add(customer);
            list.Add(discount);
            return ruleMan.Validate(ConfigurationManager.AppSettings["Rule3"], list);
        }
        public static bool Rule4Validation(SalesView sales)
        {
            Customer customer = new Customer("", sales.CustomerType, sales.AgeRange,sales.Size);

            RulesManagerBase ruleMan = RulesValidationFactory.MakeRulesManager();

            IList<object> list = new List<object>();
            list.Add(customer);
            return ruleMan.Validate(ConfigurationManager.AppSettings["Rule4"], list);
        }
    }
}