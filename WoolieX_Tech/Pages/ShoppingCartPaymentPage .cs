using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooliesX_Tech.Core;
using OpenQA.Selenium;

namespace WooliesX_Tech.Pages
{
    class ShoppingCartPaymentPage :BasePage
    {

        private IWebElement payByBankButton => Driver.FindControl(By.ClassName("bankwire"));

        public void  PayByBank()
        {
            payByBankButton.Click();
            
        }
    }
}
