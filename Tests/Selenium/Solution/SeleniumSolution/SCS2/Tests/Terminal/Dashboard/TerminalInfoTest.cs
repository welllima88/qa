using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.Tests.Terminal.Dashboard
{
    [TestClass]
    public class TerminalInfoTest
    {
        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
        }

        [TestMethod]
        public void ArticleName()
        {
            StringAssert.Matches(TerminalInfo.Article, new Regex(@"\w+"));
        }

        [TestMethod]
        public void TerminalId()
        {
            StringAssert.Matches(TerminalInfo.TerminalId, new Regex(@"\d+"));
        }

        [TestMethod]
        public void ExternTerminalId()
        {
            StringAssert.Matches(TerminalInfo.ExternTerminalId, new Regex(@"\w+"));
        }
    }
}