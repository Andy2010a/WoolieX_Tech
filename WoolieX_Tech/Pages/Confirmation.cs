using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WooliesX_Tech.Core;
using OpenQA.Selenium;
using NUnit.Framework;

namespace WooliesX_Tech.Pages
{
    class Confirmation : BasePage
    {

        private IWebElement ConfirmOrder => Driver.FindControl(By.XPath("//button[@class='button btn btn-default button-medium']"));
        private IWebElement FianlConfirmation => Driver.FindControl(By.XPath("//h1[@class='page-heading']"));

        public void ConfirmOrderToBuy()
        {
            ConfirmOrder.Click();
        }

        public void AssertFinalConfirmation()
        {

            Assert.IsTrue( FianlConfirmation.Text== "ORDER CONFIRMATION");
        }


    }
}
