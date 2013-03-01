using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SimCard;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardViewTest
    {
        private static SimCardListView _simCardListView;
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
            _tb = new ScsPlatinTestDirector();
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
            _driver.Url = _tb.BaseUrl + "/SIMCard/New";
            //_driver.Url = _tb.BaseUrl + "/Pages/Admin/AdminOverview.aspx";
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
        public void CreateSimCardAndSave()
        {
            string netProvider = "SIX via Swisscom";
            string simCardNumber = "0123456789012345679";
            string mobileNumber = "0123456789";
            string puk = "01234567";
            string pin = "0123";
            string region = "Schweiz";
            string usage = "Kauf";

            _simCardCreate.NetProvider = netProvider;
            _simCardCreate.SimCardNumber = simCardNumber;
            _simCardCreate.MobileNumber = mobileNumber;
            _simCardCreate.Pin = pin;
            _simCardCreate.Puk = puk;
            _simCardCreate.Region = region;
            _simCardCreate.Usage = usage;
            _simCardCreate.SaveButton.Click();

            Assert.AreEqual(_simCardView.SimCardElement.NetProvider, netProvider);
            Assert.AreEqual(_simCardView.SimCardElement.SimCardNumber, simCardNumber);
            Assert.AreEqual(_simCardView.SimCardElement.MobileNumber, mobileNumber);
            Assert.AreEqual(_simCardView.SimCardElement.Pin, pin);
            Assert.AreEqual(_simCardView.SimCardElement.Puk, puk);
            Assert.AreEqual(_simCardView.SimCardElement.Status, true);
            Assert.AreEqual(_simCardView.SimCardElement.TerminalId, "");
            Assert.AreEqual(_simCardView.SimCardElement.Region, region);
            Assert.AreEqual(_simCardView.SimCardElement.Usage, usage);

            Assert.IsTrue(_simCardView.SimCardHistory.HistoryList.Count == 1);
            // "13.12.2012 15:49:27 tksyr SIM-Karte erfasst"
            StringAssert.Matches(_simCardView.SimCardHistory.HistoryList[0],
                                 new Regex(TestRegExpPatterns.DateTime + " " + TestRegExpPatterns.UserName +
                                           " SIM Karte erfasst"));
        }
    }
}