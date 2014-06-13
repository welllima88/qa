using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common.Infotext;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Terminal.Dashboard;
using SIX.SCS.Tests.Selenium.Extension.Worklow;

namespace SIX.SCS.Tests.Selenium.Tests.Infotext
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