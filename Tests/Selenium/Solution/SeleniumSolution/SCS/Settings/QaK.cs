using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.Settings
{
    public class QaK: TestEnvironment
    {
        public QaK(IWebDriverAdapter webDriver)
        {
            BaseUrl = ScsRes.WES_QA_K;
            BrowserProfileName = DriverRes.FirefoxProfile_Certificate;
            Application = new LobbyView(webDriver);
            Authentication = new CertificateAuthentication(Scs2Res.mandant_qa_K, webDriver);
            SeleniumConfig = new SeleniumConfig {Timeouts = {ImplicitlyWait = 5, SetScriptTimeout = 10}};
        }
    }
}