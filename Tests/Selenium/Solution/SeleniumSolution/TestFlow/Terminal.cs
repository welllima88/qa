using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.Helper;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Massmuation;
using Six.Scs.Test.View.Terminal.Dashboard;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Builder;
using Six.Scs.Test.Workflow.Helper;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test
{
    public static class Terminal
    {
        public static Model.ValueObjects.Terminal Create(Model.ValueObjects.Location location,
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

        public static IEnumerable<Model.ValueObjects.Terminal> Duplicate(
            Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            var terminalDuplicate = TerminalDuplicate.Create();
            Workflow.Terminal.Duplicate(terminalDuplicate);

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

        private static IEnumerable<Model.ValueObjects.Terminal> CreateTerminalObjectsFromIds(
            IEnumerable<string> terminalList)
        {
            var terminalObjects = new List<Model.ValueObjects.Terminal>(terminalList.Count());
            terminalObjects.AddRange(
                terminalList.Select(terminalId => new Model.ValueObjects.Terminal {Id = terminalId}));
            return terminalObjects;
        }

        public static void Open(Model.ValueObjects.Terminal terminal)
        {
            Search.TerminalCanBeFoundById(terminal.Id);
            PortletViewBase.AllHasBeenLoaded();
        }

        public static void Quit(Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            var info = Workflow.Terminal.Quit();
            const int number = 5;
            var tries = new Try(number);

            while (!TerminalInfo.Cancelled.Displayed && tries.Again())
            {
                TestDirector.Refresh();
            }
            if (tries.TooOften())
            {
                Assert.Fail("Terminal: {0} is still not quit after {1} refresh", terminal.Id, number);
            }
            Verify.With(new Action[]
            {
                () => StringAssert.Contains("Gekündigt", TerminalInfo.Status),
                () => StringAssert.Contains("Gekündigt", BusinessViewpoint.Status),
                () => StringAssert.Contains(info, BusinessViewpoint.Status)
            }).Check();
        }

        public static void Assign(Model.ValueObjects.Mpd mpd, Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            Workflow.Terminal.Assign(mpd);
            PortletViewBase.AllHasBeenLoaded();
            PortletViewBase.OpenTree(TechnicalView.EcrLocator);
            StringAssert.Contains(mpd.Id, TechnicalView.PrimaryMpd);
            StringAssert.Contains(mpd.Id, TechnicalView.SecondaryMpd);
        }

        public static void Replace(Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            var replace = TerminalReplace.Yoximo();
            Workflow.Terminal.Replace(replace);
            Assert.AreEqual(replace.Article, BusinessViewpoint.TerminalType);
        }

        public static void ArticleChange(Model.ValueObjects.Terminal terminal, IPerform articleChangePerfomer)
        {
            Open(terminal);

            articleChangePerfomer.Do();
            articleChangePerfomer.Check();
        }

        public static void Move(Model.ValueObjects.Terminal terminal,
            Model.ValueObjects.Location location)
        {
            Open(terminal);
            Workflow.Terminal.Move(location);
            Assert.AreEqual(location.Ep2MerchantId, LocationInfo.Ep2Id);
        }

        public static void Retour(Model.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            Workflow.Terminal.Retour();
            NavigationBar.Lobby.Click();
            LobbyMenu.TerminalReturnShipping.Click();

            // Assert.That(RetourTable, Has.Member(terminal));
        }
    }
}