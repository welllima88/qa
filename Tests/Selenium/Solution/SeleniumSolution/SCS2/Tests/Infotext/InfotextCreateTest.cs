using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Infotext;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Infotext
{
    [TestClass]
    public class InfotextCreateTest
    {
        [TestMethod]
        public void CreateInfotextToCustomer()
        {
            TestDirector.Navigate("Customer/?CUSTOMERID=99150");
            CustomerMenu.CreateInfotext.Click();

            DoCreateInfotext("Customer");
        }

        [TestMethod]
        public void CreateInfotextToLocation()
        {
            TestDirector.Navigate("Customer/?CUSTOMERID=99150");

            LocationMenu.CreateInfotext.Click();
            DoCreateInfotext("Location");
        }

        [TestMethod]
        public void CreateInfotextToTerminal()
        {
            TerminalTextsPortlet.CreateInfotext.Click();

            DoCreateInfotext("Terminal");
        }

        public static void DoCreateInfotext(string infotext)
        {
            InfoTextCreate.Text = string.Format("SYR {0} Infotext {1}", infotext, TestLauncher.GenerateTestId());
            InfoTextCreate.SaveButton.Click();
        }
    }
}