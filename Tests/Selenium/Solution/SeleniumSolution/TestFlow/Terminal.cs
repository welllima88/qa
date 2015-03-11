using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Massmuation;
using Six.Scs.QA.Selenium.Terminal.Dashboard;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.TestData.ValueObjects;
using Six.Scs.QA.Testlogic.Helper;
using Six.Scs.QA.Workflow.Builder;

namespace Six.Scs.QA.Testlogic
{
    public static class Terminal
    {
        public static TestData.ValueObjects.Terminal Create(TestData.ValueObjects.Location location,
            TerminalBuilder terminalBuilder)
        {
            Location.Open(location);
            LocationMenu.TerminalCreate.Click();

            terminalBuilder.Create();
            terminalBuilder.Check();

            Assert.AreEqual(location.Contact.Language, BusinessViewpoint.TerminalLanguage);
            Assert.AreEqual(location.CompanyName, LocationInfo.CompanyName);
            return terminalBuilder.Terminal;
        }

        public static TestData.ValueObjects.Terminal Create(TestData.ValueObjects.Customer customer,
            TerminalBuilder terminalBuilder)
        {
            Customer.Open(customer);
            CustomerMenu.TerminalCreate.Click();

            terminalBuilder.Create();
            terminalBuilder.Check();

            // Assert.AreEqual(customer.Location.Contact.Language, BusinessViewpoint.TerminalLanguage);
            Assert.AreEqual(customer.CustomerNumber, CustomerInfo.Number);
            Assert.AreEqual(customer.CustomerName, CustomerInfo.Name);
            return terminalBuilder.Terminal;
        }

        public static IEnumerable<TestData.ValueObjects.Terminal> Duplicate(TestData.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            TerminalDuplicate terminalDuplicate = TestData.Factory.TerminalDuplicate.Create();
            Workflow.Terminal.Duplicate(terminalDuplicate);

            TerminalValidation.ExecuteButton.Click();

            var tries = new Try(20);

            while (!Progress.HasFinished() && tries.Again())
            {
                TestDirector.Refresh();
            }
            if (tries.TooOften())
            {
                Assert.Fail("has not been processed probably due to Job Control error");
            }
            Assert.That(Progress.Failed, Is.EqualTo("0"));

            // MassmutationProgress.DateTime;
            Assert.AreEqual(terminalDuplicate.NumberOfTerminals, Progress.TerminalList.Count().ToString());
            /*
            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpointPortlet.Status);
            Assert.AreEqual("xentissimo MOBILE WLAN, TCP/IP", BusinessViewpointPortlet.TerminalType);
            Assert.AreEqual("grau", BusinessViewpointPortlet.Color);
            Assert.AreEqual(_location.Contact.Language, BusinessViewpointPortlet.TerminalLanguage);

            Assert.AreEqual(_location.CompanyName, LocationInfo.CompanyName);
            */

            return CreateTerminalObjectsFromIds(Progress.TerminalList);
        }

        private static IEnumerable<TestData.ValueObjects.Terminal> CreateTerminalObjectsFromIds(
            IEnumerable<string> terminalList)
        {
            var terminalObjects = new List<TestData.ValueObjects.Terminal>(terminalList.Count());
            terminalObjects.AddRange(
                terminalList.Select(terminalId => new TestData.ValueObjects.Terminal {Id = terminalId}));
            return terminalObjects;
        }

        public static void Open(TestData.ValueObjects.Terminal terminal)
        {
            Search.TerminalCanBeFoundById(terminal.Id);
            PortletViewBase.AllHasBeenLoaded();
        }

        public static void Quit(TestData.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            string info = Workflow.Terminal.Quit();
            StringAssert.Contains("Gekündigt", TerminalInfo.Status);
            Assert.IsTrue(TerminalInfo.Cancelled.Displayed);
            StringAssert.Contains("Gekündigt", BusinessViewpoint.Status);
            StringAssert.Contains(info, BusinessViewpoint.Status);
        }

        public static void Assign(TestData.ValueObjects.Mpd mpd, TestData.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            Workflow.Terminal.Assign(mpd);
            PortletViewBase.AllHasBeenLoaded();
            PortletViewBase.OpenTree(TechnicalView.EcrLocator);
            StringAssert.Contains(mpd.Id, TechnicalView.PrimaryMpd);
            StringAssert.Contains(mpd.Id, TechnicalView.SecondaryMpd);
        }

        public static void Replace(TestData.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            TerminalReplace replace = TestData.Factory.TerminalReplace.Yoximo();
            Workflow.Terminal.Replace(replace);
            Assert.AreEqual(replace.Article, BusinessViewpoint.TerminalType);
        }

        public static void ArticleChange(TestData.ValueObjects.Terminal terminal, IPerform articleChangePerfomer)
        {
            Open(terminal);

            articleChangePerfomer.Do();
            articleChangePerfomer.Check();
        }

        public static void Move(TestData.ValueObjects.Terminal terminal, TestData.ValueObjects.Location location)
        {
            Open(terminal);
            Workflow.Terminal.Move(location);
            Assert.AreEqual(location.Ep2MerchantId, LocationInfo.Ep2Id);
        }

        public static void Retour(TestData.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            Workflow.Terminal.Retour();
            NavigationBar.Lobby.Click();
            LobbyMenu.TerminalReturnShipping.Click();

            // Assert.That(RetourTable, Has.Member(terminal));
        }
    }
}