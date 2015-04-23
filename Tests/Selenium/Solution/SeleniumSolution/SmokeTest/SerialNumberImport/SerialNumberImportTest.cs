using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Administration.SerialNumberManage;
using Six.Scs.QA.Selenium.View.Common.Menu;

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
    }
}