using System;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.Authentication.Method;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.Properties;

namespace Six.Scs.QA.Selenium.Environments
{
    public class Prod : TestEnvironment
    {
        public Prod()
        {
            BaseUrl = new Uri(ScsRes.WES_Production);
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new Lobby();
            Authentication = new SecurIdAuthentication("user", "pass", ScsRes.mandant_prod, "securId");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 60}
            };
        }
    }
}