using System;
using SIX.SCS.QA.Selenium.Extension.Authentication;

namespace SIX.SCS.QA.Selenium.Extension.Settings
{
    public class TestEnvironment
    {
        public static IApplication Application;
        public static IAuthentication Authentication;
        public static Uri BaseUrl;
        public static string BrowserProfileName;
        public static SeleniumConfig SeleniumConfig;
    }
}