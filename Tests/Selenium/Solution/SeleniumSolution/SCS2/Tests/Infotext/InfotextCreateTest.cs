using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common.Infotext;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Terminal.Dashboard;
using Six.Scs.Tests.Selenium.Extension.WebDriver;
using Six.Scs.Tests.Selenium.Extension.Worklow;

namespace Six.Scs.Tests.Selenium.Tests.Infotext
{
    [TestClass]
    public class InfotextCreateTest
    {
        [TestMethod]
        public void CreateInfotextToCustomer()
        {
            TestDirector.Navigate("Customer/?CUSTOMERID=401152");
            CustomerMenu.Infotexts.Click();
            InfoTextListView.CreateButton.Click();
            InfoTextService.Create("Customer");
        }

        [TestMethod]
        public void CreateInfotextToLocation()
        {
            TestDirector.Navigate("Location?LocationId=d94bf6cc-38ca-42c4-82d5-1d7c0414ab94");
            LocationMenu.Infotexts.Click();
            InfoTextListView.CreateButton.Click();
            InfoTextService.Create("Location");
        }

        [TestMethod]
        public void CreateInfotextToTerminal()
        {
            TestDirector.Navigate("TerminalDashboard?TerminalId=24290006");

            TerminalTextsPortlet.CreateInfotext.Click();

            InfoTextService.Create("Terminal");
        }
    }
}