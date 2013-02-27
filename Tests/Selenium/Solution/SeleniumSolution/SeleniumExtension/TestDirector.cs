using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SIX.SCS.QA.Selenium.Extension.Login;

// http://www.seleniumwiki.com/category/visual-studio-2010/
// http://code.google.com/p/selenium/downloads/list
// http://msdn.microsoft.com/en-us/library/ff770525.aspx

namespace SIX.SCS.QA.Selenium.Extension
{
    public class TestDirector
    {
        #region Browser enum

        public enum Browser
        {
            InternetExplorer,
            Firefox
        }

        #endregion

        #region FireFoxProfile enum

        public enum FireFoxProfile
        {
            CertificateProfile,
            NoCertificateProfile
        }

        #endregion

        private const double TimeOutSeconds = 30;
        public const string CertificateProfile = "SeleWithCertificate";
        public const string NoCertificateProfile = "SeleWithOutCertificate";
        private ILogin _login;
        private ILoginCheck _loginCheck;
        private ILogout _logout;
        private ILogoutCheck _logoutCheck;

        /// <summary>
        /// Customize contructor for selecting browser and configure timeout
        /// </summary>
        /// <param name="browser"></param>
        protected TestDirector(String browser)
        {
            WebDriver = InternetExplorerWebDriverAdapter();
        }

        /// <summary>
        /// Common constructor for default test-launch with one browser instance of Firefox and 10 seconds timeout. 
        /// </summary>
        public TestDirector()
        {
            WebDriver = FireFoxWebDriverAdapter();
        }

        /// <summary>
        /// Uses an existing and already opened browser for testing (not implemented yet)
        /// </summary>
        public TestDirector(IWebDriverAdapter webDriverAdapter)
        {
            WebDriver = webDriverAdapter;
        }

        public IWebDriverAdapter WebDriver { get; private set; }

        public string BaseUrl { get; private set; }

        private static IWebDriverAdapter FireFoxWebDriverAdapter()
        {
            FirefoxProfile firefoxProfile = new FirefoxProfileManager().GetProfile(CertificateProfile);
            var firefoxBinary = new FirefoxBinary(@"D:\_tfs\ScsDev\QA\Tests\Selenium\Firefox\firefox.exe");

            return new WebDriverAdapter(new FirefoxDriver(firefoxBinary, firefoxProfile));
        }

        private static IWebDriverAdapter FireFoxWebDriverAdapter(string profileName)
        {
            FirefoxProfile firefoxProfile = new FirefoxProfileManager().GetProfile(profileName);
            var firefoxBinary = new FirefoxBinary(@"D:\_tfs\ScsDev\QA\Tests\Selenium\Firefox\firefox.exe");

            return new WebDriverAdapter(new FirefoxDriver(firefoxBinary, firefoxProfile));
        }

        private static IWebDriverAdapter InternetExplorerWebDriverAdapter()
        {
            return
                new WebDriverAdapter(
                    new InternetExplorerDriver(@"D:\_tfs\ScsDev\QA\Tests\Selenium\IEDriver"));
        }

        /// <summary>
        /// Execute the required login procedure to fulfill the basic precondition of testing.
        /// </summary>
        /// <param name="baseUrl">sets the base url for testing e.g. "https://gateint.telekurs.ch/zebrac-qa-l" </param>
        /// <param name="login">Choose the appropiate login strategy login by:
        ///   - certifacte
        ///   - SecureId
        ///   - UAF
        /// </param>
        /// <param name="loginCheck"></param>
        /// <param name="logout"></param>
        /// <param name="logoutCheck"></param>
        public void SetupTest(string baseUrl, ILogin login, ILoginCheck loginCheck, ILogout logout,
                              ILogoutCheck logoutCheck)
        {
            _login = login;
            _loginCheck = loginCheck;
            _logout = logout;
            _logoutCheck = logoutCheck;

            WebDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(TimeOutSeconds));
            WebDriver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(TimeOutSeconds));

            BaseUrl = WebDriver.Url = baseUrl; // essential to avoid constructor actions  ;)
            
            _login.Login();
            _loginCheck.CheckLogInSucess();
        }

        public virtual IWebDriverAdapter SetupTest()
        {
            throw new NotImplementedException("sub class has to implement this method");
        }


        /// <summary>
        /// logout with check and shutdown of driver 
        /// </summary>
        public void ShutDownTest()
        {
            _logout.Logout();
            _logoutCheck.CheckLogOutSucess();

            WebDriver.Quit();
        }
    }
}