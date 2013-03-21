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
            var certificateLogin = new CertificateLogin(Resources.mandant_qa_L, WebDriver);
            var uacLogin = new UacLogin(Resources.uac_username, Resources.uac_passwort, WebDriver);
            var lobby = new Lobby(WebDriver);

            TestSetup(Resources.WES_QA_L, certificateLogin, lobby);
            TestSetup(Resources.UAC_DEV, uacLogin, lobby);
            return WebDriver;
        }
    }
}