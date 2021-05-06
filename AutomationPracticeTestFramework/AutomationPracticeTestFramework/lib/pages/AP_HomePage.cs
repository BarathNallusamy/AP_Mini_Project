using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace AutomationPracticeTestFramework
{
    public class AP_HomePage
    {
        public IWebDriver SeleniumDriver { get; }
        private string HomePageUrl = AppConfigReader.BaseUrl;
        private IWebElement _signinLink => SeleniumDriver.FindElement(By.LinkText("Sign in"));
        private IWebElement _womanLink => SeleniumDriver.FindElement(By.ClassName("sf-with-ul"));
        private IWebElement _tshirtLink => SeleniumDriver.FindElement(By.LinkText("T-shirts"));



        public AP_HomePage(IWebDriver seleniumDriver)
        {
            SeleniumDriver = seleniumDriver;
        }

        public void VisitHomePage()
        {
            SeleniumDriver.Navigate().GoToUrl(HomePageUrl);
        }
        public void ClickSigninLink()
        {
            _signinLink.Click();
        }

        public void ClickTshirtBtn()
        {
            Actions action = new Actions(SeleniumDriver);
            action.MoveToElement(_womanLink).Perform();
            Thread.Sleep(5000);
            _tshirtLink.Click();
        }
    }
}