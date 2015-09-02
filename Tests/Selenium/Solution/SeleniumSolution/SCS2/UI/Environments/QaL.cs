using System;
using Six.Scs.Test.UI.Common;
using Six.Test.Selenium.Authentication.Method;
using Six.Test.Selenium.Environment;

namespace Six.Scs.Test.UI.Environments
{
    public class QaL : TestEnvironment
    {
        public QaL()
        {
            BaseUrl = new Uri("https://webint.six-payment-services.com/scs2s-qa-l/");

            Application = new Lobby();
            Authentication = new SecurIdAuthentication("tksyr", "ZVUtiXlV#", "tkcposl", "1110958388");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 10, SetScriptTimeout = 30, SetPageLoadTimeout = 30}
            };
        }
    }
}