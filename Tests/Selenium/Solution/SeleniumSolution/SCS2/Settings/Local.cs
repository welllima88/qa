using System;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Authentication.WebPages;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Settings
{
    public class Local : TestEnvironment
    {
        public Local()
        {
            BaseUrl = new Uri(Scs2Res.UAC_LOCAL);
            BrowserProfileName = Scs2Res.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new UacAuthentication(new UacLoginPage(), Scs2Res.uac_username, Scs2Res.uac_passwort);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 40}
                };
        }
    }
}