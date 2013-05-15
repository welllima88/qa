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

            if (true)
            {
                FireFoxWebDriverAdapter(PlainProfile);
                login = new UacLogin(Scs2Res.uac_username, Scs2Res.uac_passwort, WebDriver);
                baseAdress = Scs2Res.UAC_DEV;
            }
            else
            {
                FireFoxWebDriverAdapter(CertifacteProfile);
                login = new CertificateLogin(Scs2Res.mandant_qa_L, WebDriver);
                baseAdress = Scs2Res.WES_QA_L;
            }

            var lobby = new Lobby(WebDriver);

            StartUpTest(baseAdress, login, lobby);
            return WebDriver;
        }
    }
}