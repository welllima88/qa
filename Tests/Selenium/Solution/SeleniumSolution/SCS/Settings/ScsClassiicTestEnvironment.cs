using System;
using SIX.SCS.QA.SCSClassics.Tests.Selenium.Properties;
using SIX.SCS.QA.SCSClassics.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Authentication.WebPages;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;

namespace SIX.SCS.QA.SCSClassics.Tests.Selenium.Settings
{
    public class ScsClassiicTestEnvironment : TestEnvironment
    {
        public static void Dev()
        {
            BaseUrl = new Uri(ScsRes.UAC_DEV);
            BrowserProfileName = Scs2Res.FirefoxProfile_Plain;
            Application = new Scs();
            Authentication = new UacAuthentication(new UacLoginPageOld(), Scs2Res.uac_username, Scs2Res.uac_passwort);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void Prod()
        {
            BaseUrl = new Uri(ScsRes.WES_Production);
            BrowserProfileName = Scs2Res.FirefoxProfile_Plain;
            Application = new Scs();
            Authentication = new SecurIdDialogBox();
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void QaK()
        {
            BaseUrl = new Uri(ScsRes.WES_QA_K);
            BrowserProfileName = Scs2Res.FirefoxProfile_Certificate;
            Application = new Scs();
            Authentication = new CertificateAuthentication(Scs2Res.mandant_qa_K);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void QaL()
        {
            BaseUrl = new Uri(ScsRes.WES_QA_L);
            BrowserProfileName = Scs2Res.FirefoxProfile_Certificate;
            Application = new Scs();
            Authentication = new CertificateAuthentication(Scs2Res.mandant_qa_L);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }
    }
}