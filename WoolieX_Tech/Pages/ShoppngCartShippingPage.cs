using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooliesX_Tech.Core;
using OpenQA.Selenium;


namespace WooliesX_Tech.Pages
{
    class ShoppngCartShippingPage :BasePage
    {
        private IWebElement checkbox => Driver.FindControl(By.Id("cgv"));
        private IWebElement ProceedToCheckOutButton => Driver.FindControl(By.XPath("//*[@id='form']/p/button/span"));

        public void AcceptTerms()
        {
            checkbox.Click();
        }

        public void ProceedToCheckOut()
        {
            ProceedToCheckOutButton.Click();
           
        }
    }
}
