using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Administration.SoftwareExchange
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