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
        protected static readonly string CertifacteProfile = DriverRes.FirefoxProfile_Certificate;
        protected static readonly string PlainProfile = DriverRes.FirefoxProfile_Plain;
        private readonly string _auth;
        private readonly string _environment;
        private ILogin _login;
        private ILoginCheck _loginCheck;
        private ILogout _logout;
        private ILogoutCheck _logoutCheck;

        public TestDirector(string environment, string auth)
        {
            _environment = environment;
            _auth = auth;
        }

        public TestDirector()
        {
            _environment = DriverRes.DEV;
            _auth = DriverRes.UAC;
        }

        public IWebDriverAdapter WebDriver { get; private set; }

        public string BaseUrl { get; private set; }

        protected void FireFoxWebDriverAdapter(string profileName)
        {
            FirefoxProfile firefoxProfile = new FirefoxProfileManager().GetProfile(profileName);

            WebDriver = new WebDriverAdapter(new FirefoxDriver(firefoxProfile));
        }

        /// <summary>
        /// Important note:
        /// but this is delegated to virtual method, and IE-webtesting is not supported for special test case, this will cause to derive a new class from test-director, which startups IE web driver, because it is rarely used, this solution is perfect at the momemt
        /// </summary>
        /// <returns></returns>
        protected void InternetExplorerWebDriverAdapter()
        {
            //todo set relative path
            WebDriver = new WebDriverAdapter(new InternetExplorerDriver(@"D:\_tfs\ScsDev\QA\Tests\Selenium\IEDriver"));
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
        protected void StartUpTest(string baseUrl, ILogin login, ILogout logout, ILoginCheck loginCheck = null,
                                   ILogoutCheck logoutCheck = null)
        {
            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(TimeOutSeconds));
            WebDriver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(TimeOutSeconds));

            _login = login;
            _loginCheck = loginCheck;
            _logout = logout;
            _logoutCheck = logoutCheck;

            BaseUrl = WebDriver.Url = baseUrl; // essential to avoid constructor actions

            _login.Login();
            if (_loginCheck != null) _loginCheck.CheckLogInSucess();
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