using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login;
using SIX.SCS.QA.Selenium.Extension.Login.LoginMethod;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics
{
    public class ScsClassicTestDirector : TestDirector
    {
        public override IWebDriverAdapter DefaultTestSetup()
        {
            ILogin login;
            string baseAdress;

            FireFoxSetUpWithCertifacte(out login, out baseAdress);

            var lobby = new Scs(WebDriver);
            StartUpTest(baseAdress, login, lobby);

            return WebDriver;
        }

        private void FireFoxSetUpWithCertifacte(out ILogin login, out string baseAdress)
        {
            FireFoxWebDriverAdapter(CertifacteProfile);
            login = new CertificateLogin(ScsRes.mandant_qa_K, WebDriver);
            baseAdress = ScsRes.WES_QA_K;
        }

        private void FireFoxSetUpWithSecurId(out ILogin login, out string baseAdress)
        {
            FireFoxWebDriverAdapter(PlainProfile);
            login = new SecurIdLogin("tksyr", "",ScsRes.mandant_prod,"",WebDriver);
            baseAdress = ScsRes.WES_Production;
        }
    }
}