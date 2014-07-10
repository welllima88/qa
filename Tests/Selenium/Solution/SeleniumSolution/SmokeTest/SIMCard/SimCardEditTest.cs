using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.TestObjects.Administration.SimCard;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;

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
            SimCardView.EditButton.Click();

            SimCardEdit.NetProvider = "Sunrise";
            SimCardEdit.SimCardNumber = "0123456789012345678";
            SimCardEdit.MobileNumber = "1234567890";
            SimCardEdit.Pin = "4321";
            SimCardEdit.Puk = "22446688";
            SimCardEdit.Status = true;
            SimCardEdit.TerminalId = "21012730";
            SimCardEdit.Region = "International";
            SimCardEdit.Usage = "Miete";

            SimCardEdit.SaveButton.Click();

            Assert.AreEqual(SimCardView.NetProvider, "SIX via Swisscom");
            Assert.AreEqual(SimCardView.SimCardNumber, "0123456789012345678");
            Assert.AreEqual(SimCardView.MobileNumber, "1234567890");
            Assert.AreEqual(SimCardView.Pin, "4321");
            Assert.AreEqual(SimCardView.Puk, "22446688");
            Assert.AreEqual(SimCardView.Status, true);
            Assert.AreEqual(SimCardView.TerminalId, "21012730");
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