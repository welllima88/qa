using SIX.SCS.QA.Selenium.Extension.Authentication;

namespace SIX.SCS.QA.Selenium.Extension.Settings
{
    public class TestEnvironment : ITestEnvironment
    {
        public IApplication Application;
        public IAuthentication Authentication;
        public string BaseUrl;
        public string BrowserProfileName;
        public SeleniumConfig SeleniumConfig;
    }
}