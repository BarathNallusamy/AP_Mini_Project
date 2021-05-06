using System.Configuration;

namespace AutomationPracticeTestFramework
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly string SigninPageUrl = ConfigurationManager.AppSettings["signinpage_url"];
        public static readonly string CreateAccUrl = ConfigurationManager.AppSettings["createacc_url"];
        public static readonly string ForgotPassUrl = ConfigurationManager.AppSettings["forgotpass_url"];
    }
}
