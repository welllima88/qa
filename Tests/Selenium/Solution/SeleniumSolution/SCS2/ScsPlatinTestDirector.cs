using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login;
using SIX.SCS.QA.Selenium.Extension.Login.LoginMethod;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin
{
    public class ScsPlatinTestDirector : TestDirector
    {
        public override IWebDriverAdapter DefaultTestSetup()
        {
            ILogin login;
            string baseAdress;

            FireFoxSetupWithUac(out login, out baseAdress);

            var lobby = new LobbyView(WebDriver);
            StartUpTest(baseAdress, login, lobby);
            
            return WebDriver;
        }

        private void FireFoxSetUpWithCertifacte(out ILogin login, out string baseAdress)
        {
            FireFoxWebDriverAdapter(CertifacteProfile);
            login = new CertificateLogin(Scs2Res.mandant_qa_L, WebDriver);
            baseAdress = Scs2Res.WES_QA_L;
        }

        private void FireFoxSetupWithUac(out ILogin login, out string baseAdress)
        {
            FireFoxWebDriverAdapter(PlainProfile);
            login = new UacLogin(Scs2Res.uac_username, Scs2Res.uac_passwort, WebDriver);
            baseAdress = Scs2Res.UAC_DEV;
        }
    }
}