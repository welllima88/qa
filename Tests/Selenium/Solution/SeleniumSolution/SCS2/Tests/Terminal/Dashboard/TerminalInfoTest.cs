using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.Dashboard
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
            StringAssert.Matches(TerminalInfo.Article.Text, new Regex(@"\w+"));
        }

        [TestMethod]
        public void TerminalId()
        {
            StringAssert.Matches(TerminalInfo.TerminalId.Text, new Regex(@"\d+"));
        }

        [TestMethod]
        public void ExternTerminalId()
        {
            StringAssert.Matches(TerminalInfo.ExternTerminalId.Text, new Regex(@"\w+"));
        }
    }
}