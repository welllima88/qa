﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardEditTest
    {
        [TestInitialize]
        public void TestInit()
        {
            // SIMCard/EditCard?simCardId=11
            TestLauncher.Navigate("/SIMCard/Details?SIMCardId=1");
        }

        [TestMethod]
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

            Assert.AreEqual(SimCardView.SimCardElement.NetProvider, "SIX via Swisscom");
            Assert.AreEqual(SimCardView.SimCardElement.SimCardNumber, "0123456789012345678");
            Assert.AreEqual(SimCardView.SimCardElement.MobileNumber, "1234567890");
            Assert.AreEqual(SimCardView.SimCardElement.Pin, "4321");
            Assert.AreEqual(SimCardView.SimCardElement.Puk, "22446688");
            Assert.AreEqual(SimCardView.SimCardElement.Status, true);
            Assert.AreEqual(SimCardView.SimCardElement.TerminalId, "21012730");
        }

        [TestMethod]
        public void EditSimcardForUnknownTerminalIdFails()
        {
            SimCardView.EditButton.Click();

            SimCardEdit.NetProvider = "Orange";
            SimCardEdit.Status = true;
            SimCardEdit.TerminalId = "3001001";
            SimCardEdit.Region = "Schweiz";
            SimCardEdit.Usage = "Kurzmiete";

            SimCardEdit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "unknown TerminalId");
            Assert.AreEqual(5, FormAlert.FormAlertList.Count);
        }

        [TestMethod]
        public void EditSimcardForAlreadyUsedTerminalIdFails()
        {
            SimCardView.EditButton.Click();

            SimCardEdit.NetProvider = "Swisscom";
            SimCardEdit.Status = true;
            SimCardEdit.TerminalId = "3001001";

            SimCardEdit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "unknown TerminalId");
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
        }

        [TestMethod]
        public void EditSimcardForInvalidTerminalIdFails()
        {
            SimCardView.EditButton.Click();

            SimCardEdit.TerminalId = "-1";

            SimCardEdit.SaveButton.Click();

            CollectionAssert.Contains(FormAlert.FormAlertList, "unknown TerminalId");
            Assert.AreEqual(1, FormAlert.FormAlertList.Count);
        }
    }
}