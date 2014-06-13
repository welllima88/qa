using System;
using SIX.SCS.Tests.Selenium.Extension.Authentication;

namespace SIX.SCS.Tests.Selenium.Extension.Settings
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