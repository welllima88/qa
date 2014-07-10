using NUnit.Framework;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.QA.Selenium.Extension.TestObjects.Massmuation;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.Massmutation
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
            MassMutationMenu.Expand(true);
            MassMutationMenu.LocationCreate.Click();
        }

        [Test]
        [Category("Massmutation"), Category("Location")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte geben Sie den Pfad zum Excel File mit den Standortdaten an. Bitte stellen Sie sicher, dass sie das richtige File mit der Bezeichnung SCA verwenden. Die Bezeichnung befindet sich im Exceldatei an der Spalte B1. Die Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                MassmuationFileUpload.Description);
        }

        [Test]
        [Category("Massmutation"), Category("Location")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", MassmuationFileUpload.DownloadTemplate);
        }

        [Test]
        [Category("Massmutation"), Category("Location")]
        public void FileChooser()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileChooser.Text);
        }

        [Test]
        [Category("Massmutation"), Category("Location")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileUploadButton.Text);
        }

        [Test]
        [Category("Massmutation"), Category("Location")]
        public void Title()
        {
            Assert.AreEqual("Standorte", MassmuationFileUpload.Title);
        }
    }
}