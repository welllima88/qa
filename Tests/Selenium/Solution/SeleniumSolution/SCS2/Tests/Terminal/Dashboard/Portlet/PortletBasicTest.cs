using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.Dashboard.Portlet
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
        public void TechnicalViewpointPresent()
        {
            //StringAssert.Matches(TechnicalViewPortlet.Headline.Text, new Regex(@"\w+"));
        }

        [TestMethod]
        public void LocationEp2Id()
        {
            StringAssert.Matches(LocationInfo.Ep2Id.Text, new Regex(@"\w{8}\d{7}"));
        }

        [TestMethod]
        public void LocationName()
        {
            StringAssert.Matches(LocationInfo.Name.Text, new Regex(@"\w+"));
        }
    }
}