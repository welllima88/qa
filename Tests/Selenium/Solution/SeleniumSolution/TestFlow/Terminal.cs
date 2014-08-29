using System.Collections.Generic;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Massmuation;
using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.Selenium.Terminal.Dashboard;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Testlogic
{
    public class Terminal
    {
        public static TestData.ValueObjects.Terminal Create(TestData.ValueObjects.Location location)
        {
            TestData.ValueObjects.Terminal terminal = TestData.Factory.Terminal.Xentissimo();
            Location.Open(location);
            LocationMenu.TerminalCreate.Click();

            ArticleChooser.ArticleFilter = "xentissimo MOBILE WLAN, TCP/IP";
            ArticleChooser.Article = "xentissimo MOBILE WLAN, TCP/IP";
            ConfigCreate.Infotext = "SYR Terminal AUTO" + Factory.GenerateTestId();
            ConfigCreate.ContinueButton.Click();

            ConfigDetailsCreate.InstallRemark = "Install SYR Auto" + Factory.GenerateTestId();
            ConfigDetailsCreate.SaveButton.Click();

            TerminalMenu.Terminal.Click();
            terminal.Id = TerminalInfo.TerminalId;

            Workflow.Lobby.OpenLatestElement();
            Assert.AreEqual(terminal.Id, TerminalInfo.TerminalId);
            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpoint.Status);
            Assert.AreEqual("xentissimo MOBILE WLAN, TCP/IP", BusinessViewpoint.TerminalType);
            Assert.AreEqual("grau", BusinessViewpoint.Color);
            Assert.AreEqual(location.Contact.Language,
                BusinessViewpoint.TerminalLanguage);

            Assert.AreEqual(location.CompanyName, LocationInfo.CompanyName);
            return terminal;
        }

        public static TestData.ValueObjects.Terminal Create(TestData.ValueObjects.Customer customer)
        {
            TestData.ValueObjects.Terminal terminal = TestData.Factory.Terminal.Yomani();
            Customer.Open(customer);
            CustomerMenu.TerminalCreate.Click();

            ArticleChooser.ArticleFilter = "1550";
            ArticleChooser.Article = "yomani AUTONOM, TCP/IP ep2 (DNS)";
            ConfigCreate.Infotext = "SYR Terminal AUTO" + Factory.GenerateTestId();

            ConfigCreate.ContinueButton.Click();
            ConfigCreate.SaveButton.Click();

            Assert.IsTrue(Selection.BrandTree().Displayed);
            TerminalMenu.Terminal.Click();
            terminal.Id = TerminalInfo.TerminalId;

            Workflow.Lobby.OpenLatestElement();
            Assert.AreEqual(terminal.Id, TerminalInfo.TerminalId);
            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpoint.Status);
            Assert.AreEqual("yomani AUTONOM, TCP/IP ep2 (DNS)", BusinessViewpoint.TerminalType);
            Assert.AreEqual("weiss", BusinessViewpoint.Color);

            Assert.AreEqual(customer.Location.Contact.Language,
                BusinessViewpoint.TerminalLanguage);

            Assert.AreEqual(customer.CustomerNumber, CustomerInfo.Number);
            Assert.AreEqual(customer.CustomerName, CustomerInfo.Name);
            return terminal;
        }

        public static List<string> Duplicate(TestData.ValueObjects.Terminal terminal)
        {
            Open(terminal);
            TestData.ValueObjects.TerminalDuplicate terminalDuplicate = TestData.Factory.TerminalDuplicate.Create();
            Workflow.Terminal.Duplicate(terminalDuplicate);

            TerminalValidation.ExecuteButton.Click();

            while (!Progress.HasFinished())
            {
                TestDirector.Refresh();
            }
            Assert.AreEqual("0", Progress.Failed);

            // MassmutationProgress.DateTime;
            Assert.AreEqual("CreateTerminals", Progress.Type);
            Assert.AreEqual(terminalDuplicate.NumberOfTerminals, Progress.TerminalList.Count.ToString());
            /*
            Assert.AreEqual(_terminalIdLocation, TerminalInfo.TerminalId);
            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpointPortlet.Status);
            Assert.AreEqual("xentissimo MOBILE WLAN, TCP/IP", BusinessViewpointPortlet.TerminalType);
            Assert.AreEqual("grau", BusinessViewpointPortlet.Color);
            Assert.AreEqual(_location.Contact.Language, BusinessViewpointPortlet.TerminalLanguage);

            Assert.AreEqual(_location.CompanyName, LocationInfo.CompanyName);
            */
            return Progress.TerminalList;
        }

        public static void Open(TestData.ValueObjects.Terminal terminal)
        {
            Search.TerminalCanBeFoundById(terminal.Id);
        }

        public static void Check(TestData.ValueObjects.Terminal terminal)
        {
            // DB Check Terminal and Contracts?
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
    }
}