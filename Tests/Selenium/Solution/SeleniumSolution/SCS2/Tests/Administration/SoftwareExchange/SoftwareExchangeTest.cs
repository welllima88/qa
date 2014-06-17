using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Administration.SoftwareExchange
{
    [TestClass]
    public class SoftwareExchangeTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("MasterSoftwareExchange/");
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestMethod]
        public void CreateMassJob()
        {
        }
    }
}