using System;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Settings
{
    public class Prod : TestEnvironment
    {
        public Prod()
        {
            BaseUrl = new Uri(Scs2Res.WES_Production);
            BrowserProfileName = Scs2Res.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new SecurIdAuthentication("user", "pass", Scs2Res.mandant_prod, "securId");
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }
    }
}