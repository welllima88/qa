using System;
using Six.QA.Selenium.Extension.Authentication.Method;
using Six.QA.Selenium.Extension.Authentication.Webpages;
using Six.QA.Selenium.Extension.Environment;
using Six.QA.Selenium.Extension.Properties;

namespace Six.Saferpay.QA.Selenium.Environment
{
    public class Dev : TestEnvironment
    {
        public Dev()
        {
            BaseUrl = new Uri("https://mdzhwcweb01/scs2/");
            Application = new Lobby();
            Authentication = new UacAuthentication(new UacLogOnPage(), ScsRes.uac_username,
                ScsRes.uac_passwort);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 10, SetScriptTimeout = 30, SetPageLoadTimeout = 60}
            };
        }
    }
}