using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.SoftwareExchange
{
    [TestClass]
    public class SoftwareExchangeTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("/MasterSoftwareExchange/");
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