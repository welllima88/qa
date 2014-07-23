using System;
using Six.Scs.QA.Selenium.Extension.Authentication;

namespace Six.Scs.QA.Selenium.Extension.Environment
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