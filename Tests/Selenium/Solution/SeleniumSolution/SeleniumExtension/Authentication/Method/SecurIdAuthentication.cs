using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Authentication.WebPages;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.Method
{
    public class SecurIdAuthentication : WebObject, IAuthentication, ILogoutCheck

    {
        private readonly string _mandant;
        private readonly string _password;
        private readonly string _securId;
        private readonly string _userName;
        private WesSecurIdLoginPage _wes;

        /// <summary>
        ///     The only constructor requires all values for a (sucessful) authentication with securId. These data are not saved due to security, so after test run the data will not be available anymore. But there is no further protection like encryption or forced data destruction.
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

        #region IAuthentication Members

        public void Login()
        {
            _wes = new WesSecurIdLoginPage();
            StringAssert.Matches(_wes.HeadLine.Text, TestRegExpPatterns.WesHeadLine);
            Assert.AreEqual("WES SecurID-Login", _wes.InputLabel.Text);

            _wes.Mandant = _mandant;
            _wes.User = _userName;
            _wes.Password = _password;
            _wes.ConfirmButton.Click();

            Assert.AreEqual(_wes.InputLabel.Text, "Login");
            _wes.SecurId = _securId;
            _wes.LoginButton.Click();
        }

        #endregion

        #region ILogoutCheck Members

        public void CheckLogOutSucess()
        {
            Assert.AreEqual("Logout", _wes.LogoutLabel.Text);
            Assert.AreEqual("Sie haben sich erfolgreich abgemeldet. \nBitte schliessen Sie jetzt Ihren Browser!",
                            _wes.LogoutMessage.Text);
            Assert.IsTrue(Regex.IsMatch(_wes.LogoutHeader.Text,
                                        "^SIX [\\s\\S]* - WES.*"));
        }

        #endregion
    }
}