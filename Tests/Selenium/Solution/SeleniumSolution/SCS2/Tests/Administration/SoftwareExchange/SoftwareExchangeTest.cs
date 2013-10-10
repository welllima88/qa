using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.SoftwareExchange
{
    [TestClass]
    public class SoftwareExchangeTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate("/MasterSoftwareExchange/");
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestMethod]
        public void CreateSimCardAndSave()
        {
        }
    }
}