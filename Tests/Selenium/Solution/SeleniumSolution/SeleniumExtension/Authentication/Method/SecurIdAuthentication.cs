using System;
using Six.Scs.QA.Selenium.Extension.Authentication.Webpages;

namespace Six.Scs.QA.Selenium.Extension.Authentication.Method
{
    public class SecurIdAuthentication : IAuthentication

    {
        private readonly string _mandant;
        private readonly string _password;
        private readonly string _securId;
        private readonly string _userName;

        /// <summary>
        ///     The only constructor requires all values for a (sucessful) authentication with securId. These data are not saved
        ///     due to security, so after test run the data will not be available anymore. But there is no further protection like
        ///     encryption or forced data destruction.
        /// </summary>
        /// <param name="userName">username e.g. "tksyr"</param>
        /// <param name="password">password for userName</param>
        /// <param name="mandant">e.g. "TKCPOS"</param>
        /// <param name="securId">4 digits (fix password) + 6 digits securId-token</param>
        public SecurIdAuthentication(String userName, String password, String mandant, String securId)
        {
            _securId = securId;
            _userName = userName;
            _password = password;
            _mandant = mandant;
        }

        public void LogOn()
        {
            WesSecurIdLogOnPage.Mandant = _mandant;
            WesSecurIdLogOnPage.User = _userName;
            WesSecurIdLogOnPage.Password = _password;
            WesSecurIdLogOnPage.ConfirmButton.Click();

            WesSecurIdLogOnPage.SecurId = _securId;
            WesSecurIdLogOnPage.LoginButton.Click();
        }
    }
}