using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomationPracticeTestFramework
{
    public class AP_Product
    {
        public IWebDriver SeleniumDriver { get; }
        private readonly string CheckoutOrderUrl = AppConfigReader.CheckoutOrderUrl;
        private IWebElement _proceedButton => SeleniumDriver.FindElement(By.CssSelector(".button btn btn-default standard-checkout button-medium"));
        private IWebElement _emailField => SeleniumDriver.FindElement(By.Id("email"));
        private IWebElement _passwordField => SeleniumDriver.FindElement(By.Id("passwd"));
        private IWebElement _signinLink => SeleniumDriver.FindElement(By.Id("SubmitLogin"));
        private IWebElement _tshirtLink => SeleniumDriver.FindElement(By.LinkText("T-shirts"));
        private IWebElement _womanLink => SeleniumDriver.FindElement(By.ClassName("sf-with-ul"));
        private IWebElement _productContainer => SeleniumDriver.FindElement(By.ClassName("product-container"));
        private IWebElement _addToCart => SeleniumDriver.FindElement(By.CssSelector(".ajax_add_to_cart_button > span"));
        private IWebElement _checkbox => SeleniumDriver.FindElement(By.ClassName("checkbox"));
        private IWebElement _bankWire => SeleniumDriver.FindElement(By.ClassName("bankwire"));
        private IWebElement _confirmButton => SeleniumDriver.FindElement(By.CssSelector(".button btn btn-default button-medium")); 
        private IWebElement _orderStatus => SeleniumDriver.FindElement(By.ClassName("dark")); 
        private IWebElement _successMessage => SeleniumDriver.FindElement(By.ClassName("layer_cart_product")); 

        public AP_Product(IWebDriver seleniumDriver)
        {
            SeleniumDriver = seleniumDriver;
        }
        public void GoToCheckout()
        {
            SeleniumDriver.Navigate().GoToUrl(CheckoutOrderUrl);
        }
        public void ClickProceedButton()
        {
            _proceedButton.Click();
        }
        public void InputEmail(string email)
        {
            _emailField.SendKeys(email);
        }
        public void InputPassword(string password)
        {
            _passwordField.SendKeys(password);
        }
        public void ClickSigninLink()
        {
            _signinLink.Click();
        }
        public void CheckShippingBox()
        {
            _checkbox.Click();
        }

        public void ClickBankWire()
        {
            _bankWire.Click();
        }
        public void ClickConfirmOrder()
        {
            _confirmButton.Click();
        }
        public string GetOrderStatus()
        {
            return _orderStatus.Text;
        }

        public void ClickTshirtTab()
        {
            Actions action = new Actions(SeleniumDriver);
            action.MoveToElement(_womanLink).Perform();
            Thread.Sleep(3000);
            _tshirtLink.Click();
        }
        public void ClickAddToCart()
        {
            _addToCart.Click();
            Thread.Sleep(2000);
        }

        public string GetAlertSuccess()
        {
            return _successMessage.Text;
        }
    }
}