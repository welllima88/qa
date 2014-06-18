using Six.Scs.QA.Selenium.Extension.Authentication.Webpages;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.Authentication.Method
{
    public class UacAuthentication : WebObject, IAuthentication
    {
        private readonly string _password = "six_scs_auto";
        private readonly IUacLogOnPage _uacLogOnPage;
        private readonly string _userName = "six_scs_auto_PW";

        public UacAuthentication(IUacLogOnPage logOnPage, string userName, string password)
        {
            _userName = userName;
            _password = password;
            _uacLogOnPage = logOnPage;
        }

        /// <summary>
        ///     uses UAC authentication for the test user "six_scs_auto"
        /// </summary>
        public void LogOn()
        {
            _uacLogOnPage.UserName = _userName;
            _uacLogOnPage.UserPasswort = _password;
            _uacLogOnPage.LoginButton.Click();
        }
    }
}