using System;
using Six.Scs.QA.Selenium.Extension.Authentication;

namespace Six.Scs.QA.Selenium.Extension.Environment
{
    public static class TestEnvironment
    {
        public static IApplication Application;
        public static IAuthentication Authentication;
        public static Uri BaseUrl;
        public static string BrowserProfileName;
        public static SeleniumConfig SeleniumConfig;
    }
}