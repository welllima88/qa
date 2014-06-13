using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Terminal.Dashboard;

namespace SIX.SCS.Tests.Selenium.Tests.Terminal.Dashboard
{
    [TestClass]
    public class CustomerInfoTest
    {
        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
        }

        [TestMethod]
        public void Adress()
        {
            StringAssert.Matches(CustomerInfo.Adress, new Regex(@"\w+"));
        }

        [TestMethod]
        public void CustomerId()
        {
            StringAssert.Matches(CustomerInfo.Number, new Regex(@"\d+"));
        }

        [TestMethod]
        public void CustomerName()
        {
            StringAssert.Matches(CustomerInfo.Name, new Regex(@"\w+"));
        }

        [TestMethod]
        public void CustomerMarks()
        {
            Assert.IsNotNull(CustomerInfo.Info); // TODO unsafe check
        }
    }
}