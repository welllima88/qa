using System;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Authentication.WebPages;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium
{
    public class ScsPlatinTestEnvironment : TestEnvironment
    {
        public static void PrepareForDev()
        {
            BaseUrl = new Uri(Scs2Res.UAC_DEV);
            BrowserProfileName = Scs2Res.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new UacAuthentication(new UacLoginPage(), Scs2Res.uac_username, Scs2Res.uac_passwort);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void PrepareForLocal()
        {
            BaseUrl = new Uri(Scs2Res.UAC_LOCAL);
            BrowserProfileName = Scs2Res.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new UacAuthentication(new UacLoginPage(), Scs2Res.uac_username, Scs2Res.uac_passwort);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 40}
                };
        }

        public static void PrepareForProd()
        {
            BaseUrl = new Uri(Scs2Res.WES_Production);
            BrowserProfileName = Scs2Res.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new SecurIdAuthentication("user", "pass", Scs2Res.mandant_prod, "securId");
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void PrepareForQaK()
        {
            BaseUrl = new Uri(Scs2Res.WES_QA_K);
            BrowserProfileName = Scs2Res.FirefoxProfile_Certificate;
            Application = new LobbyView();
            Authentication = new CertificateAuthentication(Scs2Res.mandant_qa_K);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void PrepareForQaL()
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