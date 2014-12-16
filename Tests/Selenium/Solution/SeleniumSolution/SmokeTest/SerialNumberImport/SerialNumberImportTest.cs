using NUnit.Framework;
using Six.Scs.QA.Selenium.Administration.SerialNumberManage;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.SerialNumberImport
{
    [TestFixture]
    public class SerialNumberImportTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            LobbyMenu.SerialNumberManage.Click();
        }

        private static void CheckSupplier(string supplier, string start, string length)
        {
            Import.Supplier = supplier;

            Assert.AreEqual(start, Import.StartField);
            Assert.AreEqual(length, Import.LengthField);
        }

        [Test]
        [Category("SerialNumberManagement")]
        public void ImportButton()
        {
            Assert.IsTrue(Import.ImportButton.Displayed);
        }

        [Test]
        [Category("SerialNumberManagement")]
        public void LengthField()
        {
            Assert.IsNotNull(Import.LengthField);
        }

        [Test]
        [Category("SerialNumberManagement")]
        public void SerialNumbersField()
        {
            Assert.IsNotNull(Import.SerialNumbersField);
        }

        [Test]
        [Category("SerialNumberManagement")]
        public void StartField()
        {
            Assert.IsNotNull(Import.StartField);
        }

        [Test]
        [Category("SerialNumberManagement")]
        public void Supplier()
        {
            Assert.IsNotNull(Import.Supplier);
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