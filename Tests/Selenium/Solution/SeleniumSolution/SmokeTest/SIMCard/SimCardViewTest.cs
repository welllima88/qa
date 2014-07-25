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
            StringAssert.IsMatch(@"\d{10}", SimCardView.MobileNumber);
        }

        [Test]
        public void Pin()
        {
            StringAssert.IsMatch(@"\d{4}", SimCardView.Pin);
        }

        [Test]
        public void Puk()
        {
            StringAssert.IsMatch(@"\d{8}", SimCardView.Puk);
        }

        [Test]
        public void Region()
        {
            Assert.IsNotNull(SimCardView.Region);
        }

        [Test]
        public void SimCardMenuCheck()
        {
            Assert.IsTrue(SimCardMenu.SimCardManagement.Displayed);
        }

        [Test]
        public void SimCardNumber()
        {
            StringAssert.IsMatch(@"\d{18}", SimCardView.SimCardNumber);
        }

        [Test]
        public void Status()
        {
            Assert.IsNotNull(SimCardView.Status);
        }

        [Test]
        public void TerminalId()
        {
            StringAssert.IsMatch(@"\d+", SimCardView.TerminalId);
        }

        [Test]
        public void Usage()
        {
            Assert.IsNotNull(SimCardView.Usage);
        }
    }
}