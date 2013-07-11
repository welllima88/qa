using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SIX.SCS.QA.Selenium.Extension.Authentication;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;

// http://www.seleniumwiki.com/category/visual-studio-2010/
// http://code.google.com/p/selenium/downloads/list
// http://msdn.microsoft.com/en-us/library/ff770525.aspx

namespace SIX.SCS.QA.Selenium.Extension
{
    public abstract class TestDirector
    {
        protected static readonly string CertifacteProfile = DriverRes.FirefoxProfile_Certificate;
        protected static readonly string PlainProfile = DriverRes.FirefoxProfile_Plain;
        private IApplication _application;
        private IAuthentication _authentication;

        public IWebDriverAdapter WebDriver { get; private set; }

        public string BaseUrl { get; private set; }

        protected void FireFoxWebDriverAdapter(string profileName)
        {
            FirefoxProfile firefoxProfile = new FirefoxProfileManager().GetProfile(profileName);

            WebDriver = new WebDriverAdapter(new FirefoxDriver(firefoxProfile));

            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            WebDriver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(10));
            // not supported anymore:
            // WebDriver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(30));
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
            WebDriver = new WebDriverAdapter(new InternetExplorerDriver(driverPath));
        }

        /// <summary>
        ///     Execute the required authentication procedure to fulfill the basic precondition of testing.
        /// </summary>
        /// <param name="baseUrl">sets the base url for testing e.g. "https://gateint.telekurs.ch/scsc-qa-l" </param>
        /// <param name="authentication">
        ///     Choose the appropiate authentication strategy authentication by:
        ///     - certifacte
        ///     - SecureId
        ///     - UAF
        /// </param>
        /// <param name="application"></param>
        protected void StartUpTest(string baseUrl, IAuthentication authentication, IApplication application)
        {
            _authentication = authentication;
            _application = application;

            BaseUrl = WebDriver.Url = baseUrl; // essential to avoid constructor actions

            _authentication.Login();
        }

        public virtual IWebDriverAdapter DefaultTestSetup(TestEnvironment environment)
        {
            throw new NotImplementedException("sub class has to implement this method");
        }

        public virtual IWebDriverAdapter DefaultTestSetup()
        {
            throw new NotImplementedException("sub class has to implement this method");
        }

        /// <summary>
        ///     application with check and shutdown of driver
        /// </summary>
        public void ShutDownTest()
        {
            _application.Logout();
            WebDriver.Quit();
        }
    }
}