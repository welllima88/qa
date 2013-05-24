﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Terminal
{
    [TestClass]
    public class OnlineFinancialAdviceValidation
    {
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login

            _formAlert = new FormAlert(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl +
                          "/Pages/Terminal/TerminalView.aspx?PageMode=edit&EditSection=Financialconfig&TerminalId=21011402";
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void CharactersOnlyNotAllowed()
        {
            SetOnlineFinancialAndSave("ab");
            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(
                _formAlerts.Contains(
                    "Financial Advice Queue Size: Ihre Eingabe ist ungültig! Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void AlphaNumericNotAllowed()
        {
            SetOnlineFinancialAndSave("9*");
            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Contains("Financial Advice Queue Size: Ihre Eingabe ist ungültig!"));
        }

        [TestMethod]
        public void NegativNumberNotAllowed()
        {
            SetOnlineFinancialAndSave("-1");
            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Contains("Financial Advice Queue Size: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void ZeroNotAllowed()
        {
            SetOnlineFinancialAndSave("0");
            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Contains("Financial Advice Queue Size: Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void ValueAllowed()
        {
            SetOnlineFinancialAndSave("11");
            _formAlerts = _formAlert.FormAlertList;
            Assert.IsFalse(_formAlerts.Count == 1);
        }

        private static void SetOnlineFinancialAndSave(string value)
        {
            _driver.FindAdaptedElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_tbcTerminalData_tpFinancialconfig_tpFinancialconfigPropertyMaxFinAdvQueueSize_valueText"))
                .TypeText(value);
            _driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnSave")).Click();
        }
    }
}