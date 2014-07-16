using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal.Dashboard;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Terminal.Dashboard.Portlet
{
    [TestClass]
    public class PortletBasicTest
    {
        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
        }

        [TestMethod]
        public void LocationEp2Id()
        {
            StringAssert.Matches(LocationInfo.Ep2Id, new Regex(@"\w{8}\d{7}"));
        }

        [TestMethod]
        public void LocationName()
        {
            StringAssert.Matches(LocationInfo.CompanyName, new Regex(@"\w+"));
        }
    }
}