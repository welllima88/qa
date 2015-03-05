using System;
using Six.QA.Selenium.Extension.Authentication.Method;
using Six.QA.Selenium.Extension.Environment;
using Six.QA.Selenium.Extension.Properties;
using Six.Scs.QA.Selenium.Common;

namespace Six.Scs.QA.Selenium.Environments
{
    public class Local : TestEnvironment
    {
        public Local()
        {
            BaseUrl = new Uri(ScsRes.UAC_LOCAL);
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new Lobby();
            Authentication = new UacAuthentication(new UacLogOnPage(), ScsRes.uac_username,
                ScsRes.uac_passwort);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 4, SetScriptTimeout = 30, SetPageLoadTimeout = 60}
            };
        }
    }
}