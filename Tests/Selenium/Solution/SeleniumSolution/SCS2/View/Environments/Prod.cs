using System;
using Six.QA.Selenium.Extension.Authentication.Method;
using Six.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.View.Common;

namespace Six.Scs.QA.Selenium.View.Environments
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