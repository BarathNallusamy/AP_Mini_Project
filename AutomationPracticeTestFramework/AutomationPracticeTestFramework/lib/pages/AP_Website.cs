using OpenQA.Selenium;

namespace AutomationPracticeTestFramework
{
    public class AP_Website
    {
        public IWebDriver SeleniumDriver { get; internal set; }
        public AP_HomePage AP_HomePage { get; internal set; }
        public AP_SigningPage AP_SigninPage { get; internal set; }
        public AP_ForgotPassword AP_ForgotPassword { get; internal set; }
        public AP_TshirtPage AP_TshirtPage { get; internal set; }

        public AP_Website(string driver, int pageLoadSecs = 20, int waitSecs = 20)
        {
            //construct and configure the driver
            SeleniumDriver = new SeleniumDriverConfig(driver, pageLoadSecs, waitSecs).Driver;
            // construct the page objects with a reference to the driver
            AP_HomePage = new AP_HomePage(SeleniumDriver);
            AP_SigninPage = new AP_SigningPage(SeleniumDriver);
            AP_ForgotPassword = new AP_ForgotPassword(SeleniumDriver);
            AP_TshirtPage = new AP_TshirtPage(SeleniumDriver);
        }
        public void DeleteCookies()
        {
            SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        }
        public string GetPageTitle()
        {
            return SeleniumDriver.Title;
        }
    }
}
