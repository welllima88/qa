using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.Helper;
using Six.Scs.Test.Model.ValueObjects;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Massmuation;
using Six.Scs.Test.View.Terminal.Dashboard;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Builder;
using Six.Test.Selenium.Helper;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test
{
    public static class Terminal
    {
        public static Test.Model.ValueObjects.Terminal Create(Test.Model.ValueObjects.Location location,
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

        public static IEnumerable<Test.Model.ValueObjects.Terminal> Duplicate(
            Test.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            TerminalDuplicate terminalDuplicate = Test.Model.Factory.TerminalDuplicate.Create();
            Test.Workflow.Terminal.Duplicate(terminalDuplicate);

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

        private static IEnumerable<Test.Model.ValueObjects.Terminal> CreateTerminalObjectsFromIds(
            IEnumerable<string> terminalList)
        {
            var terminalObjects = new List<Test.Model.ValueObjects.Terminal>(terminalList.Count());
            terminalObjects.AddRange(
                terminalList.Select(terminalId => new Test.Model.ValueObjects.Terminal {Id = terminalId}));
            return terminalObjects;
        }

        public static void Open(Test.Model.ValueObjects.Terminal terminal)
        {
            Search.TerminalCanBeFoundById(terminal.Id);
            PortletViewBase.AllHasBeenLoaded();
        }

        public static void Quit(Test.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            string info = Test.Workflow.Terminal.Quit();
            StringAssert.Contains("Gekündigt", TerminalInfo.Status);
            Assert.IsTrue(TerminalInfo.Cancelled.Displayed);
            StringAssert.Contains("Gekündigt", BusinessViewpoint.Status);
            StringAssert.Contains(info, BusinessViewpoint.Status);
        }

        public static void Assign(Test.Model.ValueObjects.Mpd mpd, Test.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            Test.Workflow.Terminal.Assign(mpd);
            PortletViewBase.AllHasBeenLoaded();
            PortletViewBase.OpenTree(TechnicalView.EcrLocator);
            StringAssert.Contains(mpd.Id, TechnicalView.PrimaryMpd);
            StringAssert.Contains(mpd.Id, TechnicalView.SecondaryMpd);
        }

        public static void Replace(Test.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            TerminalReplace replace = Test.Model.Factory.TerminalReplace.Yoximo();
            Test.Workflow.Terminal.Replace(replace);
            Assert.AreEqual(replace.Article, BusinessViewpoint.TerminalType);
        }

        public static void ArticleChange(Test.Model.ValueObjects.Terminal terminal, IPerform articleChangePerfomer)
        {
            Open(terminal);

            articleChangePerfomer.Do();
            articleChangePerfomer.Check();
        }

        public static void Move(Test.Model.ValueObjects.Terminal terminal,
            Test.Model.ValueObjects.Location location)
        {
            Open(terminal);
            Test.Workflow.Terminal.Move(location);
            Assert.AreEqual(location.Ep2MerchantId, LocationInfo.Ep2Id);
        }

        public static void Retour(Test.Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            Test.Workflow.Terminal.Retour();
            NavigationBar.Lobby.Click();
            LobbyMenu.TerminalReturnShipping.Click();

            // Assert.That(RetourTable, Has.Member(terminal));
        }
    }
}