using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPracticeTestFramework
{
    public class AP_ForgotPassword
    {
        public IWebDriver SeleniumDriver { get; }
        private readonly string ForgotPassUrl = AppConfigReader.ForgotPassUrl;
        private IWebElement _emailField => SeleniumDriver.FindElement(By.Id("email"));
        private IWebElement _retrieveBtn => SeleniumDriver.FindElement(By.CssSelector(".button-medium:nth-child(1) > span"));
        private IWebElement _alert => SeleniumDriver.FindElement(By.ClassName("alert"));
        public AP_ForgotPassword(IWebDriver seleniumDriver)
        {
            SeleniumDriver = seleniumDriver;
        }
        public void VisitForgotPassPage()
        {
            SeleniumDriver.Navigate().GoToUrl(ForgotPassUrl);
        }
        public void InputEmail(string email)
        {
            _emailField.SendKeys(email);
        }
        public void ClickRetrieveLink()
        {
            _retrieveBtn.Click();
        }
        public string GetAlertMessage()
        {
            return _alert.Text;
        }
    }
}
