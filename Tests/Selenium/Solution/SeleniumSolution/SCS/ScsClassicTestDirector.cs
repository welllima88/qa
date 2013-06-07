using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login;
using SIX.SCS.QA.Selenium.Extension.Login.LoginMethod;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;

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
            login = new CertificateLogin(Scs2Res.mandant_qa_L, WebDriver);
            baseAdress = "https://gateint.telekurs.ch/scsc-qa-l/";
        }

        private void FireFoxSetupWithUac(out ILogin login, out string baseAdress)
        {
            FireFoxWebDriverAdapter(PlainProfile);
            login = new UacLogin(Scs2Res.uac_username, Scs2Res.uac_passwort, WebDriver);
            baseAdress = Scs2Res.UAC_DEV;
        }
    }
}