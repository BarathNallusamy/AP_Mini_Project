using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomationPracticeTestFramework
{
    public class AP_HomePage
    {
        public IWebDriver SeleniumDriver { get; }
        private string HomePageUrl = AppConfigReader.BaseUrl;
        private IWebElement _signinLink => SeleniumDriver.FindElement(By.LinkText("Sign in"));
        private IWebElement _tshirtLink => SeleniumDriver.FindElement(By.LinkText("T-shirts"));
        private IWebElement _cartLink => SeleniumDriver.FindElement(By.XPath("//header[@id='header']/div[3]/div/div/div[3]/div/a"));
        private IWebElement _checkoutLink => SeleniumDriver.FindElement(By.Id("button_order_cart"));
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

        public void ClickTshirtLink()
        {
            _tshirtLink.Click();
        }

        public void ClickOnTheCart()
        {
            Actions action = new Actions(SeleniumDriver);
            action.MoveToElement(_cartLink).Perform();
            Thread.Sleep(5000);
            _checkoutLink.Click();
        }
    }
}