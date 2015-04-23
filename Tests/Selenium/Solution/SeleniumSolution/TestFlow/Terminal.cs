using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.Helper;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Model.ValueObjects;
using Six.Scs.QA.Selenium.View.Common;
using Six.Scs.QA.Selenium.View.Common.Menu;
using Six.Scs.QA.Selenium.View.Massmuation;
using Six.Scs.QA.Selenium.View.Terminal.Dashboard;
using Six.Scs.QA.Selenium.View.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Selenium.Workflow.Builder;
using Six.Scs.QA.Testlogic.Helper;

namespace Six.Scs.QA.Testlogic
{
    public static class Terminal
    {
        public static Selenium.Model.ValueObjects.Terminal Create(Selenium.Model.ValueObjects.Location location,
            TerminalBuilder terminalBuilder)
        {
            Location.Open(location);
            LocationMenu.TerminalCreate.Click();

            terminalBuilder.Create();
            terminalBuilder.Check();

            Assert.AreEqual(terminalBuilder.Terminal.Type, BusinessViewpoint.TerminalType);
            Assert.AreEqual(location.CompanyName, LocationInfo.CompanyName);
            return terminalBuilder.Terminal;
        }

        public static IEnumerable<Selenium.Model.ValueObjects.Terminal> Duplicate(Selenium.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            TerminalDuplicate terminalDuplicate = Selenium.Model.Factory.TerminalDuplicate.Create();
            Selenium.Workflow.Terminal.Duplicate(terminalDuplicate);

            TerminalValidation.ExecuteButton.Click();

            var tries = new Try(33);

            while (!Progress.HasFinished() && tries.Again())
            {
                TestDirector.Refresh();
            }
            if (tries.TooOften())
            {
                Assert.Fail("Batch has not been processed probably due to Job Control error. BatchId:{0} JobId:{1}",
                    Progress.JobId, Progress.BatchId);
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

        private static IEnumerable<Selenium.Model.ValueObjects.Terminal> CreateTerminalObjectsFromIds(
            IEnumerable<string> terminalList)
        {
            var terminalObjects = new List<Selenium.Model.ValueObjects.Terminal>(terminalList.Count());
            terminalObjects.AddRange(
                terminalList.Select(terminalId => new Selenium.Model.ValueObjects.Terminal {Id = terminalId}));
            return terminalObjects;
        }

        public static void Open(Selenium.Model.ValueObjects.Terminal terminal)
        {
            Search.TerminalCanBeFoundById(terminal.Id);
            PortletViewBase.AllHasBeenLoaded();
        }

        public static void Quit(Selenium.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            string info = Selenium.Workflow.Terminal.Quit();
            StringAssert.Contains("Gekündigt", TerminalInfo.Status);
            Assert.IsTrue(TerminalInfo.Cancelled.Displayed);
            StringAssert.Contains("Gekündigt", BusinessViewpoint.Status);
            StringAssert.Contains(info, BusinessViewpoint.Status);
        }

        public static void Assign(Selenium.Model.ValueObjects.Mpd mpd, Selenium.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            Selenium.Workflow.Terminal.Assign(mpd);
            PortletViewBase.AllHasBeenLoaded();
            PortletViewBase.OpenTree(TechnicalView.EcrLocator);
            StringAssert.Contains(mpd.Id, TechnicalView.PrimaryMpd);
            StringAssert.Contains(mpd.Id, TechnicalView.SecondaryMpd);
        }

        public static void Replace(Selenium.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            TerminalReplace replace = Selenium.Model.Factory.TerminalReplace.Yoximo();
            Selenium.Workflow.Terminal.Replace(replace);
            Assert.AreEqual(replace.Article, BusinessViewpoint.TerminalType);
        }

        public static void ArticleChange(Selenium.Model.ValueObjects.Terminal terminal, IPerform articleChangePerfomer)
        {
            Open(terminal);

            articleChangePerfomer.Do();
            articleChangePerfomer.Check();
        }

        public static void Move(Selenium.Model.ValueObjects.Terminal terminal, Selenium.Model.ValueObjects.Location location)
        {
            Open(terminal);
            Selenium.Workflow.Terminal.Move(location);
            Assert.AreEqual(location.Ep2MerchantId, LocationInfo.Ep2Id);
        }

        public static void Retour(Selenium.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            Selenium.Workflow.Terminal.Retour();
            NavigationBar.Lobby.Click();
            LobbyMenu.TerminalReturnShipping.Click();

            // Assert.That(RetourTable, Has.Member(terminal));
        }
    }
}