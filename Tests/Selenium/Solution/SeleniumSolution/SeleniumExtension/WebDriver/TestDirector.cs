using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.WebDriver
{
    public static class TestDirector
    {
        private const string HomePathUrl = "";
        public static IWebDriverAdapter WebDriver { get; private set; }
        public static TestEnvironment TestEnvironment { get; set; }

        /// <summary>
        ///     Execute the required authentication procedure to fulfill the basic precondition of testing.
        /// </summary>
        public static void Start()
        {
            WebDriver.Url = TestEnvironment.BaseUrl.AbsoluteUri;
            ConfigureTimeouts(TestEnvironment.SeleniumConfig.Timeouts);
            TestEnvironment.Authentication.LogOn();
        }

        /// <summary>
        ///     If the adress is set, the Selenum Hub specified is used. If the address is null or empty the execution is done
        ///     locally
        /// </summary>
        /// <param name="gridHub">optional address to selenium hub e.g. "http://build:4488/wd/hub"</param>
        /// <returns></returns>
        public static void PrepareBrowser(string gridHub = "")
        {
            FirefoxProfile firefoxProfile = NoProxy();
            firefoxProfile.SetPreference("intl.accept_languages", "de-ch,de");

            string run = "??";
            if (string.IsNullOrEmpty(gridHub))
            {
                // var firefoxBinary = new FirefoxBinary(@"..\Firefox\firefox.exe");
                // WebDriver = new FirefoxDriver(firefoxBinary, firefoxProfile);
                WebDriver = new WebDriverAdapter(new FirefoxDriver(firefoxProfile));

                run = "LOCAL";
            }
            else
            {
                DesiredCapabilities capability = DesiredCapabilities(firefoxProfile);
                WebDriver =
                    new WebDriverAdapter(new RemoteWebDriver(new Uri(gridHub), capability));

                run = "GRID";
            }
            WebObject.WebDriver = new WebDriverAdapter(WebDriver);
            Console.Out.WriteLine("using Selenium {0} : {1}", run, gridHub);
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

        private static FirefoxProfile NoProxy()
        {
            var firefoxProfile = new FirefoxProfile();
            firefoxProfile.SetPreference("network.proxy.type", 0);
            return firefoxProfile;
        }

        private static void ConfigureTimeouts(Timeouts timeouts)
        {
            WebDriver.Manage()
                .Timeouts()
                .SetPageLoadTimeout(TimeSpan.FromSeconds(timeouts.SetPageLoadTimeout))
                .SetScriptTimeout(TimeSpan.FromSeconds(timeouts.SetScriptTimeout))
                .ImplicitlyWait(TimeSpan.FromSeconds(timeouts.ImplicitlyWait));
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

        public static void Stop()
        {
            TestEnvironment.Application.LogOff();
            WebDriver.Quit();
        }
    }
}