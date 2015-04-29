using System;
using Six.Saferpay.Backoffice.Test.Pages.Common;
using Six.Test.Selenium.Authentication.Method;
using Six.Test.Selenium.Environment;

namespace Six.Saferpay.Backoffice.Test.Environment
{
    public class Dev : TestEnvironment
    {
        public Dev()
        {
            BaseUrl = new Uri("https://saferpay.tkcdev.com/BO");
            Application = new Lobby();
            Authentication = new UacAuthentication(new UacLogOnPage(), "six_scs_auto", "six_scs_auto_PW");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 10, SetScriptTimeout = 30, SetPageLoadTimeout = 60}
            };
        }
    }
}