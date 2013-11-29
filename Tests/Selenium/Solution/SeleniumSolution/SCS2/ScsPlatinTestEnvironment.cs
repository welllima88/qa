﻿using System;
using SIX.SCS.QA.Selenium.Extension.Authentication.Method;
using SIX.SCS.QA.Selenium.Extension.Authentication.WebPages;
using SIX.SCS.QA.Selenium.Extension.Properties;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium
{
    public class ScsPlatinTestEnvironment : TestEnvironment
    {
        public static void LoadConfigurationDev()
        {
            BaseUrl = new Uri(ScsRes.UAC_DEV);
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new UacAuthentication(new UacLoginPage(), ScsRes.uac_username, ScsRes.uac_passwort);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void LoadConfigurationLocal()
        {
            BaseUrl = new Uri(ScsRes.UAC_LOCAL);
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new UacAuthentication(new UacLoginPage(), ScsRes.uac_username, ScsRes.uac_passwort);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 15, SetPageLoadTimeout = 40}
                };
        }

        public static void LoadConfigurationProd()
        {
            BaseUrl = new Uri(ScsRes.WES_Production);
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new LobbyView();
            Authentication = new SecurIdAuthentication("user", "pass", ScsRes.mandant_prod, "securId");
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void LoadConfigurationQaK()
        {
            BaseUrl = new Uri(ScsRes.WES_QA_K);
            BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            Application = new LobbyView();
            Authentication = new CertificateAuthentication(ScsRes.mandant_qa_K);
            SeleniumConfig = new SeleniumConfig
                {
                    Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
                };
        }

        public static void LoadConfigurationQaL()
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