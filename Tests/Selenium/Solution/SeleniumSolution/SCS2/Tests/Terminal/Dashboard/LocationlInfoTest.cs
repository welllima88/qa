using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Terminal.Dashboard
{
    [TestClass]
    public class LocationlInfoTest
    {
        [ClassInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
        }

        [TestMethod]
        public void LocationAdress()
        {
            StringAssert.Matches(LocationInfo.Adress.Text, new Regex(@"\w+"));
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