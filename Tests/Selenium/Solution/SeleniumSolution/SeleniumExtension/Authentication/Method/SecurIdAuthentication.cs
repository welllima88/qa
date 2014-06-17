using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.Authentication.WebPages;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.Authentication.Method
{
    public class SecurIdAuthentication : WebObject, IAuthentication

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

        public void Login()
        {
            new WesSecurIdLoginPage();
            StringAssert.Matches(WesSecurIdLoginPage.HeadLine.Text, TestRegExpPatterns.WesHeadLine);
            Assert.AreEqual("WES SecurID-Login", WesSecurIdLoginPage.InputLabel.Text);

            WesSecurIdLoginPage.Mandant = _mandant;
            WesSecurIdLoginPage.User = _userName;
            WesSecurIdLoginPage.Password = _password;
            WesSecurIdLoginPage.ConfirmButton.Click();

            Assert.AreEqual(WesSecurIdLoginPage.InputLabel.Text, "Login");
            WesSecurIdLoginPage.SecurId = _securId;
            WesSecurIdLoginPage.LoginButton.Click();
        }
    }
}