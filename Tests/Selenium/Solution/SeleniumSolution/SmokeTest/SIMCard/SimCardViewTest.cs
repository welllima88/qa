using NUnit.Framework;
using Six.Scs.QA.Selenium.Administration.SimCard;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.SIMCard
{
    [TestFixture]
    public class SimCardViewTest
    {
        [TestFixtureSetUp]
        public static void TestInit()
        {
            TestDirector.Navigate("SIMCard/Details?SIMCardId=16");
        }

        [Test]
        public void MobileNumber()
        {
            StringAssert.IsMatch(@"\d{10}", View.MobileNumber);
        }

        [Test]
        public void Pin()
        {
            StringAssert.IsMatch(@"\d{4}", View.Pin);
        }

        [Test]
        public void Puk()
        {
            StringAssert.IsMatch(@"\d{8}", View.Puk);
        }

        [Test]
        public void Region()
        {
            Assert.IsNotNull(View.Region);
        }

        [Test]
        public void SimCardMenuCheck()
        {
            Assert.IsTrue(SimCardMenu.SimCardManagement.Displayed);
        }

        [Test]
        public void SimCardNumber()
        {
            StringAssert.IsMatch(@"\d{18}", View.SimCardNumber);
        }

        [Test]
        public void Status()
        {
            Assert.IsNotNull(View.Status);
        }

        [Test]
        public void TerminalId()
        {
            StringAssert.IsMatch(@"\d+", View.TerminalId);
        }

        [Test]
        public void Usage()
        {
            Assert.IsNotNull(View.Usage);
        }
    }
}