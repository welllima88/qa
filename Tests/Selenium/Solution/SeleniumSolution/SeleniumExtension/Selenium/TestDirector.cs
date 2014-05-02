using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;
using SIX.SCS.QA.Selenium.Extension.Settings;

namespace SIX.SCS.QA.Selenium.Extension.Selenium
{
    public static class TestDirector
    {
        private const string HomePathUrl = "";
        public static IWebDriver WebDriver;

        public static string BaseUrl { get; private set; }

        /// <summary>
        ///     Important note:
        ///     but this is delegated to virtual method, and IE-webtesting is not supported for special test case, this will cause
        ///     to derive a new class from test-director, which startups IE web driver, because it is rarely used, this solution is
        ///     perfect at the momemt
        /// </summary>
        /// <param name="driverPath"></param>
        /// <returns></returns>
        private static void InternetExplorerWebDriverAdapter(string driverPath)
        {
            //@"D:\_tfs\ScsDev\QA\Tests\Selenium\IEDriver"
            WebObject.WebDriver = new WebDriverAdapter(new InternetExplorerDriver(driverPath));
        }

        /// <summary>
        ///     Execute the required authentication procedure to fulfill the basic precondition of testing.
        /// </summary>
        public static void Login()
        {
            BaseUrl = WebObject.WebDriver.Url = TestEnvironment.BaseUrl.AbsoluteUri;
            TestEnvironment.Authentication.Login();
            ConfigureTimeouts();
        }

        /// <summary>
        ///     If the adress is set, the Selenum Hub specified is used. If the address is null or empty the execution is done
        ///     locally
        /// </summary>
        /// <param name="gridHub">optional address to selenium hub</param>
        /// <returns></returns>
        public static void PrepareBrowser(string gridHub = "")
        {
            FirefoxProfile firefoxProfile = new FirefoxProfileManager().GetProfile(TestEnvironment.BrowserProfileName);
            // force german language, but doesn't work on grid:
            // firefoxProfile.SetPreference("intl.accept_languages", "de-ch,de,de-de");

            if (string.IsNullOrEmpty(gridHub))
            {
                WebDriver = new FirefoxDriver(firefoxProfile);
                WebObject.WebDriver = new WebDriverAdapter(WebDriver);
                Debug.Write("using Selenium on local");
            }
            else
            {
                DesiredCapabilities capability = DesiredCapabilities.Firefox();
                capability.SetCapability(FirefoxDriver.ProfileCapabilityName, firefoxProfile);
                capability.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
                capability.SetCapability(CapabilityType.Version, "23.0.1");
                // capability.SetCapability("six.machine", "syr"); // only for local purpose

                WebDriver = new RemoteWebDriver(new Uri(gridHub), capability);
                WebObject.WebDriver = new WebDriverAdapter(WebDriver);

                Debug.Write("using Selenium Grid");
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