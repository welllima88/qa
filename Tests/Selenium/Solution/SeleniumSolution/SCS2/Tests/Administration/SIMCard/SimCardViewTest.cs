using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.SIMCard
{
    [TestClass]
    public class SimCardCreateTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestDirector.Navigate("/SIMCard/Details?SIMCardId=1");
        }

        [TestMethod]
        public void MobileNumber()
        {
            StringAssert.Matches(SimCardView.SimCardElement.MobileNumber, new Regex(@"\d{10}"));
        }

        [TestMethod]
        public void SimCardNumber()
        {
            StringAssert.Matches(SimCardView.SimCardElement.SimCardNumber, new Regex(@"\d{18}"));
        }

        [TestMethod]
        public void Pin()
        {
            StringAssert.Matches(SimCardView.SimCardElement.Pin, new Regex(@"\d{4}"));
        }

        [TestMethod]
        public void Puk()
        {
            StringAssert.Matches(SimCardView.SimCardElement.Puk, new Regex(@"\d{8}"));
        }

        [TestMethod]
        public void TerminalId()
        {
            StringAssert.Matches(SimCardView.SimCardElement.TerminalId, new Regex(@"\d+"));
        }

        [TestMethod]
        public void Status()
        {
            Assert.IsNotNull(SimCardView.SimCardElement.Status);
        }

        [TestMethod]
        public void Region()
        {
            Assert.IsNotNull(SimCardView.SimCardElement.Region);
        }

        [TestMethod]
        public void Usage()
        {
            Assert.IsNotNull(SimCardView.SimCardElement.Usage);
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