using System;
using Six.QA.Selenium.Extension.Authentication;

namespace Six.QA.Selenium.Extension.Environment
{
    public abstract class TestEnvironment
    {
        public IApplication Application;
        public IAuthentication Authentication;
        public Uri BaseUrl;
        public string BrowserProfileName;
        public SeleniumConfig SeleniumConfig;
    }
}