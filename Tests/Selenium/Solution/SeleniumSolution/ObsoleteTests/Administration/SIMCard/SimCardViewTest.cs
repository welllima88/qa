using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Administration.SimCard;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Administration.SIMCard
{
    [TestClass]
    public class SimCardCreateTest
    {
        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            TestDirector.Navigate("SIMCard/Details?SIMCardId=1");
        }

        [TestMethod]
        public void MobileNumber()
        {
            StringAssert.Matches(SimCardView.MobileNumber, new Regex(@"\d{10}"));
        }

        [TestMethod]
        public void SimCardNumber()
        {
            StringAssert.Matches(SimCardView.SimCardNumber, new Regex(@"\d{18}"));
        }

        [TestMethod]
        public void Pin()
        {
            StringAssert.Matches(SimCardView.Pin, new Regex(@"\d{4}"));
        }

        [TestMethod]
        public void Puk()
        {
            StringAssert.Matches(SimCardView.Puk, new Regex(@"\d{8}"));
        }

        [TestMethod]
        public void TerminalId()
        {
            StringAssert.Matches(SimCardView.TerminalId, new Regex(@"\d+"));
        }

        [TestMethod]
        public void Status()
        {
            Assert.IsNotNull(SimCardView.Status);
        }

        [TestMethod]
        public void Region()
        {
            Assert.IsNotNull(SimCardView.Region);
        }

        [TestMethod]
        public void Usage()
        {
            Assert.IsNotNull(SimCardView.Usage);
        }

        [TestMethod]
        public void SimCardMenuCheck()
        {
            Assert.IsTrue(SimCardMenu.SimCardManagement.Displayed);
        }

        [TestMethod]
        public void CheckNavigationBar()
        {
        }
    }
}