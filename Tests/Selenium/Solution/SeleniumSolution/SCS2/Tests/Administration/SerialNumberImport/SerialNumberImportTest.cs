using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestObjects.Administration;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace Six.Scs.QA.Selenium.Tests.Administration.SerialNumberImport
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

        [TestMethod]
        [TestCategory("SerialNumberManagement"), TestCategory("PreviewSerialNumbers")]
        public void PreviewSerialNumbers()
        {
            SerialNumberManage.SerialNumbersField =
                "1234567890A11223344556677889900000\n" +
                "11234567890B1122334455667788990000\n" +
                "111234567890C112233445566778899000\n" +
                "1111234567890D11223344556677889900\n";

            CheckPreview("1", "10", "1234567890");
            CheckPreview("2", "11", "234567890A1");
            CheckPreview("5", "1", "5");
        }

        private void CheckPreview(string start, string length, string expectedPreview)
        {
            SerialNumberManage.StartField = start;
            SerialNumberManage.LengthField = length;

            Assert.AreEqual(expectedPreview, SerialNumberManage.Preview);
        }

        private static void CheckSupplier(string supplier, string start, string length)
        {
            SerialNumberManage.Supplier = supplier;

            Assert.AreEqual(start, SerialNumberManage.StartField);
            Assert.AreEqual(length, SerialNumberManage.LengthField);
        }
    }
}