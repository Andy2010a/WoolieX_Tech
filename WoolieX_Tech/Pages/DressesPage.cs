using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WooliesX_Tech.Core;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Interactions;

namespace WooliesX_Tech.Pages
{
    class DressesPage : BasePage
    {
        
        private IWebElement ListLink => Driver.FindControl(By.Id("list"),true);
        private IList<IWebElement> Products  => Driver.FindControls(By.XPath("//a[@class='button ajax_add_to_cart_button btn btn-default']"));
        private IWebElement ContinueButton => Driver.FindControl(By.XPath("//span[@class='continue btn btn-default button exclusive-medium']"),true,true);
        private IWebElement ProceedToCheckOutButton => Driver.FindControl(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a/span"),true,true);
            
        
        public void AddToCart()
        {
            ListLink.Click();
            Products[0].Click();
            ContinueButton.Click();         
            Products[1].Click();
        }

        public  void ProceedToCheckOut()
        {
            ProceedToCheckOutButton.Click();
           
        }

      





    }
}




