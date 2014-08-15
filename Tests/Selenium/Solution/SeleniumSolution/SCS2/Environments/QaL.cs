using System;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.Authentication.Method;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.Properties;

namespace Six.Scs.QA.Selenium.Environments
{
    public class QaL : TestEnvironment
    {
        public QaL()
        {
            BaseUrl = new Uri(ScsRes.WES_QA_L);
            BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            Application = new Lobby();
            Authentication = new CertificateAuthentication(ScsRes.mandant_qa_L);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
            };
        }
    }
}