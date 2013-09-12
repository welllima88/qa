using SIX.SCS.QA.Selenium.Extension.Authentication.WebPages;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.Method
{
    public class UacAuthentication : WebObject, IAuthentication
    {
        private readonly string _password = "six_scs_auto";
        private readonly IUacLoginPage _uacLoginPage;
        private readonly string _userName = "six_scs_auto_PW";

        public UacAuthentication(IUacLoginPage loginPage, string userName, string password)
        {
            _userName = userName;
            _password = password;
            _uacLoginPage = loginPage;
        }

        #region IAuthentication Members

        /// <summary>
        ///     uses UAC authentication for the test user "six_scs_auto"
        /// </summary>
        public void Login()
        {
            _uacLoginPage.UserName = _userName;
            _uacLoginPage.UserPasswort = _password;
            _uacLoginPage.LoginButton.Click();
        }

        #endregion
    }
}