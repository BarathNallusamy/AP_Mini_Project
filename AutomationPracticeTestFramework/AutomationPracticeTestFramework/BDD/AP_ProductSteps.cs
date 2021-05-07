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


        [AfterScenario]
        public void DisposeWebDriver()
        {
            _website.SeleniumDriver.Quit();
            _website.SeleniumDriver.Dispose();
        }
    }
}




