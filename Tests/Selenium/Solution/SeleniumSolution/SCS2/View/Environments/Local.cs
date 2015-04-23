using System;
using Six.QA.Selenium.Extension.Authentication.Method;
using Six.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.View.Common;

namespace Six.Scs.QA.Selenium.View.Environments
{
    public class Local : TestEnvironment
    {
        public Local()
        {
            BaseUrl = new Uri("https://wksiegmund01/scs2/");
            Application = new Lobby();
            Authentication = new UacAuthentication(new UacLogOnPage(), "six_scs_auto", "six_scs_auto_PW");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 4, SetScriptTimeout = 30, SetPageLoadTimeout = 60}
            };
        }
    }
}