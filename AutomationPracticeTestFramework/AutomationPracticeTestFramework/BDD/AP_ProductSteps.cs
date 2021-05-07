using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AutomationPracticeTestFramework
{
    [Binding]
    public class AP_ProductSteps
    {
        private AP_Website _website = new AP_Website("chrome");

        [Given(@"I am on the homepage")]
        public void GivenIAmOnTheHomepage()
        {
            _website.AP_HomePage.VisitHomePage();
        }
        
        [Given(@"I click the T-shirts tab")]
        public void GivenIClickTheT_ShirtsTab()
        {
            _website.AP_Product.ClickTshirtTab();
            Thread.Sleep(3000);
        }
        
        [When(@"I add a T-shirt to the cart")]
        public void WhenIAddAT_ShirtToTheCart()
        {
            _website.AP_Product.ClickAddToCart();
            Thread.Sleep(3000);
        }
        
        [Then(@"I get a success alert ""(.*)""")]
        public void ThenIGetASuccessAlert(string message)
        {
            Assert.That(_website.AP_Product.GetAlertSuccess(), Does.Contain(message));
        }


        [Given(@"I added a T-shirt to basket")]
        public void GivenIAddedAT_ShirtToBasket()
        {
            GivenIAmOnTheHomepage();
            GivenIClickTheT_ShirtsTab();
            WhenIAddAT_ShirtToTheCart();
            Thread.Sleep(3000);
        }

        [Given(@"I click the proceed to checkout button")]
        public void GivenIClickTheProceedToCheckoutButton()
        {
            _website.AP_Product.ClickProceedButton();
            Thread.Sleep(3000);
        }

        [Given(@"I click to proceed to the sign in page")]
        public void GivenIClickToProceedToTheSignInPage()
        {
            _website.AP_Product.ClickProceedToSignIn();
            Thread.Sleep(3000);
        }

        [Given(@"I enter an email address ""(.*)""")]
        public void GivenIEnterAnEmailAddress(string email)
        {
            _website.AP_Product.InputEmail(email);
        }

        [Given(@"I enter a password ""(.*)""")]
        public void GivenIEnterAPassword(string pWord)
        {
            _website.AP_Product.InputPassword(pWord);
        }

        [When(@"I click sign in")]
        public void WhenIClickSignIn()
        {
            _website.AP_Product.ClickSigninLink();
            Thread.Sleep(3000);
        }

        [Then(@"I see address information ""(.*)""")]
        public void ThenISeeAddressInformation(string delivery)
        {
            Assert.That(_website.AP_Product.GetDeliveryNotice(), Does.Contain(delivery));
        }

        [Given(@"I click the proceed to shipping")]
        public void GivenIClickTheProceedToShipping(string email, string pWord)
        {
            GivenIAddedAT_ShirtToBasket();
            GivenIClickTheProceedToCheckoutButton();
            GivenIClickToProceedToTheSignInPage();
            GivenIEnterAnEmailAddress(email);
            GivenIEnterAPassword(pWord);
        }


        [Given(@"I click sign in")]
        public void GivenIClickSignIn()
        {
            _website.AP_Product.ClickSigninLink();
            _website.AP_Product.ClickProceedToShipping();
            Thread.Sleep(3000);
        }



        [Given(@"I click the checkbox")]
        public void GivenIClickTheCheckbox()
        {
            _website.AP_Product.ClickShippingBox();
            Thread.Sleep(3000);
            _website.AP_Product.ClickProceedToPayment();
            Thread.Sleep(3000);
        }

        [Given(@"I click bankwire payment")]
        public void GivenIClickBankwirePayment()
        {
            _website.AP_Product.ClickBankWire();
            Thread.Sleep(3000);
        }

        [When(@"I click confirm payment")]
        public void WhenIClickConfirmPayment()
        {
            _website.AP_Product.ClickConfirmOrder();
            Thread.Sleep(3000);
        }

        [Then(@"I will see the confirmation message ""(.*)""")]
        public void ThenIWillSeeTheConfirmationMessage(string orderConf)
        {
            Assert.That(_website.AP_Product.GetOrderStatus(), Does.Contain(orderConf));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _website.SeleniumDriver.Quit();
            _website.SeleniumDriver.Dispose();
        }
    }
}




