using Six.Scs.Tests.Selenium.Extension.Authentication.WebPages;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.Authentication.Method
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