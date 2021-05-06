using System;
using System.Threading;
using AutomationPracticeTestFramework;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;


namespace AutomationPracticeTestFramework
{
    public class Selenium_AP_SigninTests
    {
        //create an AP_Website instance
        public AP_Website AP_Website { get; } = new AP_Website("chrome");
        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheSignInLink_ThenIGoToTheSignInPage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
            AP_Website.AP_HomePage.ClickSigninLink();
            //Assert - that we are now on teh sign in page
            Assert.That(AP_Website.GetPageTitle(), Is.EqualTo("Login - My Store"));
        }

        [Test]
        public void GivenIAmOnTHeSigninPage_AndIEnterA4DigitPassword_WhenIClickTheSignInButton_IGetAnErrorMessage()
        {
            //navigate to the sign in page
            AP_Website.AP_SigninPage.VisitSigninPage();
            //enter a valid email
            AP_Website.AP_SigninPage.InputEmail("testing@snailmail.com");
            //enter a password of less than four characters
            AP_Website.AP_SigninPage.InputPassword("four");
            //Act - click the login button
            AP_Website.AP_SigninPage.ClickSigninLink();
            //Assert
            // check the error message is correct
            Assert.That(AP_Website.AP_SigninPage.GetAlertMessage().Contains("Invalid password"));
        }

        [Test]
        public void GivenIAmOnTHeSigninPage_AndIEnterInvalidEmail_WhenIClickTheSignInButton_IGetAnErrorMessage()
        {
            //navigate to the sign in page
            AP_Website.AP_SigninPage.VisitSigninPage();
            //enter a valid email
            AP_Website.AP_SigninPage.InputEmail("wrongemail");
            //enter a password of less than four characters
            AP_Website.AP_SigninPage.InputPassword("password");
            //Act - click the login button
            AP_Website.AP_SigninPage.ClickSigninLink();
            //Assert
            // check the error message is correct
            Assert.That(AP_Website.AP_SigninPage.GetAlertMessage().Contains("Invalid email address"));
        }

        [Test]
        public void GivenIAmOnTHeSigninPage_AndIEnterNoEmail_WhenIClickTheSignInButton_IGetAnErrorMessage()
        {

            //navigate to the sign in page
            AP_Website.AP_SigninPage.VisitSigninPage();
            //enter a valid email
            AP_Website.AP_SigninPage.InputEmail("");
            //enter a password of less than four characters
            AP_Website.AP_SigninPage.InputPassword("password");
            //Act - click the login button
            AP_Website.AP_SigninPage.ClickSigninLink();
            //Assert
            // check the error message is correct
            Assert.That(AP_Website.AP_SigninPage.GetAlertMessage().Contains("An email address required"));
        }

        [Test]
        public void GivenIAmOnTHeSigninPage_AndIEnterNoPassword_WhenIClickTheSignInButton_IGetAnErrorMessage()
        {
            //navigate to the sign in page
            AP_Website.AP_SigninPage.VisitSigninPage();
            //enter a valid email
            AP_Website.AP_SigninPage.InputEmail("testing@snailmail.com");
            //enter a password of less than four characters
            AP_Website.AP_SigninPage.InputPassword("");
            //Act - click the login button
            AP_Website.AP_SigninPage.ClickSigninLink();
            //Assert
            // check the error message is correct
            Assert.That(AP_Website.AP_SigninPage.GetAlertMessage().Contains("Password is required"));
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
