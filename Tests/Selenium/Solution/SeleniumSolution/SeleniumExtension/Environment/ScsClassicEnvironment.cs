using System;
using Six.Scs.QA.Selenium.Extension.Authentication.Method;
using Six.Scs.QA.Selenium.Extension.Authentication.WebPages;
using Six.Scs.QA.Selenium.Extension.Properties;

namespace Six.Scs.QA.Selenium.Extension.Environment
{
    public class ScsClassicEnvironment
    {
        public static void Dev()
        {
            TestEnvironment.BaseUrl = new Uri("https://mdzhwcweb01/mgmt/");
            TestEnvironment.BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            TestEnvironment.Application = new TestObjects.Common.Scs();
            TestEnvironment.Authentication = new UacAuthentication(new UacLogOnPageOld(), ScsRes.uac_username, ScsRes.uac_passwort);
            TestEnvironment.SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
            };
        }

        public static void Prod()
        {
            TestEnvironment.BaseUrl = new Uri("https://gate.telekurs.ch/scss/");
            TestEnvironment.BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            TestEnvironment.Application = new TestObjects.Common.Scs();
            TestEnvironment.Authentication = new SecurIdAuthentication("tksyr", @"PW", "tkcpos", "??");
            TestEnvironment.SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
            };
        }

        public static void QaK()
        {
            TestEnvironment.BaseUrl = new Uri("https://gateint.telekurs.ch/scsc-qa-k/");
            TestEnvironment.BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            TestEnvironment.Application = new TestObjects.Common.Scs();
            TestEnvironment.Authentication = new CertificateAuthentication(ScsRes.mandant_qa_K);
            TestEnvironment.SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
            };
        }

        public static void QaL()
        {
            TestEnvironment.BaseUrl = new Uri("https://gateint.telekurs.ch/scsc-qa-l/");
            TestEnvironment.BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            TestEnvironment.Application = new TestObjects.Common.Scs();
            TestEnvironment.Authentication = new CertificateAuthentication(ScsRes.mandant_qa_L);
            TestEnvironment.SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
            };
        }
    }
}