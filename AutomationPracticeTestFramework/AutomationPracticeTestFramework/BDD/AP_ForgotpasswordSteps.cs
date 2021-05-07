using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationPracticeTestFramework
{
    [Binding]
    public class AP_ForgotpasswordSteps
    {
        private readonly AP_Website AP_Website = new AP_Website("chrome");

        [Given(@"I Am On The SignIn Page")]
        public void GivenIAmOnTheSignInPage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
        }
        
        [Given(@"I Am On The Forgot Password Page")]
        public void GivenIAmOnTheForgotPasswordPage()
        {
            AP_Website.AP_ForgotPassword.VisitForgotPassPage();
        }
        
        [When(@"I Click The Forgot Password Btn")]
        public void WhenIClickTheForgotPasswordBtn()
        {
            AP_Website.AP_SigninPage.ClickForgotPassBtn();
        }
        
        [When(@"I Click The Retrieve Password Btc With An Email ""(.*)""")]
        public void WhenIClickTheRetrievePasswordBtcWithAnEmail(string email)
        {
            AP_Website.AP_ForgotPassword.InputEmail(email);
            AP_Website.AP_ForgotPassword.ClickRetrieveLink();
        }
        
        [Then(@"I Go To The Forgot Password Page ""(.*)""")]
        public void ThenIGoToTheForgotPasswordPage(string pageTitle)
        {
            Assert.That(AP_Website.GetPageTitle(), Is.EqualTo(pageTitle));
        }
        
        [Then(@"I Got A Message ""(.*)""")]
        public void ThenIGotAMessage(string message)
        {
            Assert.That(AP_Website.AP_ForgotPassword.GetAlertMessage(), Does.Contain(message));
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
