﻿using System;
using Six.Scs.QA.Selenium.Extension.Authentication.Method;
using Six.Scs.QA.Selenium.Extension.Authentication.WebPages;
using Six.Scs.QA.Selenium.Extension.Properties;

namespace Six.Scs.QA.Selenium.Extension.Environment
{
    public class ScsClassicEnvironment : ScsEnvironment
    {
        public static void Dev()
        {
            BaseUrl = new Uri("https://mdzhwcweb01/mgmt/");
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new TestObjects.Common.Scs();
            Authentication = new UacAuthentication(new UacLogOnPageOld(), ScsRes.uac_username, ScsRes.uac_passwort);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
            };
        }

        public static void Prod()
        {
            BaseUrl = new Uri("https://gate.telekurs.ch/scss/");
            BrowserProfileName = ScsRes.FirefoxProfile_Plain;
            Application = new TestObjects.Common.Scs();
            Authentication = new SecurIdAuthentication("tksyr", @"PW", "tkcpos", "??");
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
            };
        }

        public static void QaK()
        {
            BaseUrl = new Uri("https://gateint.telekurs.ch/scsc-qa-k/");
            BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            Application = new TestObjects.Common.Scs();
            Authentication = new CertificateAuthentication(ScsRes.mandant_qa_K);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
            };
        }

        public static void QaL()
        {
            BaseUrl = new Uri("https://gateint.telekurs.ch/scsc-qa-l/");
            BrowserProfileName = ScsRes.FirefoxProfile_Certificate;
            Application = new TestObjects.Common.Scs();
            Authentication = new CertificateAuthentication(ScsRes.mandant_qa_L);
            SeleniumConfig = new SeleniumConfig
            {
                Timeouts = new Timeouts {ImplicitlyWait = 5, SetScriptTimeout = 10, SetPageLoadTimeout = 30}
            };
        }
    }
}