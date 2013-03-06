using System;
using SIX.SCS.QA.Selenium.Extension.Login.LoginPages;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Extension.Login.LoginMethod
{
    public class UacLogin : WebObject, ILogin, ILogoutCheck
    {
        private readonly string _password = "six_scs_auto";
        private readonly UacLoginPage _uacLoginPage;
        private readonly string _userName = "six_scs_auto";

        public UacLogin(string userName, string password, IWebDriverAdapter driver) : base(driver)
        {
            _userName = userName;
            _password = password;
            _uacLoginPage = new UacLoginPage(driver);
        }

        #region ILogin Members

        /// <summary>
        /// uses UAC login for the test user "six_scs_auto"
        /// </summary>
        public void Login()
        {
            _uacLoginPage.UserName = _userName;
            _uacLoginPage.UserPasswort = _password;
            _uacLoginPage.LoginButton.Click();
        }

        #endregion

        #region ILogoutCheck Members

        public void CheckLogOutSucess()
        {
            throw new NotImplementedException("Needs to be implemented");
        }

        #endregion
    }
}