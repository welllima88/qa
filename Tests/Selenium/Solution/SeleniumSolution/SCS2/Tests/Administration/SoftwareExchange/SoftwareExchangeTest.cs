using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SoftwareExchange;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.SoftwareExchange
{
    [TestClass]
    public class SoftwareExchangeTest
    {
        private static SoftwareExchangeCreate _softwareExchangeCreate;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate("/MasterSoftwareExchange/");
            _softwareExchangeCreate = new SoftwareExchangeCreate();
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