using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Application.SmokeTest.HardwareManagement
{
    [TestFixture]
    public class ImportTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("HWManagement/ImportSerialNumber");
        }

        [Test]
        [Category("Hardware")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte wählen Sie das Excel-File (XLSX) mit den Seriennummern aus. Eine aktualisierte Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                View.Hardware.SerialNumberImport.Description);
        }

        [Test]
        [Category("Hardware")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel-Vorlage herunterladen", View.Hardware.SerialNumberImport.DownloadTemplate);
        }

        [Test]
        [Category("Hardware")]
        public void FileChooser()
        {
            Assert.AreEqual("", View.Hardware.SerialNumberImport.FileChooser.Text);
        }

        [Test]
        [Category("Hardware")]
        public void FileUploadButton()
        {
            Assert.AreEqual("Importieren", View.Hardware.SerialNumberImport.FileUploadButton.Text);
        }

        [Test]
        [Category("Hardware")]
        public void Title()
        {
            Assert.AreEqual("Seriennummern importieren", View.Hardware.SerialNumberImport.Title);
        }
    }
}