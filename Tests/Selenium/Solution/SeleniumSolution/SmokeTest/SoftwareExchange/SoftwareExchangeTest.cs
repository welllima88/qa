using NUnit.Framework;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.SoftwareExchange
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
    }
}