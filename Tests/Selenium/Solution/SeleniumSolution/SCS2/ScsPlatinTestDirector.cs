using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Login;
using SIX.SCS.QA.Selenium.Extension.Login.LoginMethod;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin
{
    public class ScsPlatinTestDirector : TestDirector
    {
        private readonly string auth;
        private readonly string browser;
        private readonly string environment;

        public ScsPlatinTestDirector(string browser = "FF", string environment = "QAL", string auth = "UAC")
        {
            this.environment = environment;
            this.browser = browser;
            this.auth = auth;
        }

        protected override IWebDriverAdapter DefaultBrowserSetup()
        {
            if (browser == "FF")
            {
                return FireFoxWebDriverAdapter();
            }
            return InternetExplorerWebDriverAdapter();
        }

        public override IWebDriverAdapter DefaultTestSetup()
        {
            ILogin login = null;
            if (auth == "UAC")
            {
                login = new UacLogin(Scs2Res.uac_username, Scs2Res.uac_passwort, WebDriver);
            }
            else
            {
                login = new CertificateLogin(Scs2Res.mandant_qa_L, WebDriver);
            }

            var lobby = new Lobby(WebDriver);

            // TestSetup(Scs2Res.WES_QA_L, certificateLogin, lobby);
            TestSetup(Scs2Res.UAC_DEV, login, lobby);
            return WebDriver;
        }
    }
}