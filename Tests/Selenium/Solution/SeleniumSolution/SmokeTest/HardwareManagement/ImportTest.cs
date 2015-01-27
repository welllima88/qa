using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.HardwareManagement
{
    [TestFixture]
    public class ImportTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("HWManagementImportSerialNumber/index");
        }

        [Test]
        [Category("Hardware")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte wählen Sie das Excel-File (XLSX) mit den Seriennummern aus. Eine aktualisierte Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                Hardware.SerialNumberImport.Description);
        }

        [Test]
        [Category("Hardware")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel-Vorlage herunterladen", Hardware.SerialNumberImport.DownloadTemplate);
        }

        [Test]
        [Category("Hardware")]
        public void FileChooser()
        {
            Assert.AreEqual("", Hardware.SerialNumberImport.FileChooser.Text);
        }

        [Test]
        [Category("Hardware")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", Hardware.SerialNumberImport.FileUploadButton.Text);
        }

        [Test]
        [Category("Hardware")]
        public void Title()
        {
            Assert.AreEqual("Importieren von Seriennummern für Hardware-Verwaltung", Hardware.SerialNumberImport.Title);
        }
    }
}