using System;
using Six.Scs.QA.Selenium.Extension.Authentication.Method;
using Six.Scs.QA.Selenium.Extension.Authentication.Webpages;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.Properties;

namespace Six.Scs.QA.Selenium
{
    public class Dev : TestEnvironment
    {
        public Dev()
        {
            BaseUrl = new Uri("https://mdzhwcweb01/mgmt/");
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new Common.Scs();
            Authentication = new UacAuthentication(new UacLogOnPageOld(),
                ScsRes.uac_username,
                ScsRes.uac_passwort);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts
                {
                    ImplicitlyWait = 5,
                    SetScriptTimeout = 10,
                    SetPageLoadTimeout = 30
                }
            };
        }
    }
}