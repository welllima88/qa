using System;
using Six.QA.Selenium.Extension.Authentication.Method;
using Six.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.View.Common;

namespace Six.Scs.QA.Selenium.View.Environments
{
    public class QaL : TestEnvironment
    {
        public QaL()
        {
            BaseUrl = new Uri("https://gateint.telekurs.ch/scs2s-qa-l/");

            Application = new Lobby();
            Authentication = new SecurIdAuthentication("tksyr", "ZVUtiXlV#", "tkcposl", "1110958388");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 10, SetScriptTimeout = 30, SetPageLoadTimeout = 30}
            };
        }
    }
}