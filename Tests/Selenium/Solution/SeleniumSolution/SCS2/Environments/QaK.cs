using System;
using Six.QA.Selenium.Extension.Authentication.Method;
using Six.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Common;

namespace Six.Scs.QA.Selenium.Environments
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