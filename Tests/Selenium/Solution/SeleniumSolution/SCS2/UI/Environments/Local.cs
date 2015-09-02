using System;
using Six.Scs.Test.UI.Common;
using Six.Test.Selenium.Authentication.Method;
using Six.Test.Selenium.Environment;

namespace Six.Scs.Test.UI.Environments
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