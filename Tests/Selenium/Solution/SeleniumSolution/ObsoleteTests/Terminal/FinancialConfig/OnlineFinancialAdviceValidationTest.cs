using NUnit.Framework;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal.FinancialConfig;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.FinancialConfig
{
    [TestFixture]
    public class OnlineFinancialAdviceValidationTest
    {
        [SetUp]
        public void TestInit()
        {
            TestDirector.Navigate(
                "Pages/Terminal/TerminalView.aspx?PageMode=edit&EditSection=Financialconfig&TerminalId=21011402");
        }

        [Test]
        public void CharactersNotAllowed()
        {
            SetOnlineFinancialAndSave("ab");
            Assert.IsTrue(
                FormAlert.FormAlertList.Contains(
                    "Financial Advice Queue Size: Ihre Eingabe ist ungültig! Ungültige Zeichen gefunden!"));
        }

        [Test]
        public void AlphanumericNotAllowed()
        {
            SetOnlineFinancialAndSave("9*");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Financial Advice Queue Size: Ihre Eingabe ist ungültig!");
        }

        [Test]
        public void NegativNumberNotAllowed()
        {
            SetOnlineFinancialAndSave("-1");

            CollectionAssert.Contains(FormAlert.FormAlertList,
                "Financial Advice Queue Size: Ungültige Zeichen gefunden!");
        }

        [Test]
        public void ZeroNotAllowed()
        {
            SetOnlineFinancialAndSave("0");

            CollectionAssert.Contains(FormAlert.FormAlertList,
                "Financial Advice Queue Size: Ungültige Zeichen gefunden!");
        }

        [Test]
        public void ValueAllowed()
        {
            SetOnlineFinancialAndSave("11");

            Assert.AreEqual(0, FormAlert.FormAlertList.Count);
        }

        private static void SetOnlineFinancialAndSave(string queueSize)
        {
            Edit.AdviceQueueSize = queueSize;
            Edit.SaveButton.Click();
        }
    }
}