using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationPracticeTestFramework.BDD
{
    [Binding]
    public class AP_SigninSteps
    {
        private readonly AP_Website AP_Website = new AP_Website("chrome");

        [Given(@"I am on the signin page")]
        public void GivenIAmOnTheSigninPage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
        }
        
        [Given(@"I have entered the email ""(.*)""")]
        public void GivenIHaveEnteredTheEmail(string email)
        {
            AP_Website.AP_SigninPage.InputEmail(email);
        }
        
        [Given(@"I have entered the password (.*)")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            AP_Website.AP_SigninPage.InputPassword(password);
        }
        
        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            AP_Website.AP_SigninPage.ClickSigninLink();
        }
        
        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string message)
        {
            Assert.That(AP_Website.AP_SigninPage.GetAlertMessage().Contains(message));
        }

        [Given(@"I am on th home page")]
        public void GivenIAmOnThHomePage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
        }

        [Given(@"I have clicked the signin link")]
        public void GivenIHaveClickedTheSigninLink()
        {
            AP_Website.AP_HomePage.ClickSigninLink();
        }

        [Then(@"I will be on the signin page")]
        public void ThenIWillBeOnTheSigninPage()
        {
            Assert.That(AP_Website.GetPageTitle(), Is.EqualTo("Login - My Store"));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
