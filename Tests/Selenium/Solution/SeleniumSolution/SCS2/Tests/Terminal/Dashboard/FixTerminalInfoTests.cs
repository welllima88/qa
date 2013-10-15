using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.Dashboard
{
    [TestClass]
    public class FixTerminalInfoTests
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("/TerminalDashboard/?TerminalId=30381643");
        }

        [TestMethod]
        public void TerminalInfoCheck()
        {
            StringAssert.Matches(TerminalInfo.Article.Text, new Regex(@"\w+"));
            StringAssert.Matches(TerminalInfo.TerminalId.Text, new Regex(@"\d+"));
            StringAssert.Matches(TerminalInfo.ExternTerminalId.Text, new Regex(@"\w+"));
        }

        [TestMethod]
        public void LocationlInfoCheck()
        {
            StringAssert.Matches(LocationInfo.Adress.Text, new Regex(@"\w+"));
            StringAssert.Matches(LocationInfo.Ep2Id.Text, new Regex(@"\w{8}\d{7}"));
            StringAssert.Matches(LocationInfo.Name.Text, new Regex(@"\w+"));
        }

        [TestMethod]
        public void CustomerInfoCheck()
        {
            StringAssert.Matches(CustomerInfo.Adress.Text, new Regex(@"\w+"));
            StringAssert.Matches(CustomerInfo.Id.Text, new Regex(@"\d+"));
            StringAssert.Matches(CustomerInfo.Name.Text, new Regex(@"\w+"));
            StringAssert.Matches(CustomerInfo.Info.Text, new Regex(@"\w+"));
        }
    }
}