using Six.Scs.QA.Selenium.Extension.Authentication.Webpages;

namespace Six.Scs.QA.Selenium.Extension.Authentication.Method
{
    public class CertificateAuthentication : IAuthentication
    {
        private readonly string _mandant;

        public CertificateAuthentication(string mandant)
        {
            _mandant = mandant;
        }

        public void LogOn()
        {
            WesCertificateLogOnPage.Mandant(_mandant).Click();
            WesCertificateLogOnPage.LoginButton.Click();
        }
    }
}