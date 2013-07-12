using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Settings
{
    public class Dev : TestEnvironment
    {
        public Dev(IWebDriverAdapter webDriver)
        {
            BaseUrls = Scs2Res.UAC_DEV;
            BrowserProfileName = DriverRes.FirefoxProfile_Plain;
            Application = new LobbyView(webDriver);
            Authentication = new UacAuthentication(Scs2Res.uac_username, Scs2Res.uac_passwort, webDriver);
            SeleniumConfig = new SeleniumConfig {Timeouts = {ImplicitlyWait = 5, SetScriptTimeout = 10}};
        }
    }
}