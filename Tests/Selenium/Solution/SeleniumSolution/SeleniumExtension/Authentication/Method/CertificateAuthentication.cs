using SIX.SCS.Tests.Selenium.Extension.Authentication.WebPages;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.Tests.Selenium.Extension.Authentication.Method
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