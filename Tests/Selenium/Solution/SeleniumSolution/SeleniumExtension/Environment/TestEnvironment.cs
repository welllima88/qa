using System;
using Six.Test.Selenium.Authentication;

namespace Six.Test.Selenium.Environment
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