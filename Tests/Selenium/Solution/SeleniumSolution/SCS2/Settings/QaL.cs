using System;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Settings
{
    public class QaL : TestEnvironment
    {
        public QaL()
        {
            BaseUrl = new Uri(Scs2Res.WES_QA_L);
            BrowserProfileName = Scs2Res.FirefoxProfile_Certificate;
            Application = new LobbyView();
            Authentication = new CertificateAuthentication(Scs2Res.mandant_qa_L);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }
    }
}