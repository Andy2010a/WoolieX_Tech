using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooliesX_Tech.Core;
using OpenQA.Selenium;

namespace WooliesX_Tech.Pages
{
    class ShoppingCartAddressPage : BasePage
    {
        private IWebElement ProceedToCheckOutButton => Driver.FindControl(By.XPath("//*[@id='center_column']/form/p/button/span"));

        public void ProceedToCheckOut()
        {
            ProceedToCheckOutButton.Click();          
        }
    }
}
