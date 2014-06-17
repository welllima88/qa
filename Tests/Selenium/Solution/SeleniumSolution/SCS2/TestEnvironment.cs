﻿using System;
using Six.Scs.Tests.Selenium.Extension.Authentication.Method;
using Six.Scs.Tests.Selenium.Extension.Authentication.WebPages;
using Six.Scs.Tests.Selenium.Extension.Properties;
using Six.Scs.Tests.Selenium.Extension.Settings;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common;

namespace Six.Scs.Tests.Selenium
{
    public class TestEnvironment : Six.Scs.Tests.Selenium.Extension.Settings.TestEnvironment
    {
        public static void Dev()
        {
            BaseUrl = new Uri(ScsRes.UAC_DEV);
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new UacAuthentication(new UacLoginPage(), ScsRes.uac_username, ScsRes.uac_passwort);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 6, SetScriptTimeout = 20, SetPageLoadTimeout = 60}
            };
        }

        public static void Local()
        {
            BaseUrl = new Uri(ScsRes.UAC_LOCAL);
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new UacAuthentication(new UacLoginPage(), ScsRes.uac_username, ScsRes.uac_passwort);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 60}
            };
        }

        public static void Prod()
        {
            BaseUrl = new Uri(ScsRes.WES_Production);
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new SecurIdAuthentication("user", "pass", ScsRes.mandant_prod, "securId");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 60}
            };
        }

        public static void QaK()
        {
            BaseUrl = new Uri(ScsRes.WES_QA_K);
            BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            Application = new LobbyView();
            Authentication = new CertificateAuthentication(ScsRes.mandant_qa_K);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 60}
            };
        }

        public static void QaL()
        {
            BaseUrl = new Uri(ScsRes.WES_QA_L);
            BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            Application = new LobbyView();
            Authentication = new CertificateAuthentication(ScsRes.mandant_qa_L);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
            };
        }
    }
}