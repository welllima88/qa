using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.SoftwareExchange
{
    [TestFixture]
    public class SoftwareExchangeTest
    {
        [SetUp]
        public void TestInit()
        {
        }

        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("MasterSoftwareExchange/");
        }

        [Test]
        public void CreateMassJob()
        {
        }
    }
}