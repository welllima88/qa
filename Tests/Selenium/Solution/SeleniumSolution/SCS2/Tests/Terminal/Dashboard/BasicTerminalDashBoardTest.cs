using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Terminal.Dashboard
{
    [TestClass]
    public class BasicTerminalDashBoardTest
    {
        private static TerminalCreate _terminalCreate;
        private static TerminalView _terminalView;
        private static IWebDriver _driver;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static FormAlert _formAlert;
        private static TerminalMenu _terminalMenu;
        private static CustomerMenu _customerMenu;
        private long _dt;
        private List<string> _formAlerts;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login
            _terminalCreate = new TerminalCreate(_driver);
            _terminalView = new TerminalView(_driver);
            _recentElements = new RecentElements(_driver);
            _navigationBar = new NavigationBar(_driver);

            _formAlert = new FormAlert(_driver);
            _terminalMenu = new TerminalMenu(_driver);
            _customerMenu = new CustomerMenu(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CUSTOMERID=85036";
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
        public void CreateTerminalAndCancelTests()
        {
            CreateTerminalAndCancel();
            CreateTerminalWithIncompleteDataFailed();
        }

        [TestMethod]
        public void CreateTerminalAndCancel()
        {
            throw new NotImplementedException();
            _customerMenu.TerminalCreate.Click();

            Assert.AreEqual("Lobby",
                            _driver.FindElement(By.XPath("//span[@id='ctl00_bodyContentPlaceHolder_lblTitle']/h1")).Text);
        }

        [TestMethod]
        public void CreateTerminalWithIncompleteDataFailed()
        {
            _customerMenu.TerminalCreate.Click();

            _formAlerts = _formAlert.FormAlertList;
            Assert.IsTrue(_formAlerts.Count == 7);
            Assert.IsTrue(_formAlerts.Contains("Kundenname: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Mandant: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Strasse / Nr: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("PLZ: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Ort: Dies ist ein Pflichtfeld!"));
            Assert.IsTrue(_formAlerts.Contains("Land: Dies ist ein Pflichtfeld!"));
        }

        [TestMethod]
        public void CreateTerminalMinimalAndSave()
        {
            _customerMenu.TerminalCreate.Click();
            _terminalCreate.TerminalChooser.TerminalType = "xentissimo";
            _terminalCreate.TerminalChooser.TerminalSubType = "mobile";
            _terminalCreate.TerminalChooser.NetType = "WLAN";
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

            _terminalCreate.TerminalChooser.TerminalType = "xentissimo";
            _terminalCreate.TerminalChooser.TerminalSubType = "mobile";
            _terminalCreate.TerminalChooser.NetType = "WLAN";
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