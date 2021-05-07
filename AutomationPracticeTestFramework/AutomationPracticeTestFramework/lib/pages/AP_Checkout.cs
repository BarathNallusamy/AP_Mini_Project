using OpenQA.Selenium;

namespace AutomationPracticeTestFramework
{
    public class AP_Checkout
    {
        public IWebDriver SeleniumDriver { get; }
        private readonly string CheckoutUrl = AppConfigReader.CheckoutUrl;
        private IWebElement _proceedLink => SeleniumDriver.FindElement(By.LinkText("Proceed to checkout"));
        public AP_Checkout(IWebDriver seleniumDriver)
        {
            SeleniumDriver = seleniumDriver;
        }
        public void VisitCheckoutPage()
        {
            SeleniumDriver.Navigate().GoToUrl(CheckoutUrl);
        }
        public void ClickProceedLink()
        {
            _proceedLink.Click();
        }
    }
}


