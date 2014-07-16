using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Administration;
using Six.Scs.QA.Selenium.Common.Menu;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Administration.SerialNumberImport
{
    [TestClass]
    public class SerialNumberImportTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            LobbyMenu.SerialNumberManage.Click();
        }

        [TestMethod]
        [TestCategory("SerialNumberManagement")]
        public void Supplier()
        {
            Assert.IsNotNull(SerialNumberManage.Supplier);
        }

        [TestMethod]
        [TestCategory("SerialNumberManagement")]
        public void StartField()
        {
            Assert.IsNotNull(SerialNumberManage.StartField);
        }

        [TestMethod]
        [TestCategory("SerialNumberManagement")]
        public void LengthField()
        {
            Assert.IsNotNull(SerialNumberManage.LengthField);
        }

        [TestMethod]
        [TestCategory("SerialNumberManagement")]
        public void SerialNumbersField()
        {
            Assert.IsNotNull(SerialNumberManage.SerialNumbersField);
        }

        [TestMethod]
        [TestCategory("SerialNumberManagement")]
        public void ImportButton()
        {
            Assert.IsTrue(SerialNumberManage.ImportButton.Displayed);
        }

        [TestMethod]
        [TestCategory("SerialNumberManagement"), TestCategory("Atos")]
        public void SupplierAtos()
        {
            CheckSupplier("Atos", "4", "16");
        }

        [TestMethod]
        [TestCategory("SerialNumberManagement"), TestCategory("PayTec")]
        public void SupplierPaytec()
        {
            CheckSupplier("PayTec", "2", "7");
        }

        [TestMethod]
        [TestCategory("SerialNumberManagement"), TestCategory("GMX")]
        public void SupplierGmx()
        {
            CheckSupplier("GMX", "1", "11");
        }

        private static void CheckSupplier(string supplier, string start, string length)
        {
            SerialNumberManage.Supplier = supplier;

            Assert.AreEqual(start, SerialNumberManage.StartField);
            Assert.AreEqual(length, SerialNumberManage.LengthField);
        }
    }
}