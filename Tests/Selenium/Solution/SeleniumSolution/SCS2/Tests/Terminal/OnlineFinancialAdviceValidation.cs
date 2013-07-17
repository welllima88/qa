using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Terminal
{
    [TestClass]
    public class OnlineFinancialAdviceValidation
    {
        private static FormAlert _formAlert;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _formAlert = new FormAlert();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate(
                "/Pages/Terminal/TerminalView.aspx?PageMode=edit&EditSection=Financialconfig&TerminalId=21011402");
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
            Assert.AreEqual(1, _formAlerts.Count);
        }

        private static void SetOnlineFinancialAndSave(string value)
        {
            TestLauncher.TestDirector.WebDriver.FindAdaptedElement(
                By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_tbcTerminalData_tpFinancialconfig_tpFinancialconfigPropertyMaxFinAdvQueueSize_valueText"))
                        .TypeText(value);
            TestLauncher.TestDirector.WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_btnSave"))
                        .Click();
        }
    }
}