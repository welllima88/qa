using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.WebDriver
{
    public static class TestDirector
    {
        private const string HomePathUrl = "";
        public static IWebDriver WebDriver;

        public static string BaseUrl { get; private set; }

        /// <summary>
        ///     Execute the required authentication procedure to fulfill the basic precondition of testing.
        /// </summary>
        public static void LogOn()
        {
            BaseUrl = WebObject.WebDriver.Url = TestEnvironment.BaseUrl.AbsoluteUri;
            ConfigureTimeouts();
            TestEnvironment.Authentication.LogOn();
        }

        /// <summary>
        ///     If the adress is set, the Selenum Hub specified is used. If the address is null or empty the execution is done
        ///     locally
        /// </summary>
        /// <param name="gridHub">optional address to selenium hub e.g. "http://wkbuild03:4488/wd/hub"</param>
        /// <returns></returns>
        public static void PrepareBrowser(string gridHub = "")
        {
            FirefoxProfile firefoxProfile = FirefoxProfile();

            if (string.IsNullOrEmpty(gridHub))
            {
                // var firefoxBinary = new FirefoxBinary(@"..\Firefox\firefox.exe");
                // WebDriver = new FirefoxDriver(firefoxBinary, firefoxProfile);
                WebDriver = new FirefoxDriver(firefoxProfile);

                Debug.WriteLine("using Selenium on local");
            }
            else
            {
                DesiredCapabilities capability = DesiredCapabilities(firefoxProfile);
                WebDriver = new RemoteWebDriver(new Uri(gridHub), capability, TimeSpan.FromSeconds(20));

                Debug.WriteLine("using Selenium Grid");
            }
            WebObject.WebDriver = new WebDriverAdapter(WebDriver);
        }

        private static DesiredCapabilities DesiredCapabilities(FirefoxProfile firefoxProfile)
        {
            DesiredCapabilities capability = OpenQA.Selenium.Remote.DesiredCapabilities.Firefox();
            capability.SetCapability(FirefoxDriver.ProfileCapabilityName, firefoxProfile.ToBase64String());
            // force german language, but doesn't work on grid:
            // firefoxProfile.SetPreference("intl.accept_languages", "de-ch,de,de-de");
            // capability.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            // capability.SetCapability(CapabilityType.Proxy, new Proxy().NoProxy);
            // capability.SetCapability("network.proxy.type", 0);
            // capability.SetCapability(CapabilityType.Version, "30.0.1");
            // capability.SetCapability("six.machine", "syr"); // only for using grid on local
            return capability;
        }

        private static FirefoxProfile FirefoxProfile()
        {
            var firefoxProfile = new FirefoxProfile();
            firefoxProfile.SetPreference("network.proxy.type", 0);
            return firefoxProfile;
        }

        private static void ConfigureTimeouts()
        {
            WebDriver.Manage()
                .Timeouts()
                .SetPageLoadTimeout(TimeSpan.FromSeconds(TestEnvironment.SeleniumConfig.Timeouts.SetPageLoadTimeout))
                .SetScriptTimeout(TimeSpan.FromSeconds(TestEnvironment.SeleniumConfig.Timeouts.SetScriptTimeout))
                .ImplicitlyWait(TimeSpan.FromSeconds(TestEnvironment.SeleniumConfig.Timeouts.ImplicitlyWait));
        }

        public static void ShutdownBrowser()
        {
            WebDriver.Quit();
        }

        public static void LogOff()
        {
            TestEnvironment.Application.LogOff();
        }

        public static void Navigate(string urlSuffix = HomePathUrl)
        {
            var suff = new Uri(urlSuffix, UriKind.Relative);
            var url = new Uri(TestEnvironment.BaseUrl, suff);
            WebDriver.Url = url.AbsoluteUri;
        }

        public static void Refresh()
        {
            WebDriver.Navigate().Refresh();
        }
    }
}