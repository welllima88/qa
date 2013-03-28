using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Terminal.Dashboard
{
    [TestClass]
    public class FixTerminalInfoTests
    {
        private static FixInfo _terminFixInfo;
        private static ScsPlatinTestDirector _tb;
        private static IWebDriverAdapter _driver;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login
            _terminFixInfo = new FixInfo(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/TerminalDashboard/?TerminalId=30381643";
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void TerminalInfoCheck()
        {
            StringAssert.Matches(_terminFixInfo.Terminal.Article.Text, new Regex(@"\w+"));
            StringAssert.Matches(_terminFixInfo.Terminal.TerminalId.Text, new Regex(@"\d+"));
            StringAssert.Matches(_terminFixInfo.Terminal.ExternTerminalId.Text, new Regex(@"\w+"));
        }        [TestMethod]
        public void LocationlInfoCheck()
        {
            StringAssert.Matches(_terminFixInfo.Location.Adress.Text, new Regex(@"\w+"));
            StringAssert.Matches(_terminFixInfo.Location.Ep2Id.Text, new Regex(@"\w{8}\d{7}"));
            StringAssert.Matches(_terminFixInfo.Location.Name.Text, new Regex(@"\w+"));
        }
    }
}