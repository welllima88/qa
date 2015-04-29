using System;
using Six.Scs.Test.View.Common;
using Six.Test.Selenium.Authentication.Method;
using Six.Test.Selenium.Environment;

namespace Six.Scs.Test.View.Environments
{
    public class Dev : TestEnvironment
    {
        public Dev()
        {
            BaseUrl = new Uri("https://scs.tkcdev.com/scs2/");

            Application = new Lobby();
            Authentication = new UacAuthentication(new UacLogOnPage(), "six_scs_auto", "six_scs_auto_PW");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 10, SetScriptTimeout = 30, SetPageLoadTimeout = 60}
            };
        }
    }
}