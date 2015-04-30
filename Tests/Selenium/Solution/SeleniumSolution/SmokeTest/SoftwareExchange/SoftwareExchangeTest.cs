using NUnit.Framework;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.SoftwareExchange
{
    [TestFixture]
    public class SoftwareExchangeTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("MasterSoftwareExchange/");
        }
    }
}