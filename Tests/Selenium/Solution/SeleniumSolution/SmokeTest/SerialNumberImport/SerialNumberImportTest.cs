using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.TestObjects.Administration;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace Six.Scs.QA.Selenium.SmokeTest.SerialNumberImport
{
    [TestFixture]
    public class SerialNumberImportTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            LobbyMenu.SerialNumberManage.Click();
        }

        private static void CheckSupplier(string supplier, string start, string length)
        {
            SerialNumberManage.Supplier = supplier;

            Assert.AreEqual(start, SerialNumberManage.StartField);
            Assert.AreEqual(length, SerialNumberManage.LengthField);
        }

        [Test]
        [Category("SerialNumberManagement")]
        public void ImportButton()
        {
            Assert.IsTrue(SerialNumberManage.ImportButton.Displayed);
        }

        [Test]
        [Category("SerialNumberManagement")]
        public void LengthField()
        {
            Assert.IsNotNull(SerialNumberManage.LengthField);
        }

        [Test]
        [Category("SerialNumberManagement")]
        public void SerialNumbersField()
        {
            Assert.IsNotNull(SerialNumberManage.SerialNumbersField);
        }

        [Test]
        [Category("SerialNumberManagement")]
        public void StartField()
        {
            Assert.IsNotNull(SerialNumberManage.StartField);
        }

        [Test]
        [Category("SerialNumberManagement")]
        public void Supplier()
        {
            Assert.IsNotNull(SerialNumberManage.Supplier);
        }

        [Test]
        [Category("SerialNumberManagement"), Category("Atos")]
        public void SupplierAtos()
        {
            CheckSupplier("Atos", "4", "16");
        }

        [Test]
        [Category("SerialNumberManagement"), Category("GMX")]
        public void SupplierGmx()
        {
            CheckSupplier("GMX", "1", "11");
        }

        [Test]
        [Category("SerialNumberManagement"), Category("PayTec")]
        public void SupplierPaytec()
        {
            CheckSupplier("PayTec", "2", "7");
        }
    }
}