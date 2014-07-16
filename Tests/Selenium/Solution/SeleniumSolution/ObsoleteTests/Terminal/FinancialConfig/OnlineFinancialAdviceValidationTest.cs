﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal.FinancialConfig;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.FinancialConfig
{
    [TestClass]
    public class OnlineFinancialAdviceValidationTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate(
                "Pages/Terminal/TerminalView.aspx?PageMode=edit&EditSection=Financialconfig&TerminalId=21011402");
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
        public void AlphanumericNotAllowed()
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

            Assert.AreEqual(0, FormAlert.FormAlertList.Count);
        }

        private static void SetOnlineFinancialAndSave(string queueSize)
        {
            FinancialConfigEdit.AdviceQueueSize = queueSize;
            FinancialConfigEdit.SaveButton.Click();
        }
    }
}