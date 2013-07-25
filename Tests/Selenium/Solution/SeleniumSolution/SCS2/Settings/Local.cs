using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Settings
{
    public class Local : TestEnvironment
    {
        public Local()
        {
            BaseUrl = Scs2Res.UAC_LOCAL;
            BrowserProfileName = DriverRes.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new UacAuthentication(Scs2Res.uac_username, Scs2Res.uac_passwort);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 40}
                };
        }
    }
}