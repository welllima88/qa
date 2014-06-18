using Six.Scs.QA.Selenium.Extension.Authentication.WebPages;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.Authentication.Method
{
    public class CertificateAuthentication : WebObject, IAuthentication
    {
        private readonly string _mandant;

        public CertificateAuthentication(string mandant)
        {
            _mandant = mandant;            
        }

        public void Login()
        {
            // choose tenant and authentication/submit:
            WesCertificateLoginPage.Mandant(_mandant).Click();
            WesCertificateLoginPage.LoginButton.Click();
        }
    }
}