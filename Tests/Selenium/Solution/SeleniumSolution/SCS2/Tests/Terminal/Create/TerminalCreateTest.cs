﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.Create
{
    [TestClass]
    public class TerminalCreateTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CUSTOMERID=85036");
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
            CustomerMenu.TerminalCreate.Click();

            Assert.AreEqual(7, FormAlert.FormAlertList.Count);
            CollectionAssert.Contains(FormAlert.FormAlertList, "Kundenname: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Firmenname: Zu kurze Eingabe! Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Mandant: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Strasse / Nr: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "PLZ: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Ort: Dies ist ein Pflichtfeld!");
            CollectionAssert.Contains(FormAlert.FormAlertList, "Land: Dies ist ein Pflichtfeld!");
        }

        [TestMethod]
        public void CreateTerminalMinimalAndSave()
        {
            CustomerMenu.TerminalCreate.Click();

            TerminalChooser.Article = "xentissimo MOBILE WLAN, TCP/IP";

            TerminalConfigCreate.Infotext = "SYR AUTO Selenium Infotext";
            TerminalConfigCreate.Status = "Aktiviert";
            TerminalConfigCreate.SubStatus = "Aktiviert";
            TerminalConfigCreate.ServiceCenter = "SIX Payment Services Service Center ep2";
            TerminalConfigCreate.Pms = "SIX Payment Services PMS ep2";

            Assert.AreEqual(TerminalConfigCreate.TerminalType, "xentissimo");
            Assert.AreEqual(TerminalConfigCreate.Protocol, "EP2");
            Assert.AreEqual(TerminalConfigCreate.NetType, "TCP/IP ep2 (DNS) (TCPIPEP2)");

            TerminalConfigCreate.SaveButton.Click();
            TerminalMenu.Terminal.Click();

            //var custId = TerminalView.TerminalId;
            //Assert.AreEqual("SYR Sele Kunde A", TerminalView.TerminalId;
            //check/read TerminalId

            RecentElements.MostRecent.Click();

            //Assert.AreEqual(custId, TerminalView.CustomerNumber);
        }

        [TestMethod]
        public void CreateTerminalAndSave()
        {
            CustomerMenu.TerminalCreate.Click();

            TerminalChooser.Article = "xentissimo MOBILE WLAN, TCP/IP";

            TerminalConfigCreate.Infotext = "SYR AUTO Selenium Infotext";
            TerminalConfigCreate.Status = "Aktiviert";
            TerminalConfigCreate.SubStatus = "Aktiviert";
            TerminalConfigCreate.ServiceCenter = "SIX Payment Services Service Center ep2";
            TerminalConfigCreate.Pms = "SIX Payment Services PMS ep2";

            Assert.AreEqual(TerminalConfigCreate.TerminalType, "xentissimo");
            Assert.AreEqual(TerminalConfigCreate.Protocol, "EP2");
            Assert.AreEqual(TerminalConfigCreate.NetType, "TCP/IP ep2 (DNS) (TCPIPEP2)");

            TerminalConfigCreate.ContinueButton.Click();

            Assert.AreEqual(TerminalConfigDetailsCreate.Article, "xentissimo MOBILE WLAN, TCP/IP");
            Assert.AreEqual(TerminalConfigDetailsCreate.ReceiptText,
                            "TKSYR for siw2\r\nTKSYR\r\nTKSYR TKSYR\r\n\r\n");

            TerminalConfigDetailsCreate.ReceiptText =
                "SYR-AUTO Line1\r\nSYR-AUTO Line2\r\nSYR-AUTO Line3\r\nSYR-AUTO Line4\r\nSYR-AUTO Line5";

            TerminalCreate.TerminalConfigDetailsCreate.Functionbits.Booking.Click();

            TerminalCreate.TerminalConfigDetailsCreate.SaveButton.Click();

            TerminalMenu.Terminal.Click();

            TerminalView.Base.BaseDataTab.Click();
            Assert.AreEqual(TerminalView.Base.Status, "Aktiviert - Aktiviert");
            Assert.AreEqual(TerminalView.Base.Infotext, "SYR AUTO Selenium Infotext");
            Assert.AreEqual(TerminalView.Base.ArticleName, "xentissimo MOBILE WLAN, TCP/IP");
            Assert.AreEqual(TerminalView.Base.TerminalType, "xentissimo");
            Assert.AreEqual(TerminalView.Base.ReferenceSystem, "EP2");
            Assert.AreEqual(TerminalView.Base.NetType, "TCP/IP ep2 (DNS) (TCPIPEP2)");
            Assert.AreEqual(TerminalView.Base.CreateDate, "");
            Assert.AreEqual(TerminalView.Base.ServiceCenter, "SIX Payment Services Service Center ep2");
            Assert.AreEqual(TerminalView.Base.Pms, "SIX Payment Services PMS ep2");

            TerminalView.Article.ArticleDataTab.Click();

            TerminalView.Parameter.ParameterDataTab.Click();

            //var custId = TerminalView.TerminalId;
            //Assert.AreEqual("SYR Sele Kunde A", TerminalView.TerminalId;
            //check/read TerminalId

            RecentElements.MostRecent.Click();

            //Assert.AreEqual(custId, TerminalView.CustomerNumber);
        }
    }
}