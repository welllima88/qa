using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SIX.SCS.QA.Selenium.Extension.Settings;

namespace SIX.SCS.QA.Selenium.Extension
{
    public class TestDirector
    {
        public IWebDriverAdapter WebDriver;

        public string BaseUrl { get; private set; }

        private void CreateFirefoxWebDriverInstance(string profileName)
        {
            FirefoxProfile firefoxProfile = new FirefoxProfileManager().GetProfile(profileName);
            WebDriver = WebObject.WebDriver = new WebDriverAdapter(new FirefoxDriver(firefoxProfile));
        }

        /// <summary>
        ///     Important note:
        ///     but this is delegated to virtual method, and IE-webtesting is not supported for special test case, this will cause to derive a new class from test-director, which startups IE web driver, because it is rarely used, this solution is perfect at the momemt
        /// </summary>
        /// <param name="driverPath"></param>
        /// <returns></returns>
        protected void InternetExplorerWebDriverAdapter(string driverPath)
        {
            //@"D:\_tfs\ScsDev\QA\Tests\Selenium\IEDriver"
            WebObject.WebDriver = new WebDriverAdapter(new InternetExplorerDriver(driverPath));
        }

        /// <summary>
        ///     Execute the required authentication procedure to fulfill the basic precondition of testing.
        /// </summary>
        public void Login()
        {
            BaseUrl = WebObject.WebDriver.Url = TestEnvironment.BaseUrl.AbsoluteUri;
            // essential to avoid constructor actions
            TestEnvironment.Authentication.Login();
        }

        public IWebDriverAdapter PrepareBrowser()
        {
            CreateFirefoxWebDriverInstance(TestEnvironment.BrowserProfileName);
            ConfigureTimeouts();
            return WebDriver;
        }

        private void ConfigureTimeouts()
        {
            WebDriver.Manage()
                     .Timeouts()
                     .SetPageLoadTimeout(TimeSpan.FromSeconds(TestEnvironment.SeleniumConfig.Timeouts.SetPageLoadTimeout));
            WebDriver.Manage()
                     .Timeouts()
                     .SetScriptTimeout(TimeSpan.FromSeconds(TestEnvironment.SeleniumConfig.Timeouts.SetScriptTimeout));
            WebDriver.Manage()
                     .Timeouts()
                     .ImplicitlyWait(TimeSpan.FromSeconds(TestEnvironment.SeleniumConfig.Timeouts.ImplicitlyWait));
        }

        public void ShutDownBrowser()
        {
            WebObject.WebDriver.Quit();
        }

        public void Logout()
        {
            TestEnvironment.Application.Logout();
        }
    }
}