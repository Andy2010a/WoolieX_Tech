using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;


namespace WooliesX_Tech.Core
{
    static class ElementFinder
    {
        public static IWebElement FindControl(this IWebDriver driver, By findBy, bool ensureVisibility = false,
          bool isClickable = false, bool moveElement=false)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                var element = wait.Until(drv => drv.FindElement(findBy));
               

                if (ensureVisibility)
                {
                    wait.Until(drv => element.Displayed);
                    wait.Until(drv => element.Enabled);
                }

                if (isClickable)
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
                }


                return element;
            }
            catch (Exception)
            {
                Console.WriteLine($"INFO: Element not found.\n{findBy}");
                throw;
            }
        }

 

        public static IList<IWebElement> FindControls(this IWebDriver driver, By findBy, bool ensureVisibility = false,
         bool isClickable = false, bool moveElement = false)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

                var elements = wait.Until(drv => drv.FindElements(findBy));

                if (ensureVisibility)
                {
                    wait.Until(drv => elements[0].Displayed);
                    wait.Until(drv => elements[0].Enabled);
                }

                if (isClickable)
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elements[0]));
                }



                return elements;
            }
            catch (Exception)
            {
                Console.WriteLine($"INFO: Element Collection  not found.\n{findBy}");
                throw;
            }

        }

    }
}
