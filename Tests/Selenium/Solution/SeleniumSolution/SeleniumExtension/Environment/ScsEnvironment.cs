using System;
using Six.Scs.QA.Selenium.Extension.Authentication.Method;
using Six.Scs.QA.Selenium.Extension.Authentication.WebPages;
using Six.Scs.QA.Selenium.Extension.Properties;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;

namespace Six.Scs.QA.Selenium.Extension.Environment
{
    public class ScsEnvironment
    {
        public static void Dev()
        {
            TestEnvironment.BaseUrl = new Uri(ScsRes.UAC_DEV);
            TestEnvironment.BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            TestEnvironment.Application = new LobbyView();
            TestEnvironment.Authentication = new UacAuthentication(new UacLogOnPage(), ScsRes.uac_username, ScsRes.uac_passwort);
            TestEnvironment.SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 6, SetScriptTimeout = 20, SetPageLoadTimeout = 60}
            };
        }

        public static void Local()
        {
            TestEnvironment.BaseUrl = new Uri(ScsRes.UAC_LOCAL);
            TestEnvironment.BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            TestEnvironment.Application = new LobbyView();
            TestEnvironment.Authentication = new UacAuthentication(new UacLogOnPage(), ScsRes.uac_username, ScsRes.uac_passwort);
            TestEnvironment.SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 60}
            };
        }

        public static void Prod()
        {
            TestEnvironment.BaseUrl = new Uri(ScsRes.WES_Production);
            TestEnvironment.BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            TestEnvironment.Application = new LobbyView();
            TestEnvironment.Authentication = new SecurIdAuthentication("user", "pass", ScsRes.mandant_prod, "securId");
            TestEnvironment.SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 60}
            };
        }

        public static void QaK()
        {
            TestEnvironment.BaseUrl = new Uri(ScsRes.WES_QA_K);
            TestEnvironment.BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            TestEnvironment.Application = new LobbyView();
            TestEnvironment.Authentication = new CertificateAuthentication(ScsRes.mandant_qa_K);
            TestEnvironment.SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 60}
            };
        }

        public static void QaL()
        {
            TestEnvironment.BaseUrl = new Uri(ScsRes.WES_QA_L);
            TestEnvironment.BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            TestEnvironment.Application = new LobbyView();
            TestEnvironment.Authentication = new CertificateAuthentication(ScsRes.mandant_qa_L);
            TestEnvironment.SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
            };
        }
    }
}