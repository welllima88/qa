using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Properties;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Settings
{
    public class QaK : TestEnvironment
    {
        public QaK()
        {
            BaseUrl = Scs2Res.WES_QA_K;
            BrowserProfileName = DriverRes.FirefoxProfile_Certificate;
            Application = new LobbyView();
            Authentication = new CertificateAuthentication(Scs2Res.mandant_qa_K);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }
    }
}