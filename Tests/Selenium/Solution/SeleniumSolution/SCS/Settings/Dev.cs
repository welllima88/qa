using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.Settings
{
    public class Dev : TestEnvironment
    {
        public Dev()
        {
            BaseUrl = ScsRes.UAC_DEV;
            BrowserProfileName = DriverRes.FirefoxProfile_Plain;
            Application = new Scs();
            Authentication = new UacAuthentication(Scs2Res.uac_username, Scs2Res.uac_passwort);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }
    }
}