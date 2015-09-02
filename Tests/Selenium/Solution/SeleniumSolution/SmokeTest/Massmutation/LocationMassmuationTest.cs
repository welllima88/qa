using NUnit.Framework;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Massmuation;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class LocationMassmuationTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            LobbyMenu.Expand("Massenmutation");
            MassMutationMenu.LocationCreate.Click();
        }

        [Test]
        [Category("Massmutation"), Category("Location")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte geben Sie den Pfad zur Excel Datei mit den Standortdaten an. Stellen Sie sicher, dass Sie die richtige Vorlage verwenden. Die neuste Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                FileUpload.Description);
        }

        [Test]
        [Category("Massmutation"), Category("Location")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", FileUpload.DownloadTemplate);
        }

        [Test]
        [Category("Massmutation"), Category("Location")]
        public void FileChooser()
        {
            Assert.AreEqual("", FileUpload.FileChooser.Text);
        }

        [Test]
        [Category("Massmutation"), Category("Location")]
        public void FileUploadButton()
        {
            Assert.AreEqual("Importieren", FileUpload.FileUploadButton.Text);
        }

        [Test]
        [Category("Massmutation"), Category("Location")]
        public void Title()
        {
            Assert.AreEqual("Standort Massenmutation", FileUpload.Title);
        }
    }
}