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
        public Prod()
        {
            BaseUrl = ScsRes.WES_Production;
            BrowserProfileName = DriverRes.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new SecurIdAuthentication();
            SeleniumConfig = new SeleniumConfig {Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10}};
        }
    }
}