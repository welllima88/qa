using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Settings
{
    public class QaL : TestEnvironment
    {
        public QaL(IWebDriverAdapter webDriver)
        {
            BaseUrl = Scs2Res.WES_QA_L;
            BrowserProfileName = DriverRes.FirefoxProfile_Certificate;
            Application = new LobbyView(webDriver);
            Authentication = new CertificateAuthentication(Scs2Res.mandant_qa_L, webDriver);
            SeleniumConfig = new SeleniumConfig {Timeouts = {ImplicitlyWait = 5, SetScriptTimeout = 10}};
        }
    }
}