﻿using SIX.SCS.QA.SCSClassics.Tests.Selenium.Properties;
using SIX.SCS.QA.SCSClassics.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Properties;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Authentication.WebPages;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;

namespace SIX.SCS.QA.SCSClassics.Tests.Selenium.Settings
{
    public class Dev : TestEnvironment
    {
        public Dev()
        {
            BaseUrl = ScsRes.UAC_DEV;
            BrowserProfileName = DriverRes.FirefoxProfile_Plain;
            Application = new Scs();
            Authentication = new UacAuthentication(new UacLoginPageOld(), Scs2Res.uac_username, Scs2Res.uac_passwort);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }
    }
}