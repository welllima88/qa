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
            View.EditButton.Click();

            Edit.NetProvider = "Swisscom";
            Edit.Status = true;
            Edit.TerminalId = "3001001";

            Edit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "unknown TerminalId.");
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
        }

        [Test]
        public void EditSimcardForInvalidTerminalIdFails()
        {
            View.EditButton.Click();

            Edit.TerminalId = "-1";

            Edit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "unknown TerminalId.");
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
        }

        [Test]
        public void EditSimcardForUnknownTerminalIdFails()
        {
            View.EditButton.Click();

            Edit.NetProvider = "Orange";
            Edit.Status = true;
            Edit.TerminalId = "3001001";
            Edit.Region = "Schweiz";
            Edit.Usage = "Kurzmiete";

            Edit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "unknown TerminalId.");
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
        }
    }
}