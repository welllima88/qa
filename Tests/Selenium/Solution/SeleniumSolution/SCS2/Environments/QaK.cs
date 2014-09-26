using System;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.Authentication.Method;
using Six.Scs.QA.Selenium.Extension.Environment;
using Six.Scs.QA.Selenium.Extension.Properties;

namespace Six.Scs.QA.Selenium.Environments
{
    public class QaK : TestEnvironment
    {
        public QaK()
        {
            BaseUrl = new Uri(ScsRes.WES_QA_K);
            BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            Application = new Lobby();
            Authentication = new CertificateAuthentication(ScsRes.mandant_qa_K);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 3, SetScriptTimeout = 30, SetPageLoadTimeout = 60}
            };
        }
    }
}