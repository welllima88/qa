﻿using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Properties;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.Settings
{
    public class QaK : TestEnvironment
    {
        public QaK()
        {
            BaseUrl = ScsRes.WES_QA_K;
            BrowserProfileName = DriverRes.FirefoxProfile_Certificate;
            Application = new LobbyView();
            Authentication = new CertificateAuthentication(Scs2Res.mandant_qa_K);
            SeleniumConfig = new SeleniumConfig { Timeouts = new Timeouts { ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30 } };
        }
    }
}