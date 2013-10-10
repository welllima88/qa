using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.FinancialConfig;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.FinancialConfig
{
    [TestClass]
    public class OnlineFinancialAdviceValidationTest
    {
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
            Assert.IsTrue(
                FormAlert.FormAlertList.Contains(
                    "Financial Advice Queue Size: Ihre Eingabe ist ungültig! Ungültige Zeichen gefunden!"));
        }

        [TestMethod]
        public void AlphaNumericNotAllowed()
        {
            SetOnlineFinancialAndSave("9*");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Financial Advice Queue Size: Ihre Eingabe ist ungültig!");
        }

        [TestMethod]
        public void NegativNumberNotAllowed()
        {
            SetOnlineFinancialAndSave("-1");

            CollectionAssert.Contains(FormAlert.FormAlertList,
                                      "Financial Advice Queue Size: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void ZeroNotAllowed()
        {
            SetOnlineFinancialAndSave("0");

            CollectionAssert.Contains(FormAlert.FormAlertList,
                                      "Financial Advice Queue Size: Ungültige Zeichen gefunden!");
        }

        [TestMethod]
        public void ValueAllowed()
        {
            SetOnlineFinancialAndSave("11");

            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
        }

        private static void SetOnlineFinancialAndSave(string queueSize)
        {
            FinancialConfigEdit.AdviceQueueSize = queueSize;
        }
    }
}