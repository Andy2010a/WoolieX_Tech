using WooliesX_Tech.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WooliesX_Tech.Pages
{
    public class MyAccountPage : BasePage
    {
        private IWebElement AccountName => Driver.FindControl(By.XPath("//a[@title='View my customer account']"),true);
        private IWebElement MyAccountTab => Driver.FindControl(By.XPath("//span[@class='navigation_page']"),true);


        private IWebElement DressesButton => Driver.FindControl(By.ClassName("sf-with-ul"));
        private IWebElement SignOutLink => Driver.FindControl(By.LinkText("Sign out"));

        public void AssertAccountName()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Anand M", AccountName.Text);
                Assert.AreEqual("My account", MyAccountTab.Text);
            });
        }
        public void ClickDresses()
        {
            DressesButton.Click();

        }
        public void SignOut()
        {
            SignOutLink.Click();
        }
    }
}
