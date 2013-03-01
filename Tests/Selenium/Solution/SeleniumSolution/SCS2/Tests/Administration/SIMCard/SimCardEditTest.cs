using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SimCard;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardEditTest
    {
        private static SimCardView _simCardView;
        private static SimCardEdit _simCardEdit;
        private static SimCardCreate _simCardCreate;
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static FormAlert _formAlert;
        private static Lobby _lobby;
        private static TestDirector _tb;
        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new Scs2TestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout

            _simCardView = new SimCardView(_driver);
            _simCardEdit = new SimCardEdit(_driver);
            _simCardCreate = new SimCardCreate(_driver);
            _navigationBar = new NavigationBar(_driver);
            _formAlert = new FormAlert(_driver);
            _lobby = new Lobby(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/SIMCard/Details?SIMCardId=1";
            _dt = DateTime.Now.Ticks; //timestamp for each test
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
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
            Assert.IsTrue(_formAlerts.Count == 1);
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
            Assert.IsTrue(_formAlerts.Count == 1);
        }

        [TestMethod]
        public void EditSimcardForInvalidTerminalIdFails()
        {
            _simCardView.EditButton.Click();

            _simCardEdit.TerminalId = "-1";

            _simCardEdit.SaveButton.Click();

            _formAlerts = _formAlert.FormAlertList;
            CollectionAssert.Contains(_formAlerts, "unknown TerminalId");
            Assert.IsTrue(_formAlerts.Count == 1);
        }
    }
}