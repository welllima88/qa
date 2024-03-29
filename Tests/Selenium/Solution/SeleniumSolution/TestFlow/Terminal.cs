using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.Factory;
using Six.Scs.Test.Helper;
using Six.Scs.Test.Model;
using Six.Scs.Test.UI.Common;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Location;
using Six.Scs.Test.UI.Massmuation;
using Six.Scs.Test.UI.Terminal;
using Six.Scs.Test.UI.Terminal.Dashboard;
using Six.Scs.Test.UI.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Builder;
using Six.Scs.Test.Workflow.Helper;
using Six.Test.Selenium.WebDriver;
using TerminalDuplicate = Six.Scs.Test.Factory.TerminalDuplicate;
using TerminalReplace = Six.Scs.Test.Factory.TerminalReplace;

namespace Six.Scs.Test
{
    public static class Terminal
    {
        public static Model.Terminal Create(Model.Location location,
                                            TerminalBuilder terminalBuilder)
        {
            Location.Open(location);
            View.TerminalCreate.Click();

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
            PortletBase.AllHasBeenLoaded();
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
            PortletBase.AllHasBeenLoaded();
            PortletBase.OpenTree(Technical.EcrLocator);
            StringAssert.Contains(mpd.Id, Technical.PrimaryMpd);
            StringAssert.Contains(mpd.Id, Technical.SecondaryMpd);
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

        public static void ChangeReceiptHeader(Model.Terminal terminal)
        {
            Open(terminal);
            var a = new ReceiptHeader
            {
                Line1 = "Line 1 SYR",
                Line2 = "Line 2 SYR",
                Line3 = "Line 3 SYR"
            };
            Workflow.Terminal.ChangeReceipt(a);

            Assert.That(BusinessViewpoint.ReceiptHeader.Text, Is.EqualTo(a));
        }

        public static void ResetReceiptHeader(Model.Terminal terminal, Model.Location location)
        {
            Open(terminal);
            var a = new ReceiptHeader
            {
                Line1 = location.CompanyName,
                Line2 = location.Adress.StreetNo,
                Line3 = location.Adress.Zip + " " + location.Adress.City
            };
            Workflow.Terminal.Reset();

            Assert.That(BusinessViewpoint.ReceiptHeader.Text, Is.EqualTo(a));
        }
    }
}