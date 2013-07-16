using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Terminal.Dashboard
{
    [TestClass]
    public class FixTerminalInfoTests
    {
        private static FixInfo _terminFixInfo;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _terminFixInfo = new FixInfo();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("/TerminalDashboard/?TerminalId=30381643");
        }

        [TestMethod]
        public void TerminalInfoCheck()
        {
            StringAssert.Matches(_terminFixInfo.Terminal.Article.Text, new Regex(@"\w+"));
            StringAssert.Matches(_terminFixInfo.Terminal.TerminalId.Text, new Regex(@"\d+"));
            StringAssert.Matches(_terminFixInfo.Terminal.ExternTerminalId.Text, new Regex(@"\w+"));
        }

        [TestMethod]
        public void LocationlInfoCheck()
        {
            StringAssert.Matches(_terminFixInfo.Location.Adress.Text, new Regex(@"\w+"));
            StringAssert.Matches(_terminFixInfo.Location.Ep2Id.Text, new Regex(@"\w{8}\d{7}"));
            StringAssert.Matches(_terminFixInfo.Location.Name.Text, new Regex(@"\w+"));
        }

        [TestMethod]
        public void CustomerInfoCheck()
        {
            StringAssert.Matches(_terminFixInfo.Customer.Adress.Text, new Regex(@"\w+"));
            StringAssert.Matches(_terminFixInfo.Customer.Id.Text, new Regex(@"\d+"));
            StringAssert.Matches(_terminFixInfo.Customer.Name.Text, new Regex(@"\w+"));
            StringAssert.Matches(_terminFixInfo.Customer.Info.Text, new Regex(@"\w+"));
        }
    }
}