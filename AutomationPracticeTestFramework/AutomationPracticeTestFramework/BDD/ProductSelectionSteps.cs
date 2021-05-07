using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AutomationPracticeTestFramework.BDD
{
    [Binding]
    public class ProductSelectionSteps
    {
        private readonly AP_Website AP_Website = new AP_Website("chrome");

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
        }
        
        [When(@"I click the tshirt button from navigation pane")]
        public void WhenIClickTheTshirtButtonFromNavigationPane()
        {
            AP_Website.AP_HomePage.ClickTshirtBtn();
        }
        
        [Then(@"I should be able to navigate to the tshirt page")]
        public void ThenIShouldBeAbleToNavigateToTheTshirtPage()
        {
            Assert.That(AP_Website.GetPageTitle(), Is.EqualTo("T-shirts - My Store"));
        }

        [Given(@"I am on the tshirt category page")]
        public void GivenIAmOnTheTshirtCategoryPage()
        {
            AP_Website.AP_TshirtPage.VisitTshirtCatPage();
        }

        [When(@"I select to view a product")]
        public void WhenISelectToViewAProduct()
        {
            AP_Website.AP_TshirtPage.ClickProductViewBtn();
        }

        [Then(@"I should be able to navigate to the product page")]
        public void ThenIShouldBeAbleToNavigateToTheProductPage()
        {
            Assert.That(AP_Website.GetPageTitle(), Is.EqualTo("Faded Short Sleeve T-shirts - My Store"));
        }
        [When(@"I add the product to the cart")]
        public void WhenIAddTheProductToTheCart()
        {
            GivenIAmOnTheTshirtCategoryPage();
            WhenISelectToViewAProduct();
            AP_Website.AP_TshirtPage.AddProductToCart();
        }

        [Then(@"I should receive a Product successfully added to your shopping cart message")]
        public void ThenIShouldReceiveAProductSuccessfullyAddedToYourShoppingCartMessage()
        {
            Assert.That(AP_Website.AP_TshirtPage.GetSuccessfullyAddedMessage(), Does.Contain("Product successfully added to your shopping cart"));
        }

        [When(@"I select proceed to checkout button")]
        public void WhenISelectProceedToCheckoutButton()
        {
            WhenIAddTheProductToTheCart();
            AP_Website.AP_TshirtPage.ClickProceedToCheckoutBtn();
        }

        [Then(@"I should be able to navigate to the ""(.*)"" page")]
        public void ThenIShouldBeAbleToNavigateToThePage(string message)
        {
            Assert.That(AP_Website.GetPageTitle(), Is.EqualTo(message));
        }


        [AfterScenario]
        public void DisposeDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
