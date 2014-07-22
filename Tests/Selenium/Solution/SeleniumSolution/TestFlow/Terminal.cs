using System.Collections.Generic;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Massmuation;
using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.Selenium.Terminal.Dashboard;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Terminal
    {
        public static TestData.ValueObjects.Terminal Create(LocationData location)
        {
            TestData.ValueObjects.Terminal terminal = TerminalFactory.Xentissimo();
            Location.Open(location);
            LocationMenu.TerminalCreate.Click();

            TerminalChooser.ArticleFilter = "xentissimo MOBILE WLAN, TCP/IP";
            TerminalChooser.Article = "xentissimo MOBILE WLAN, TCP/IP";
            TerminalConfigCreate.Infotext = "SYR Terminal AUTO" + Factory.GenerateTestId();
            TerminalConfigCreate.ContinueButton.Click();

            TerminalConfigDetailsCreate.InstallRemark = "Install SYR Auto" + Factory.GenerateTestId();
            TerminalConfigDetailsCreate.SaveButton.Click();

            TerminalMenu.Terminal.Click();
            terminal.Id = TerminalInfo.TerminalId;

            Lobby.OpenLatestElement();
            Assert.AreEqual(terminal, TerminalInfo.TerminalId);
            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpointPortlet.Status);
            Assert.AreEqual("xentissimo MOBILE WLAN, TCP/IP", BusinessViewpointPortlet.TerminalType);
            Assert.AreEqual("grau", BusinessViewpointPortlet.Color);
            Assert.AreEqual(location.Contact.Language,
                BusinessViewpointPortlet.TerminalLanguage);

            Assert.AreEqual(location.CompanyName, LocationInfo.CompanyName);
            return terminal;
        }

        public static TestData.ValueObjects.Terminal Create(TestData.ValueObjects.Customer customer)
        {
            TestData.ValueObjects.Terminal terminal = TerminalFactory.Yomani();
            Customer.Open(customer);
            CustomerMenu.TerminalCreate.Click();

            TerminalChooser.ArticleFilter = "1550";
            TerminalChooser.Article = "yomani AUTONOM, TCP/IP ep2 (DNS)";
            TerminalConfigCreate.Infotext = "SYR Terminal AUTO" + Factory.GenerateTestId();

            TerminalConfigCreate.ContinueButton.Click();
            TerminalConfigCreate.SaveButton.Click();

            Assert.IsTrue(BrandSelect.BrandTree().Displayed);
            TerminalMenu.Terminal.Click();
            terminal.Id = TerminalInfo.TerminalId;

            Lobby.OpenLatestElement();
            Assert.AreEqual(terminal.Id, TerminalInfo.TerminalId);
            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpointPortlet.Status);
            Assert.AreEqual("yomani AUTONOM, TCP/IP ep2 (DNS)", BusinessViewpointPortlet.TerminalType);
            Assert.AreEqual("weiss", BusinessViewpointPortlet.Color);

            Assert.AreEqual(customer.Location.Contact.Language,
                BusinessViewpointPortlet.TerminalLanguage);

            Assert.AreEqual(customer.CustomerNumber, CustomerInfo.Number);
            Assert.AreEqual(customer.CustomerName, CustomerInfo.Name);
            return terminal;
        }

        public static List<string> Duplicate(TestData.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            TerminalDuplicate terminalDuplicate = TerminalDuplicateDataFactory.Create();
            Workflow.Terminal.Duplicate(terminalDuplicate);

            TerminalMassValidation.ExecuteButton.Click();

            while (!MassmutationProgress.HasFinished())
            {
                TestDirector.Refresh();
            }
            Assert.AreEqual("0", MassmutationProgress.Failed);

            // MassmutationProgress.DateTime;
            Assert.AreEqual("CreateTerminals", MassmutationProgress.Type);
            Assert.AreEqual(terminalDuplicate.NumberOfTerminals, MassmutationProgress.TerminalList.Count);
            /*
            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpointPortlet.Status);
            Assert.AreEqual("xentissimo MOBILE WLAN, TCP/IP", BusinessViewpointPortlet.TerminalType);
            Assert.AreEqual("grau", BusinessViewpointPortlet.Color);
            Assert.AreEqual(_location.Contact.Language, BusinessViewpointPortlet.TerminalLanguage);

            Assert.AreEqual(_location.CompanyName, LocationInfo.CompanyName);
            */
            return MassmutationProgress.TerminalList;
        }

        public static void Open(TestData.ValueObjects.Terminal terminal)
        {
            Search.TerminalCanBeFoundById(terminal.Id);
        }

        public static void Check(TestData.ValueObjects.Terminal terminal)
        {
            // DB Check Terminal and Contracts?
        }
    }
}