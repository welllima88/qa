using SIX.SCS.QA.Selenium.Extension.Authentication.WebPages;

namespace SIX.SCS.QA.Selenium.Extension.Authentication.Method
{
    public class CertificateAuthentication : WebObject, IAuthentication
    {
        private readonly string _mandant;
        private readonly WesCertificateLoginPage _wes;

        public CertificateAuthentication(string mandant)
        {
            _mandant = mandant;
            _wes = new WesCertificateLoginPage();
        }

        public void Login()
        {
            // choose tenant and authentication/submit:
            _wes.Mandant(_mandant).Click();
            _wes.LoginButton.Click();
        }
    }
}