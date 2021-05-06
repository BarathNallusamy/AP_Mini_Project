using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace AutomationPracticeTestFramework
{
    public class AP_TshirtPage
    {
        public IWebDriver SeleniumDriver { get; }
        private string TshirtPageUrl = "http://automationpractice.com/index.php?id_category=5&controller=category";

        private IWebElement _productView => SeleniumDriver.FindElement(By.LinkText("More"));
        private IWebElement _productHover => SeleniumDriver.FindElement(By.CssSelector(".lnk_view > span"));
        private IWebElement _addToCart => SeleniumDriver.FindElement(By.CssSelector(".exclusive > span"));
        private IWebElement _successMessage => SeleniumDriver.FindElement(By.ClassName("layer_cart_product"));



        public AP_TshirtPage(IWebDriver seleniumDriver)
        {
            SeleniumDriver = seleniumDriver;
        }

        public void VisitTshirtCatPage()
        {
            SeleniumDriver.Navigate().GoToUrl(TshirtPageUrl);
        }

        public void ClickProductViewBtn()
        {
            Actions action = new Actions(SeleniumDriver);
            action.MoveToElement(_productHover).Perform();
            Thread.Sleep(5000);
            _productView.Click();
        }

        public void AddProductToCart()
        {
            _addToCart.Click();
            Thread.Sleep(5000);
        }

        public string GetSuccessfullyAddedMessage()
        {
            return _successMessage.Text;
        }
    }
}