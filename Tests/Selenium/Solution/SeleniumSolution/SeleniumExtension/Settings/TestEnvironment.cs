using SIX.SCS.QA.Selenium.Extension.Authentication;

namespace SIX.SCS.QA.Selenium.Extension.Settings
{
    public class TestEnvironment
    {
        public string BaseUrls;
        public string BrowserProfileName;
        public SeleniumConfig SeleniumConfig;
        public IAuthentication Authentication;
        public IApplication Application;
    }
}