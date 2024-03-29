using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Six.Test.Selenium.Environment;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Test.Selenium.WebDriver
{
    public static class TestDirector
    {
        private const string HomePathUrl = "";
        public static IWebDriver WebDriver { get; private set; }
        public static TestEnvironment TestEnvironment { get; set; }

        /// <summary>
        ///     Execute the required authentication procedure to fulfill the basic precondition of testing.
        /// </summary>
        public static void Start()
        {
            Console.Out.WriteLine("starting browser");
            WebDriver.Url = TestEnvironment.BaseUrl.AbsoluteUri;
            ConfigureTimeouts(TestEnvironment.SeleniumConfig.Timeouts);
            TestEnvironment.Authentication.LogOn();
            Console.Out.WriteLine("logged on");
        }

        /// <summary>
        ///     If the adress is set, the Selenum Hub specified is used. If the address is null or empty the execution is done
        ///     locally
        /// </summary>
        /// <param name="gridHub">optional address to selenium hub e.g. "http://build:4488/wd/hub"</param>
        /// <returns></returns>
        public static void PrepareBrowser(string gridHub = "")
        {
            Console.Out.WriteLine("preparing browser");
            // force german language, but doesn't work on grid:
            var firefoxProfile = NoProxy();
            firefoxProfile.SetPreference("intl.accept_languages", "de-ch,de");

            var run = "??";
            if (string.IsNullOrEmpty(gridHub))
            {
                // var firefoxBinary = new FirefoxBinary(@"..\Firefox\firefox.exe");
                // WebDriver = new FirefoxDriver(firefoxBinary, firefoxProfile);
                WebDriver = new WebDriver(new FirefoxDriver(firefoxProfile));

                run = "LOCAL";
            }
            else
            {
                var capability = DesiredCapabilities(firefoxProfile);
                WebDriver =
                    new WebDriver(new RemoteWebDriver(new Uri(gridHub), capability));

                run = "GRID";
            }
            WebObject.WebDriver = new WebDriver(WebDriver);
            Console.Out.WriteLine("using Selenium {0} : {1}", run, gridHub);
        }

        private static DesiredCapabilities DesiredCapabilities(FirefoxProfile firefoxProfile)
        {
            var capabilities = OpenQA.Selenium.Remote.DesiredCapabilities.Firefox();
            capabilities.SetCapability(FirefoxDriver.ProfileCapabilityName, firefoxProfile.ToBase64String());
            // capability.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            // capability.SetCapability(CapabilityType.Proxy, new Proxy().NoProxy);
            // capability.SetCapability("network.proxy.type", 0);
            // capability.SetCapability(CapabilityType.Version, "30.0.1");
            capabilities.SetCapability("six.machine", "wksiegmund01"); // only for using grid on local
            return capabilities;
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
            Console.Out.WriteLine("logged off");
            WebDriver.Quit();
            Console.Out.WriteLine("closed WebDriver");
        }
    }
}