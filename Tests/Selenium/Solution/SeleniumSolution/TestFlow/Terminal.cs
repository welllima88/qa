using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.Factory;
using Six.Scs.Test.Helper;
using Six.Scs.Test.View.Common;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Massmuation;
using Six.Scs.Test.View.Terminal;
using Six.Scs.Test.View.Terminal.Dashboard;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Builder;
using Six.Scs.Test.Workflow.Helper;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test
{
    public static class Terminal
    {
        public static Model.Terminal Create(Model.Location location,
            TerminalBuilder terminalBuilder)
        {
            Location.Open(location);
            View.Location.View.TerminalCreate.Click();

            terminalBuilder.Create();
            terminalBuilder.Check();

            Assert.AreEqual(terminalBuilder.Terminal.Type, BusinessViewpoint.TerminalType);
            Assert.AreEqual(location.CompanyName, LocationInfo.CompanyName);
            return terminalBuilder.Terminal;
        }

        public static IEnumerable<Model.Terminal> Duplicate(
            Model.Terminal terminal)
        {
            Open(terminal);
            var terminalDuplicate = TerminalDuplicate.Create();
            Workflow.Terminal.Duplicate(terminalDuplicate);

            TerminalValidation.ExecuteButton.Click();

            Batch.WaitForBatchHasFinished();

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

        private static IEnumerable<Model.Terminal> CreateTerminalObjectsFromIds(
            IEnumerable<string> terminalList)
        {
            var list = terminalList.ToList();
            var terminalObjects = new List<Model.Terminal>(list.Count());
            terminalObjects.AddRange(
                list.ToList().Select(terminalId => new Model.Terminal {Id = terminalId}));
            return terminalObjects;
        }

        public static void Open(Model.Terminal terminal)
        {
            Search.TerminalCanBeFoundById(terminal.Id);
            PortletViewBase.AllHasBeenLoaded();
        }

        public static void Quit(Model.Terminal terminal)
        {
            Open(terminal);
            var info = Workflow.Terminal.Quit(Base.GenerateTestId());
            const int number = 5;
            var tries = new Try(number);

            while (!TerminalInfo.Canceled && tries.Again())
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

        public static void Assign(Model.Mpd mpd, Model.Terminal terminal)
        {
            Open(terminal);
            Workflow.Terminal.Assign(mpd);
            PortletViewBase.AllHasBeenLoaded();
            PortletViewBase.OpenTree(TechnicalView.EcrLocator);
            StringAssert.Contains(mpd.Id, TechnicalView.PrimaryMpd);
            StringAssert.Contains(mpd.Id, TechnicalView.SecondaryMpd);
        }

        public static void Replace(Model.Terminal terminal)
        {
            Open(terminal);
            var replace = TerminalReplace.Yoximo();
            Workflow.Terminal.Replace(replace);
            Assert.AreEqual(replace.Article, BusinessViewpoint.TerminalType);
        }

        public static void ArticleChange(Model.Terminal terminal, IPerform articleChangePerfomer)
        {
            Open(terminal);

            articleChangePerfomer.Do();
            articleChangePerfomer.Check();
        }

        public static void Move(Model.Terminal terminal,
            Model.Location location)
        {
            Open(terminal);
            Workflow.Terminal.Move(location);
            Assert.AreEqual(location.Ep2MerchantId, LocationInfo.Ep2Id);
        }

        public static void Return(Model.Terminal terminal)
        {
            Open(terminal);
            Workflow.Terminal.Return();
            NavigationBar.Lobby.Click();
            LobbyMenu.TerminalReturnShipping.Click();

            Assert.That(Returns.TerminalLink(terminal).Displayed);
            Assert.That(Returns.Deactivate(terminal).Displayed);
            Assert.That(Returns.Cancel(terminal).Displayed);
        }
    }
}