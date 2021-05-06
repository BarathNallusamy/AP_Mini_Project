using OpenQA.Selenium;

namespace AutomationPracticeTestFramework
{
    public class AP_SigningPage
    {
        public IWebDriver SeleniumDriver { get; }
        private readonly string SigninPageUrl = AppConfigReader.SigninPageUrl;
        private IWebElement _signinLink => SeleniumDriver.FindElement(By.Id("SubmitLogin"));
        private IWebElement _emailField => SeleniumDriver.FindElement(By.Id("email"));
        private IWebElement _passwordField => SeleniumDriver.FindElement(By.Id("passwd"));
        private IWebElement _alert => SeleniumDriver.FindElement(By.ClassName("alert"));
        private IWebElement _createAccEmailField => SeleniumDriver.FindElement(By.Id("email_create"));
        private IWebElement _createAccBtn => SeleniumDriver.FindElement(By.Id("SubmitCreate"));
        private IWebElement _ForgotPassBtn => SeleniumDriver.FindElement(By.LinkText("Forgot your password?"));
        public AP_SigningPage(IWebDriver seleniumDriver)
        {
            SeleniumDriver = seleniumDriver;
        }
        public string GetAlertMessage()
        {
            return _alert.Text;
        }
        public void InputEmail(string email)
        {
            _emailField.SendKeys(email);
        }
        public void InputPassword(string password)
        {
            _passwordField.SendKeys(password);
        }
        public void VisitSigninPage()
        {
            SeleniumDriver.Navigate().GoToUrl(SigninPageUrl);
        }
        public void ClickSigninLink()
        {
            _signinLink.Click();
        }
        public void InputEmailCreateAcc(string email)
        {
            _createAccEmailField.SendKeys(email);
        }
        public void ClickCreateAccLink()
        {
            _createAccBtn.Click();
        }

        public void ClickForgotPassBtn()
        {
            _ForgotPassBtn.Click();
        }
        //public void ExampleHover()
        //{
        //    OpenQA.Selenium.Actions action = new Actions(driver);
        //    action.MoveToElement(homeAndGardenElement).Perform();
        //}
    }
}