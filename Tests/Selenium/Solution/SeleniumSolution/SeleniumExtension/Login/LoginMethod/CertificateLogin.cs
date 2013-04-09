using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Login.LoginPages;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Extension.Login.LoginMethod
{
    public class CertificateLogin : WebObject, ILogin, ILogoutCheck
    {
        private readonly string _mandant;
        private readonly WesCertificateLoginPage _wes;

        public CertificateLogin(string mandant, IWebDriverAdapter driver) : base(driver)
        {
            _mandant = mandant;
            _wes = new WesCertificateLoginPage(driver);
        }

        #region ILogin Members

        public void Login()
        {
            // choose tenant and login/submit:
            _wes.Mandant(_mandant).Click();
            _wes.LoginButton.Click();
        }

        #endregion

        #region ILogoutCheck Members

        public void CheckLogOutSucess()
        {
            StringAssert.Matches(_wes.InputLabel.Text, TestRegExpPatterns.WesInputLabelLogout);
            StringAssert.Matches(_wes.MessageInfo.Text, TestRegExpPatterns.WesLogoutInfo);
            StringAssert.Matches(_wes.HeadLine.Text, TestRegExpPatterns.WesHeadLine);
        }

        #endregion
    }
}