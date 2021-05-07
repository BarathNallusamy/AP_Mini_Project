using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TechTalk.SpecFlow;

namespace AutomationPracticeTestFramework.BDD
{
    [Binding]
    public class AP_CheckoutSteps
    {
        private readonly AP_Website AP_Website = new AP_Website("chrome");
        private readonly AP_SigninSteps AP_SigninSteps = new AP_SigninSteps();

        [Given(@"I am on the homepage and I sign in and add t shirt to the cart")]
        public void GivenIAmOnTheHomepageAndISignInAndAddTShirtToTheCart()
        {
            AP_SigninSteps.GivenIAmOnThHomePage();
            AP_SigninSteps.GivenIHaveClickedTheSigninLink();
            AP_SigninSteps.GivenIHaveEnteredTheEmail("test@sparta.com");
            AP_SigninSteps.GivenIHaveEnteredThePassword("sparta");
            AP_SigninSteps.WhenIClickTheSignInButton();
            AP_Website.AP_HomePage.ClickOnTheCart();
        }

        [Test]
        public void ClickOnCart()
        {
            AP_SigninSteps.GivenIAmOnThHomePage();
            AP_Website.AP_HomePage.ClickOnTheCart();
        }

        [Given(@"go to checkout page")]
        public void GivenGoToCheckoutPage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"click proceed to checkout \(to step (.*)\)")]
        public void GivenClickProceedToCheckoutToStep(int p0)
        {
            ScenarioContext.Current.Pending();
        }












        [Then(@"I move to the Tshirt results page")]
        public void ThenIMoveToTheTshirtResultsPage()
        {
            Assert.That(AP_Website.GetPageTitle(), Is.EqualTo("T-shirts - My Store"));
        }

        [When(@"I click proceed to checkout")]
        public void WhenIClickProceedToCheckout()
        {
            AP_Website.AP_Checkout.ClickProceedLink();
        }


        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
