using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomationPracticeTestFramework
{
    //class AP_CreateAccount
    //{
    //    public IWebDriver SeleniumDriver { get; }
    //    private readonly string CreateAccUrl = AppConfigReader.CreateAccUrl;
    //    private IWebElement _titleRadido => SeleniumDriver.FindElement(By.Name("id_gender")); //value 1 = Mr, 2 = Mrs
    //    private IWebElement _fNameField => SeleniumDriver.FindElement(By.Id("customer_firstname"));
    //    private IWebElement _lNameField => SeleniumDriver.FindElement(By.Id("customer_lastname"));
    //    private IWebElement _emailField => SeleniumDriver.FindElement(By.Id("email"));
    //    private IWebElement _passwordField => SeleniumDriver.FindElement(By.Id("passwd"));
    //    private IWebElement _DateBrthDList => SeleniumDriver.FindElement(By.Id("days")); //1-31
    //    private IWebElement _DateBrthMList => SeleniumDriver.FindElement(By.Id("months"));//1-12
    //    private IWebElement _DateBrthYList => SeleniumDriver.FindElement(By.Id("years"));//1900-2021
    //    private IWebElement _newsletterField => SeleniumDriver.FindElement(By.Id("newsletter"));


    //    public AP_SigningPage(IWebDriver seleniumDriver)
    //    {
    //        SeleniumDriver = seleniumDriver;
    //    }

    //    public string GetAlertMessage()
    //    {
    //        return _alert.Text;
    //    }
    //    public void WriteEmail(string email)
    //    {
    //        _emailField.SendKeys(email);
    //    }
    //    public void WritePassword(string password)
    //    {
    //        _passwordField.SendKeys(password);
    //    }
    //    public void VisitSigninPage()
    //    {
    //        SeleniumDriver.Navigate().GoToUrl(SigninPageUrl);
    //    }
    //    public void ClickSigninLink()
    //    {
    //        _signinLink.Click();
    //    }
    //}
}
