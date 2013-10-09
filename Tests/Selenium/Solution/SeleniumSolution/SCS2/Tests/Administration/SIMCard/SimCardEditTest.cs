using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardEditTest
    {
        private static SimCardView _simCardView;
        private static SimCardEdit _simCardEdit;
        private static FormAlert _formAlert;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _simCardView = new SimCardView();
            _simCardEdit = new SimCardEdit();
            _formAlert = new FormAlert();
        }

        [TestInitialize]
        public void TestInit()
        {
            // SIMCard/EditCard?simCardId=11
            TestLauncher.Navigate("/SIMCard/Details?SIMCardId=1");
        }

        [TestMethod]
        public void EditSimcardAndSave()
        {
            _simCardView.EditButton.Click();

            _simCardEdit.NetProvider = "Sunrise";
            _simCardEdit.SimCardNumber = "0123456789012345678";
            _simCardEdit.MobileNumber = "1234567890";
            _simCardEdit.Pin = "4321";
            _simCardEdit.Puk = "22446688";
            _simCardEdit.Status = true;
            _simCardEdit.TerminalId = "21012730";
            _simCardEdit.Region = "International";
            _simCardEdit.Usage = "Miete";

            _simCardEdit.SaveButton.Click();

            Assert.AreEqual(_simCardView.SimCardElement.NetProvider, "SIX via Swisscom");
            Assert.AreEqual(_simCardView.SimCardElement.SimCardNumber, "0123456789012345678");
            Assert.AreEqual(_simCardView.SimCardElement.MobileNumber, "1234567890");
            Assert.AreEqual(_simCardView.SimCardElement.Pin, "4321");
            Assert.AreEqual(_simCardView.SimCardElement.Puk, "22446688");
            Assert.AreEqual(_simCardView.SimCardElement.Status, true);
            Assert.AreEqual(_simCardView.SimCardElement.TerminalId, "21012730");
        }

        [TestMethod]
        public void EditSimcardForUnknownTerminalIdFails()
        {
            _simCardView.EditButton.Click();

            _simCardEdit.NetProvider = "Orange";
            _simCardEdit.Status = true;
            _simCardEdit.TerminalId = "3001001";
            _simCardEdit.Region = "Schweiz";
            _simCardEdit.Usage = "Kurzmiete";

            _simCardEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            CollectionAssert.Contains(_formAlerts, "unknown TerminalId");
            Assert.AreEqual(5, _formAlerts.Count);
        }

        [TestMethod]
        public void EditSimcardForAlreadyUsedTerminalIdFails()
        {
            _simCardView.EditButton.Click();

            _simCardEdit.NetProvider = "Swisscom";
            _simCardEdit.Status = true;
            _simCardEdit.TerminalId = "3001001";

            _simCardEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            CollectionAssert.Contains(_formAlerts, "unknown TerminalId");
            Assert.AreEqual(1, _formAlerts.Count);
        }

        [TestMethod]
        public void EditSimcardForInvalidTerminalIdFails()
        {
            _simCardView.EditButton.Click();

            _simCardEdit.TerminalId = "-1";

            _simCardEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            CollectionAssert.Contains(_formAlerts, "unknown TerminalId");
            Assert.AreEqual(1, _formAlerts.Count);
        }
    }
}