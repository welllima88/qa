using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Six.Scs.Tests.Selenium.Extension.Settings;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.WebDriver
{
    public static class TestDirector
    {
        private const string HomePathUrl = "";
        public static IWebDriver WebDriver;

        public static string BaseUrl { get; private set; }

        /// <summary>
        ///     Execute the required authentication procedure to fulfill the basic precondition of testing.
        /// </summary>
        public static void Login()
        {
            BaseUrl = WebObject.WebDriver.Url = TestEnvironment.BaseUrl.AbsoluteUri;
            ConfigureTimeouts();
            TestEnvironment.Authentication.Login();
        }

        /// <summary>
        ///     If the adress is set, the Selenum Hub specified is used. If the address is null or empty the execution is done
        ///     locally
        /// </summary>
        /// <param name="gridHub">optional address to selenium hub e.g. "http://wkbuild03:4488/wd/hub"</param>
        /// <returns></returns>
        public static void PrepareBrowser(string gridHub = "")
        {
            var firefoxProfile = new FirefoxProfile(@"~\FireFox\Profiles\WithCertificate");
            var firefoxBinary = new FirefoxBinary(@"~\Firefox\firefox.exe");

            if (string.IsNullOrEmpty(gridHub))
            {
                WebDriver = new FirefoxDriver(firefoxBinary, firefoxProfile);
                WebObject.WebDriver = new WebDriverAdapter(WebDriver);
                Debug.WriteLine("using Selenium on local");
            }
            else
            {
                DesiredCapabilities capability = DesiredCapabilities.Firefox();
                // capability.SetCapability(FirefoxDriver.ProfileCapabilityName, firefoxProfile);
                // force german language, but doesn't work on grid:
                // firefoxProfile.SetPreference("intl.accept_languages", "de-ch,de,de-de");
                // capability.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
                // capability.SetCapability(CapabilityType.Proxy, new Proxy().NoProxy);
                // capability.SetCapability("network.proxy.type", 0);
                // capability.SetCapability(CapabilityType.Version, "23.0.1");
                // capability.SetCapability("six.machine", "syr"); // only for using grid on local

                WebDriver = new RemoteWebDriver(new Uri(gridHub), capability, TimeSpan.FromSeconds(20));
                WebObject.WebDriver = new WebDriverAdapter(WebDriver);

                Debug.WriteLine("using Selenium Grid");
            }
        }

        private static void ConfigureTimeouts()
        {
            WebDriver.Manage()
                .Timeouts()
                .SetPageLoadTimeout(TimeSpan.FromSeconds(TestEnvironment.SeleniumConfig.Timeouts.SetPageLoadTimeout))
                .SetScriptTimeout(TimeSpan.FromSeconds(TestEnvironment.SeleniumConfig.Timeouts.SetScriptTimeout))
                .ImplicitlyWait(TimeSpan.FromSeconds(TestEnvironment.SeleniumConfig.Timeouts.ImplicitlyWait));
        }

        public static void ShutDownBrowser()
        {
            WebDriver.Quit();
        }

        public static void Logout()
        {
            TestEnvironment.Application.Logout();
        }

        public static void Navigate(string urlSuffix = HomePathUrl)
        {
            var suff = new Uri(urlSuffix, UriKind.Relative);
            var url = new Uri(TestEnvironment.BaseUrl, suff);
            WebDriver.Url = url.AbsoluteUri;
        }
    }
}