using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SIX.SCS.QA.Selenium.Extension.Login;
using SIX.SCS.QA.Selenium.Extension.Properties;

// http://www.seleniumwiki.com/category/visual-studio-2010/
// http://code.google.com/p/selenium/downloads/list
// http://msdn.microsoft.com/en-us/library/ff770525.aspx

namespace SIX.SCS.QA.Selenium.Extension
{
    public class TestDirector
    {
        private const double TimeOutSeconds = 30;
        private ILogin _login;
        private ILoginCheck _loginCheck;
        private ILogout _logout;
        private ILogoutCheck _logoutCheck;
        // private static readonly FirefoxBinary FirefoxBinary = new FirefoxBinary(@"D:\_tfs\ScsDev\QA\Tests\Selenium\Firefox\firefox.exe");

        /// <summary>
        /// Common constructor for default test-launch with one browser instance of Firefox and 10 seconds timeout. 
        /// </summary>
        public TestDirector()
        {
            WebDriver = DefaultBrowserSetup();
        }

        /// <summary>
        /// Uses an existing and already opened browser for testing (not implemented yet)
        /// </summary>
        public TestDirector(IWebDriverAdapter webDriverAdapter)
        {
            WebDriver = webDriverAdapter;
        }

        public IWebDriverAdapter WebDriver { get; protected set; }

        public string BaseUrl { get; private set; }

        private static IWebDriverAdapter FireFoxWebDriverAdapter(string profileName)
        {
            FirefoxProfile firefoxProfile = new FirefoxProfileManager().GetProfile(profileName);

            return new WebDriverAdapter(new FirefoxDriver(firefoxProfile));
        }

        protected static IWebDriverAdapter FireFoxWebDriverAdapter()
        {
            FirefoxProfile firefoxProfile =
                new FirefoxProfileManager().GetProfile(DriverRes.FirefoxProfile_Certificate);

            return new WebDriverAdapter(new FirefoxDriver(firefoxProfile));
        }
        /// <summary>
        /// Important note:
        /// but this is delegated to virtual method, and IE-webtesting is not supported for special test case, this will cause to derive a new class from test-director, which startups IE web driver, because it is rarely used, this solution is perfect at the momemt
        /// </summary>
        /// <returns></returns>
        protected static IWebDriverAdapter InternetExplorerWebDriverAdapter()
        {
            //todo set relative path
            return
                new WebDriverAdapter(
                    new InternetExplorerDriver(@"D:\_tfs\ScsDev\QA\Tests\Selenium\IEDriver"));
        }

        /// <summary>
        /// Execute the required login procedure to fulfill the basic precondition of testing.
        /// </summary>
        /// <param name="baseUrl">sets the base url for testing e.g. "https://gateint.telekurs.ch/scsc-qa-l" </param>
        /// <param name="login">Choose the appropiate login strategy login by:
        ///   - certifacte
        ///   - SecureId
        ///   - UAF
        /// </param>
        /// <param name="logout"></param>
        /// <param name="loginCheck"></param>
        /// <param name="logoutCheck"></param>
        protected void TestSetup(string baseUrl, ILogin login, ILogout logout, ILoginCheck loginCheck = null,
                                 ILogoutCheck logoutCheck = null)
        {
            _login = login;
            _loginCheck = loginCheck;
            _logout = logout;
            _logoutCheck = logoutCheck;

            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(TimeOutSeconds));
            WebDriver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(TimeOutSeconds));

            BaseUrl = WebDriver.Url = baseUrl; // essential to avoid constructor actions  ;)

            _login.Login();
            if (_loginCheck != null) _loginCheck.CheckLogInSucess();
        }

        protected virtual IWebDriverAdapter DefaultBrowserSetup()
        {
            throw new NotImplementedException("sub class has to implement this method");
        }

        public virtual IWebDriverAdapter DefaultTestSetup()
        {
            throw new NotImplementedException("sub class has to implement this method");
        }


        /// <summary>
        /// logout with check and shutdown of driver 
        /// </summary>
        public void ShutDownTest()
        {
            _logout.Logout();
            if (_logoutCheck != null) _logoutCheck.CheckLogOutSucess();
            WebDriver.Quit();
        }
    }
}