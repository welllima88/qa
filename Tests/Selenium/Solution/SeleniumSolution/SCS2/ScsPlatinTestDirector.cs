using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login.LoginMethod;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin
{
    public class ScsPlatinTestDirector : TestDirector
    {
        public ScsPlatinTestDirector(string p) : base(p)
        {
        }

        public ScsPlatinTestDirector()
        {
        }

        public override IWebDriverAdapter DefaultTestSetup()
        {
            var certificateLogin = new CertificateLogin(Scs2Res.mandant_qa_L, WebDriver);
            var uacLogin = new UacLogin(Scs2Res.uac_username, Scs2Res.uac_passwort, WebDriver);
            var lobby = new Lobby(WebDriver);

            TestSetup(Scs2Res.WES_QA_L, certificateLogin, lobby);
            TestSetup(Scs2Res.UAC_DEV, uacLogin, lobby);
            return WebDriver;
        }
    }
}