using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WooliesX_Tech.Core;
using OpenQA.Selenium;
using System.Net;
using System.Configuration;
using TechTalk.SpecFlow;



namespace WooliesX_Tech.TestSteps
{ 
    [Binding]
   public  class BaseTestStep
    {
        public static IWebDriver driver = null;

        [BeforeTestRun]
        private static void Setup()
        {
            driver = WebDriverFactory.CreateDriver((DriverType)Enum.Parse(typeof(DriverType), ConfigurationManager.AppSettings["DriverType"]));
        }

        [After]
        private void Teardown()
        {
            driver.Quit();
        }
    }
}
