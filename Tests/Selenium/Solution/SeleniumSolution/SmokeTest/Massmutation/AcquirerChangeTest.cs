using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Massmuation;

namespace Six.Scs.QA.Selenium.SmokeTest.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class AcquirerChangeTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            LobbyMenu.Expand("Massenmutation");
            MassMutationMenu.AcquirerChange.Click();
        }

        [Test]
        [Category("Massmutation"), Category("AcquirerChange")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte geben Sie den Pfad zur Excel Datei mit den Acquirerdaten an. Stellen Sie sicher, dass Sie die richtige Vorlage verwenden. Die neuste Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                FileUpload.Description);
        }

        [Test]
        [Category("Massmutation"), Category("AcquirerChange")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", FileUpload.DownloadTemplate);
        }

        [Test]
        [Category("Massmutation"), Category("AcquirerChange")]
        public void FileChooser()
        {
            Assert.AreEqual("", FileUpload.FileChooser.Text);
        }

        [Test]
        [Category("Massmutation"), Category("AcquirerChange")]
        public void FileUploadButton()
        {
            Assert.AreEqual("Importieren", FileUpload.FileUploadButton.Text);
        }

        [Test]
        [Category("Massmutation"), Category("AcquirerChange")]
        public void Title()
        {
            Assert.AreEqual("Acquirerwechsel Massenmutation", FileUpload.Title);
        }
    }
}