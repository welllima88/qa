using System;
using Six.Scs.Test.View.Common;
using Six.Test.Selenium.Authentication.Method;
using Six.Test.Selenium.Environment;

namespace Six.Scs.Test.View.Environments
{
    public class QaK : TestEnvironment
    {
        public QaK()
        {
            BaseUrl = new Uri("https://gateint.telekurs.ch/scs2s-qa-k/");

            Application = new Lobby();
            Authentication = new SecurIdAuthentication("tksyr", @"password", "tkcposk", "securId+passcode");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 3, SetScriptTimeout = 30, SetPageLoadTimeout = 60}
            };
        }
    }
}