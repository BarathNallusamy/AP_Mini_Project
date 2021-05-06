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
            Thread.Sleep(2000);
        }
        
        [When(@"I add a T-shirt to the cart")]
        public void WhenIAddAT_ShirtToTheCart()
        {
            _website.AP_Product.ClickAddToCart();
        }
        
        [Then(@"I get a success alert ""(.*)""")]
        public void ThenIGetASuccessAlert(string message)
        {
            Assert.That(_website.AP_Product.GetAlertSuccess(), Does.Contain(message));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            _website.SeleniumDriver.Quit();
            _website.SeleniumDriver.Dispose();
        }
    }
}
