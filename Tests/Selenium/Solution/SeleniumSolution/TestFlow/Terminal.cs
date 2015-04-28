using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.Helper;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Application.Model.ValueObjects;
using Six.Scs.QA.Application.View.Common;
using Six.Scs.QA.Application.View.Common.Menu;
using Six.Scs.QA.Application.View.Massmuation;
using Six.Scs.QA.Application.View.Terminal.Dashboard;
using Six.Scs.QA.Application.View.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Application.Workflow.Builder;
using Six.Scs.QA.Testlogic.Helper;

namespace Six.Scs.QA.Testlogic
{
    public static class Terminal
    {
        public static Application.Model.ValueObjects.Terminal Create(Application.Model.ValueObjects.Location location,
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

        public static IEnumerable<Application.Model.ValueObjects.Terminal> Duplicate(
            Application.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            TerminalDuplicate terminalDuplicate = Application.Model.Factory.TerminalDuplicate.Create();
            Application.Workflow.Terminal.Duplicate(terminalDuplicate);

            TerminalValidation.ExecuteButton.Click();

            var tries = new Try(33);

            while (!Progress.HasFinished() && tries.Again())
            {
                TestDirector.Refresh();
            }
            if (tries.TooOften())
            {
                Assert.Fail("Batch has not been processed probably due to Job Control error. BatchId:{0} JobId:{1}",
                    Progress.BatchId, Progress.JobId);
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

        private static IEnumerable<Application.Model.ValueObjects.Terminal> CreateTerminalObjectsFromIds(
            IEnumerable<string> terminalList)
        {
            var terminalObjects = new List<Application.Model.ValueObjects.Terminal>(terminalList.Count());
            terminalObjects.AddRange(
                terminalList.Select(terminalId => new Application.Model.ValueObjects.Terminal {Id = terminalId}));
            return terminalObjects;
        }

        public static void Open(Application.Model.ValueObjects.Terminal terminal)
        {
            Search.TerminalCanBeFoundById(terminal.Id);
            PortletViewBase.AllHasBeenLoaded();
        }

        public static void Quit(Application.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            string info = Application.Workflow.Terminal.Quit();
            StringAssert.Contains("Gekündigt", TerminalInfo.Status);
            Assert.IsTrue(TerminalInfo.Cancelled.Displayed);
            StringAssert.Contains("Gekündigt", BusinessViewpoint.Status);
            StringAssert.Contains(info, BusinessViewpoint.Status);
        }

        public static void Assign(Application.Model.ValueObjects.Mpd mpd, Application.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            Application.Workflow.Terminal.Assign(mpd);
            PortletViewBase.AllHasBeenLoaded();
            PortletViewBase.OpenTree(TechnicalView.EcrLocator);
            StringAssert.Contains(mpd.Id, TechnicalView.PrimaryMpd);
            StringAssert.Contains(mpd.Id, TechnicalView.SecondaryMpd);
        }

        public static void Replace(Application.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            TerminalReplace replace = Application.Model.Factory.TerminalReplace.Yoximo();
            Application.Workflow.Terminal.Replace(replace);
            Assert.AreEqual(replace.Article, BusinessViewpoint.TerminalType);
        }

        public static void ArticleChange(Application.Model.ValueObjects.Terminal terminal, IPerform articleChangePerfomer)
        {
            Open(terminal);

            articleChangePerfomer.Do();
            articleChangePerfomer.Check();
        }

        public static void Move(Application.Model.ValueObjects.Terminal terminal,
            Application.Model.ValueObjects.Location location)
        {
            Open(terminal);
            Application.Workflow.Terminal.Move(location);
            Assert.AreEqual(location.Ep2MerchantId, LocationInfo.Ep2Id);
        }

        public static void Retour(Application.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            Application.Workflow.Terminal.Retour();
            NavigationBar.Lobby.Click();
            LobbyMenu.TerminalReturnShipping.Click();

            // Assert.That(RetourTable, Has.Member(terminal));
        }
    }
}