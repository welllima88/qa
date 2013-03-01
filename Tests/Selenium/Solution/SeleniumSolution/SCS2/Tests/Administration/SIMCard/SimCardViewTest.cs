using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SimCard;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardCreateTest
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
            _driver.Url = _tb.BaseUrl + "/Pages/Person/PersonEdit.aspx?PageMode=view&PersonId=8935";
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
        public void CheckEditContactMenu()
        {
        }
    }
}