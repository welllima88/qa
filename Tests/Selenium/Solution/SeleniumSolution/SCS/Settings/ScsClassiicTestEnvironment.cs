using System;
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
            BaseUrl = new Uri("https://mdzhwcweb01/scs2/");
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new Scs();
            Authentication = new UacAuthentication(new UacLoginPageOld(), ScsRes.uac_username, ScsRes.uac_passwort);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void Prod()
        {
            BaseUrl = new Uri("https://gate.telekurs.ch/scss");
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new Scs();
            Authentication = new SecurIdDialogBox();
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void QaK()
        {
            BaseUrl = new Uri("https://gateint.telekurs.ch/scsc-qa-k/");
            BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            Application = new Scs();
            Authentication = new CertificateAuthentication(ScsRes.mandant_qa_K);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void QaL()
        {
            BaseUrl = new Uri("https://gateint.telekurs.ch/scs2c-qa-l/");
            BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            Application = new Scs();
            Authentication = new CertificateAuthentication(ScsRes.mandant_qa_L);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }
    }
}