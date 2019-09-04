using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WooliesX_Tech.Core;
using OpenQA.Selenium;
using NUnit.Framework;
namespace WooliesX_Tech.Pages
{
    class ShoppingCartSummaryPage : BasePage
    {

        private IWebElement ProceedToCheckOutButton => Driver.FindControl(By.XPath("//a[@class='button btn btn-default standard-checkout button-medium']"));
        private IList<IWebElement> TotalProducts => Driver.FindControls(By.XPath("//td[@class='cart_description']"));



        public void AssertPrdouctCount()
        {

            Assert.AreEqual(2, TotalProducts.Count);
        }


        public void ProceedToCheckOut()
        {
            ProceedToCheckOutButton.Click();          
        }
    }
}
