using NUnit.Framework;
using Six.Scs.Test.UI.Administration.SimCard;
using Six.Scs.Test.UI.Common.Menu;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.SIMCard
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
            Assert.That(LobbyMenu.SimCardManage.Displayed);
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