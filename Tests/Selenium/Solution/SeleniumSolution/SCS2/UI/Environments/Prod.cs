using System;
using Six.Scs.Test.UI.Common;
using Six.Test.Selenium.Authentication.Method;
using Six.Test.Selenium.Environment;

namespace Six.Scs.Test.UI.Environments
{
    public class Prod : TestEnvironment
    {
        public Prod()
        {
            BaseUrl = new Uri("https://gate.telekurs.ch/scs2s/");

            Application = new Lobby();
            Authentication = new SecurIdAuthentication("tksyr", "password", "tkcpos", "securId+passcode");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 30, SetPageLoadTimeout = 60}
            };
        }
    }
}