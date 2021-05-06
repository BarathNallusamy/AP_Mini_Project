using System;
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
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Click The Forgot Password Btn")]
        public void WhenIClickTheForgotPasswordBtn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Click The Retrieve Password Btc With An Email ""(.*)""")]
        public void WhenIClickTheRetrievePasswordBtcWithAnEmail(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I Go To The Forgot Password Page ""(.*)""")]
        public void ThenIGoToTheForgotPasswordPage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I Got A Message ""(.*)""")]
        public void ThenIGotAMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
