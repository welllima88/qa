using NUnit.Framework;
using Six.Scs.QA.Selenium.Administration.SimCard;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.Testlogic;

namespace Six.Scs.QA.Selenium.SmokeTest.SIMCard
{
    [TestFixture]
    public class SimCardEditTest
    {
        [SetUp]
        public void TestInit()
        {
            // SIMCard/EditCard?simCardId=11
            TestDirector.Navigate("SIMCard/Details?SIMCardId=16");
        }

        [Test]
        public void EditSimcardAndSave()
        {
            SimCard.Edit(Simcard.Edit());
        }

        [Test]
        public void EditSimcardForAlreadyUsedTerminalIdFails()
        {
            SimCardView.EditButton.Click();

            SimCardEdit.NetProvider = "Swisscom";
            SimCardEdit.Status = true;
            SimCardEdit.TerminalId = "3001001";

            SimCardEdit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "unknown TerminalId.");
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
        }

        [Test]
        public void EditSimcardForInvalidTerminalIdFails()
        {
            SimCardView.EditButton.Click();

            SimCardEdit.TerminalId = "-1";

            SimCardEdit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "unknown TerminalId.");
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
        }

        [Test]
        public void EditSimcardForUnknownTerminalIdFails()
        {
            SimCardView.EditButton.Click();

            SimCardEdit.NetProvider = "Orange";
            SimCardEdit.Status = true;
            SimCardEdit.TerminalId = "3001001";
            SimCardEdit.Region = "Schweiz";
            SimCardEdit.Usage = "Kurzmiete";

            SimCardEdit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "unknown TerminalId.");
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
        }
    }
}