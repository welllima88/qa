using System;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.Authentication.Method;
using Six.Scs.QA.Selenium.Extension.Authentication.WebPages;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.Properties;

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
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 60}
            };
        }
    }
}