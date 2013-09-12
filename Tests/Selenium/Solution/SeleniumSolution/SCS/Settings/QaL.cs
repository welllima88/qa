using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.Settings
{
    public class QaL : TestEnvironment
    {
        public QaL()
        {
            BaseUrl = ScsRes.WES_QA_L;
            BrowserProfileName = DriverRes.FirefoxProfile_Certificate;
            Application = new Scs();
            Authentication = new CertificateAuthentication(Scs2Res.mandant_qa_L);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }
    }
}