using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using WooliesX_Tech.Pages;
using WooliesX_Tech.Core;
using OpenQA.Selenium;
using System.Configuration;

namespace WooliesX_Tech.Pages
{
   public  class LoginPage : BasePage
    {

        private IWebElement SignInButton => Driver.FindControl(By.XPath("//a[@class='login']"),true,true);

        private IWebElement Email => Driver.FindControl(By.Id("email"),true);

        private IWebElement Password => Driver.FindControl(By.Id("passwd"),true);

        private IWebElement LoginButton => Driver.FindControl(By.Id("SubmitLogin"),true,true);


        public void NavigateToHomePage()
        {
            Driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }

        public void NavigateToLoginPage()
        {
            SignInButton.Click();
        }

        public void Login(string email = null, string password = null)
        {
            Email.Clear();
            Email.SendKeys(ConfigurationManager.AppSettings["UserName"]);
            Password.Clear();
            Password.SendKeys(ConfigurationManager.AppSettings["Password"]);
            LoginButton.Click();
        }
    }
}
