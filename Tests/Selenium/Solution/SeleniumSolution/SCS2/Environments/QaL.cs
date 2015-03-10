using System;
using Six.QA.Selenium.Extension.Authentication.Method;
using Six.QA.Selenium.Extension.Environment;
using Six.QA.Selenium.Extension.Properties;
using Six.Scs.QA.Selenium.Common;

namespace Six.Scs.QA.Selenium.Environments
{
    public class QaL : TestEnvironment
    {
        public QaL()
        {
            BaseUrl = new Uri("https://gateint.telekurs.ch/scs2s-qa-l/");
            BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            Application = new Lobby();
            Authentication = new SecurIdAuthentication("tksyr", "", "tkcposl", "");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 10, SetScriptTimeout = 30, SetPageLoadTimeout = 30}
            };
        }
    }
}