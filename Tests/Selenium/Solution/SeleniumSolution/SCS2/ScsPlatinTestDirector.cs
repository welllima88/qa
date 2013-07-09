using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Authentication;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin
{
    public class ScsPlatinTestDirector : TestDirector
    {
        public override IWebDriverAdapter DefaultTestSetup()
        {
            IAuthentication authentication;
            string baseAdress;

            Qal(out authentication, out baseAdress);
            var lobby = new LobbyView(WebDriver);
            StartUpTest(baseAdress, authentication, lobby);

            return WebDriver;
        }

        private void Qal(out IAuthentication authentication, out string baseAdress)
        {
            FireFoxWebDriverAdapter(CertifacteProfile);
            authentication = new CertificateAuthentication(Scs2Res.mandant_qa_L, WebDriver);
            baseAdress = Scs2Res.WES_QA_L;
        }

        private void FireFoxSetupWithUac(out IAuthentication authentication, out string baseAdress)
        {
            FireFoxWebDriverAdapter(PlainProfile);
            authentication = new UacAuthentication(Scs2Res.uac_username, Scs2Res.uac_passwort, WebDriver);
            baseAdress = Scs2Res.UAC_DEV;
        }
    }
}