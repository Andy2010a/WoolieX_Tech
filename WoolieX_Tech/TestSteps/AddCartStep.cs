using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WooliesX_Tech.Pages;

namespace WooliesX_Tech.TestSteps
{    
    [Binding]
    public class AddCartStep : BaseTestStep
    {
        private LoginPage loginPage = new LoginPage();
        private MyAccountPage myAccountPage = new MyAccountPage();
        private DressesPage dressesPage = new DressesPage();
        private ShoppingCartSummaryPage shoppingCartSummaryPage = new ShoppingCartSummaryPage();
        private ShoppingCartAddressPage shoppingCartAddressPage = new ShoppingCartAddressPage();
        private ShoppngCartShippingPage shoppngCartShippingPage = new ShoppngCartShippingPage();
        private ShoppingCartPaymentPage shoppingCartPaymentPage = new ShoppingCartPaymentPage();
        private Confirmation confirmation = new Confirmation();

        [Given(@"I have Navigated to site")]
        public void GivenIHaveNavigatedToSite()
        {
            loginPage.NavigateToHomePage();
        }

        [When(@"I Click on Signin link")]
        public void WhenIClickOnSigninLink()
        {
            loginPage.NavigateToLoginPage();
        }

        [When(@"I use valid credentials")]
        public void WhenIUseValidCredentials()
        {
            loginPage.Login();
        }

        [Then(@"I should login")]
        public void ThenIShouldLogin()
        {
            myAccountPage.AssertAccountName();
        }

        [When(@"I add products to cart")]
        public void ThenIAddProductsToCart()
        {
            myAccountPage.ClickDresses();
            dressesPage.AddToCart();
            dressesPage.ProceedToCheckOut();
        }


        [Then(@"I can Place the order")]
        public void ThenICanPlaceTheOrder()
        {
            shoppingCartSummaryPage.AssertPrdouctCount();
            shoppingCartSummaryPage.ProceedToCheckOut();
            shoppingCartAddressPage.ProceedToCheckOut();
            shoppngCartShippingPage.AcceptTerms();
            shoppngCartShippingPage.ProceedToCheckOut();
            shoppingCartPaymentPage.PayByBank();            
            confirmation.ConfirmOrderToBuy();
            confirmation.AssertFinalConfirmation();
        }


    }
}
