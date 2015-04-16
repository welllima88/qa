using System;
using Six.QA.Selenium.Extension.Authentication.Method;
using Six.QA.Selenium.Extension.Environment;
using Six.Saferpay.QA.Selenium.Pages.Common;

namespace Six.Saferpay.QA.Selenium.Environment
{
    public class Dev : TestEnvironment
    {
        public Dev()
        {
            BaseUrl = new Uri("https://mdzhwcweb01/Saferpay/BO");
            Application = new Lobby();
            Authentication = new UacAuthentication(new UacLogOnPage(), "six_scs_auto", "six_scs_auto_PW");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 10, SetScriptTimeout = 30, SetPageLoadTimeout = 60}
            };
        }
    }
}