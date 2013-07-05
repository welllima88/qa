using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Login.LoginPages;

namespace SIX.SCS.QA.Selenium.Extension.Login.LoginMethod
{
    public class CertificateAuthentication : WebObject, IAuthentication, ILogoutCheck
    {
        private readonly string _mandant;
        private readonly WesCertificateLoginPage _wes;

        public CertificateAuthentication(string mandant, IWebDriverAdapter driver) : base(driver)
        {
            _mandant = mandant;
            _wes = new WesCertificateLoginPage(driver);
        }

        #region IAuthentication Members

        public void Login()
        {
            // choose tenant and authentication/submit:
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