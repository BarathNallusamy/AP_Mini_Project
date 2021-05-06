using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationPracticeTestFramework;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationPracticeTestFramework
{
    public class Selenium_AP_ForgotPasswordTest
    {
        public AP_Website AP_Website { get; } = new AP_Website("chrome");

        [Test]
        public void GivenIAmOnTheSignInPage_WhenIClickTheForgotPasswordBtn_ThenIGoToForgotPasswordPage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.ClickForgotPassBtn();
            //Assert - that we are now on the forgot in page
            Assert.That(AP_Website.GetPageTitle(), Is.EqualTo("Forgot your password - My Store"));
        }
        [Test]
        public void GivenIAmOnTheForgotPasswordPage_WhenIClickTheRetrievePasswordBtcWithValidEmail_ThenIGotASuccefulMessage()
        {
            var email = "testing@snailmail.com";
            AP_Website.AP_ForgotPassword.VisitForgotPassPage();
            AP_Website.AP_ForgotPassword.InputEmail(email);
            AP_Website.AP_ForgotPassword.ClickRetrieveLink();
            Assert.That(AP_Website.AP_ForgotPassword.GetAlertMessage(), Is.EqualTo($"A confirmation email has been sent to your address: {email}"));
        }

        [Test]
        public void GivenIAmOnTheForgotPasswordPage_WhenIClickTheRetrievePasswordBtcWithInvalidEmail_ThenIGotAnErrorMessage()
        {
            AP_Website.AP_ForgotPassword.VisitForgotPassPage();
            AP_Website.AP_ForgotPassword.InputEmail("wrong");
            AP_Website.AP_ForgotPassword.ClickRetrieveLink();
            Assert.That(AP_Website.AP_ForgotPassword.GetAlertMessage(), Is.EqualTo("There is 1 error\r\nInvalid email address."));
        }

        [Test]
        public void GivenIAmOnTheForgotPasswordPage_WhenIClickTheRetrievePasswordBtcWithNotExistingEmail_ThenIGotAnErrorMessage()
        {
            AP_Website.AP_ForgotPassword.VisitForgotPassPage();
            AP_Website.AP_ForgotPassword.InputEmail("wrong@qwe.zx");
            AP_Website.AP_ForgotPassword.ClickRetrieveLink();
            Assert.That(AP_Website.AP_ForgotPassword.GetAlertMessage(), Is.EqualTo("There is 1 error\r\nThere is no account registered for this email address."));
        }



        [OneTimeTearDown]
        public void TearDown()
        {
            //quits the driver, closing all associated windows
            AP_Website.SeleniumDriver.Quit();
            //release resources
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}