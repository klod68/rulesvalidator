using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using Klod.Test.RulesValidation.View;
using Klod.Test.RulesValidation.Controller;
using Klod.Validation;

namespace Klod.Test.RulesValidation
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// Validates true if Senior and discount more than five
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void ValidateButton_Click(object sender, EventArgs e)
		{
            SalesView rule1 = new SalesView();
            rule1.CustomerType = CustomerTypeList.Text;
            rule1.AgeRange = AgeRangeList.Text;
            rule1.DiscountMin = decimal.Parse(MinValueTextBox.Text);
            rule1.DiscountMax = decimal.Parse(MaxValueTextBox.Text);
            bool r = RulesValidationController.Rule1Validation(rule1);

			string message = "The rule " + ConfigurationManager.AppSettings["Rule1"] + " validates: " + r.ToString();
            ClientScript.RegisterStartupScript(Page.GetType(), "Validation", "alert('" + message + "');", true);

        }

        /// <summary>
        /// Gold customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ValidateButton2_Click(object sender, EventArgs e)
		{

            SalesView rule2 = new SalesView();
            rule2.CustomerType = CustomerTypeList.Text;
            rule2.AgeRange = AgeRangeList.Text;
            bool r = RulesValidationController.Rule2Validation(rule2);

            string message = "The rule " + ConfigurationManager.AppSettings["Rule2"] + " validates: " + r.ToString();
            ClientScript.RegisterStartupScript(Page.GetType(), "Validation", "alert('" + message + "');", true);
        }
		/// <summary>
		/// Vip discount for platinum customer and 15-35 discount
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void ValidateButton3_Click(object sender, EventArgs e)
		{
            
            SalesView rule3 = new SalesView();
            rule3.CustomerType = CustomerTypeList.Text;
            rule3.AgeRange = AgeRangeList.Text;
            rule3.VipDiscount = decimal.Parse(VipDiscountTextBox.Text);
            bool r = RulesValidationController.Rule3Validation(rule3);

            string message = "The rule " + ConfigurationManager.AppSettings["Rule3"] + " validates: " + r.ToString();
            ClientScript.RegisterStartupScript(Page.GetType(), "Validation", "alert('" + message + "');", true);


        }
		/// <summary>
		/// Size verification.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void ValidateButton4_Click(object sender, EventArgs e)
		{

            SalesView rule4 = new SalesView();
            rule4.CustomerType = CustomerTypeList.Text;
            rule4.AgeRange = AgeRangeList.Text;
            rule4.Size = CustomerSizeTextBox.Text;
            bool r = RulesValidationController.Rule4Validation(rule4);

            string message = "The rule " + ConfigurationManager.AppSettings["Rule4"] + " validates: " + r.ToString();
            ClientScript.RegisterStartupScript(Page.GetType(), "Validation", "alert('" + message + "');", true);

        }

        protected void ValidateButton5_Click(object sender, EventArgs e)
        {

            SalesView rule5 = new SalesView();
            rule5.AgeRange = AgeRangeList.Text;
            rule5.DiscountMin = decimal.Parse(MinValueTextBox.Text);
            rule5.DiscountMax = decimal.Parse(MaxValueTextBox.Text);

            bool r = RulesValidationController.Rule5Validation(rule5);

            string message = "The rule " + ConfigurationManager.AppSettings["Rule5"] + " validates: " + r.ToString();
            ClientScript.RegisterStartupScript(Page.GetType(), "Validation", "alert('" + message + "');", true);
        }


    }
}
