using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.FinancialConfig;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal
{
    [TestClass]
    public class OnlineFinancialAdviceValidation
    {
        private static FormAlert _formAlert;
        private static FinancialConfigEdit _financialConfig;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _formAlert = new FormAlert();
            _financialConfig = new FinancialConfigEdit();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate(
                "/Pages/Terminal/TerminalView.aspx?PageMode=edit&EditSection=Financialconfig&TerminalId=21011402");
        }

        [TestMethod]
        public void CharactersNotAllowed()
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
            CollectionAssert.Contains(_formAlerts, "Financial Advice Queue Size: Ihre Eingabe ist ungültig!");
        }

        [TestMethod]
        public void NegativNumberNotAllowed()
        {
            SetOnlineFinancialAndSave("-1");
            _formAlerts = _formAlert.FormAlertList;
            CollectionAssert.Contains(_formAlerts, "Financial Advice Queue Size: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void ZeroNotAllowed()
        {
            SetOnlineFinancialAndSave("0");
            _formAlerts = _formAlert.FormAlertList;
            CollectionAssert.Contains(_formAlerts, "Financial Advice Queue Size: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void ValueAllowed()
        {
            SetOnlineFinancialAndSave("11");
            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(1, _formAlerts.Count);
        }

        private static void SetOnlineFinancialAndSave(string queueSize)
        {
            _financialConfig.AdviceQueueSize = queueSize;
        }
    }
}