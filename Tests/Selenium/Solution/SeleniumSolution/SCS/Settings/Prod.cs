using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.Settings
{
    public class Prod : TestEnvironment
    {
        public Prod(IWebDriverAdapter webDriver)
        {
            BaseUrl = ScsRes.WES_Production;
            BrowserProfileName = DriverRes.FirefoxProfile_Plain;
            Application = new LobbyView(webDriver);
            Authentication = new SecurIdAuthentication("user","pass",Scs2Res.mandant_prod,"securId", webDriver);
            SeleniumConfig = new SeleniumConfig {Timeouts = {ImplicitlyWait = 5, SetScriptTimeout = 10}};
        }
    }
}