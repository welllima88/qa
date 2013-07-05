using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Authentication;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics
{
    public class ScsClassicTestDirector : TestDirector
    {
        public override IWebDriverAdapter DefaultTestSetup()
        {
            IAuthentication authentication;
            string baseAdress;

            FireFoxSetUpWithCertifacte(out authentication, out baseAdress);

            var lobby = new Scs(WebDriver);
            StartUpTest(baseAdress, authentication, lobby);

            return WebDriver;
        }

        private void FireFoxSetUpWithCertifacte(out IAuthentication authentication, out string baseAdress)
        {
            FireFoxWebDriverAdapter(CertifacteProfile);
            authentication = new CertificateAuthentication(ScsRes.mandant_qa_K, WebDriver);
            baseAdress = ScsRes.WES_QA_K;
        }

        private void FireFoxSetUpWithSecurId(out IAuthentication authentication, out string baseAdress)
        {
            FireFoxWebDriverAdapter(PlainProfile);
            authentication = new SecurIdAuthentication("tksyr", "", ScsRes.mandant_prod, "", WebDriver);
            baseAdress = ScsRes.WES_Production;
        }
    }
}