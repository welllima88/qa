using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.Dashboard
{
    [TestClass]
    public class BasicTerminalDashBoardTest
    {
        private static TerminalCreate _terminalCreate;
        private static TerminalView _terminalView;

        private static RecentElements _recentElements;
        private static FormAlert _formAlert;
        private static TerminalMenu _terminalMenu;
        private static CustomerMenu _customerMenu;
        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _terminalCreate = new TerminalCreate();
            _terminalView = new TerminalView();
            _recentElements = new RecentElements();

            _formAlert = new FormAlert();
            _terminalMenu = new TerminalMenu();
            _customerMenu = new CustomerMenu();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CUSTOMERID=85036");
            _dt = DateTime.Now.Ticks; //timestamp for each test
        }

        [TestMethod]
        public void CreateTerminalAndCancelTests()
        {
            CreateTerminalAndCancel();
            CreateTerminalWithIncompleteDataFailed();
        }

        [TestMethod]
        public void CreateTerminalAndCancel()
        {
            throw new NotSupportedException("no cancel action available");
        }

        [TestMethod]
        public void CreateTerminalWithIncompleteDataFailed()
        {
            _customerMenu.TerminalCreate.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.AreEqual(7, _formAlerts.Count);
            CollectionAssert.Contains(_formAlerts, "Kundenname: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Mandant: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "PLZ: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Ort: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(_formAlerts, "Land: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateTerminalMinimalAndSave()
        {
            _customerMenu.TerminalCreate.Click();

            _terminalCreate.TerminalChooser.Article = "xentissimo MOBILE WLAN, TCP/IP";

            _terminalCreate.TerminalConfigCreate.Infotext = "SYR AUTO Selenium Infotext";
            _terminalCreate.TerminalConfigCreate.Status = "Aktiviert";
            _terminalCreate.TerminalConfigCreate.SubStatus = "Aktiviert";
            _terminalCreate.TerminalConfigCreate.ServiceCenter = "SIX Payment Services Service Center ep2";
            _terminalCreate.TerminalConfigCreate.Pms = "SIX Payment Services PMS ep2";

            Assert.AreEqual(_terminalCreate.TerminalConfigCreate.TerminalType, "xentissimo");
            Assert.AreEqual(_terminalCreate.TerminalConfigCreate.Protocol, "EP2");
            Assert.AreEqual(_terminalCreate.TerminalConfigCreate.NetType, "TCP/IP ep2 (DNS) (TCPIPEP2)");

            _terminalCreate.TerminalConfigCreate.SaveButton.Click();
            _terminalMenu.Terminal.Click();

            //var custId = _terminalView.TerminalId;
            //Assert.AreEqual("SYR Sele Kunde A", _terminalView.TerminalId;
            //check/read TerminalId

            _recentElements.MostRecent.Click();

            //Assert.AreEqual(custId, _terminalView.CustomerNumber);
        }

        [TestMethod]
        public void CreateTerminalAndSave()
        {
            _customerMenu.TerminalCreate.Click();

            _terminalCreate.TerminalChooser.Article = "xentissimo MOBILE WLAN, TCP/IP";

            _terminalCreate.TerminalConfigCreate.Infotext = "SYR AUTO Selenium Infotext";
            _terminalCreate.TerminalConfigCreate.Status = "Aktiviert";
            _terminalCreate.TerminalConfigCreate.SubStatus = "Aktiviert";
            _terminalCreate.TerminalConfigCreate.ServiceCenter = "SIX Payment Services Service Center ep2";
            _terminalCreate.TerminalConfigCreate.Pms = "SIX Payment Services PMS ep2";

            Assert.AreEqual(_terminalCreate.TerminalConfigCreate.TerminalType, "xentissimo");
            Assert.AreEqual(_terminalCreate.TerminalConfigCreate.Protocol, "EP2");
            Assert.AreEqual(_terminalCreate.TerminalConfigCreate.NetType, "TCP/IP ep2 (DNS) (TCPIPEP2)");

            _terminalCreate.TerminalConfigCreate.ContinueButton.Click();

            Assert.AreEqual(_terminalCreate.TerminalConfigDetailsCreate.Article, "xentissimo MOBILE WLAN, TCP/IP");
            Assert.AreEqual(_terminalCreate.TerminalConfigDetailsCreate.ReceiptText,
                            "TKSYR for siw2\r\nTKSYR\r\nTKSYR TKSYR\r\n\r\n");

            _terminalCreate.TerminalConfigDetailsCreate.ReceiptText =
                "SYR-AUTO Line1\r\nSYR-AUTO Line2\r\nSYR-AUTO Line3\r\nSYR-AUTO Line4\r\nSYR-AUTO Line5";

            _terminalCreate.TerminalConfigDetailsCreate.Functionbits.Booking.Click();

            _terminalCreate.TerminalConfigDetailsCreate.SaveButton.Click();

            _terminalMenu.Terminal.Click();

            _terminalView.Base.BaseDataTab.Click();
            Assert.AreEqual(_terminalView.Base.Status, "Aktiviert - Aktiviert");
            Assert.AreEqual(_terminalView.Base.Infotext, "SYR AUTO Selenium Infotext");
            Assert.AreEqual(_terminalView.Base.ArticleName, "xentissimo MOBILE WLAN, TCP/IP");
            Assert.AreEqual(_terminalView.Base.TerminalType, "xentissimo");
            Assert.AreEqual(_terminalView.Base.ReferenceSystem, "EP2");
            Assert.AreEqual(_terminalView.Base.NetType, "TCP/IP ep2 (DNS) (TCPIPEP2)");
            Assert.AreEqual(_terminalView.Base.CreateDate, "");
            Assert.AreEqual(_terminalView.Base.ServiceCenter, "SIX Payment Services Service Center ep2");
            Assert.AreEqual(_terminalView.Base.Pms, "SIX Payment Services PMS ep2");

            _terminalView.Article.ArticleDataTab.Click();

            _terminalView.Parameter.ParameterDataTab.Click();

            //var custId = _terminalView.TerminalId;
            //Assert.AreEqual("SYR Sele Kunde A", _terminalView.TerminalId;
            //check/read TerminalId

            _recentElements.MostRecent.Click();

            //Assert.AreEqual(custId, _terminalView.CustomerNumber);
        }
    }
}