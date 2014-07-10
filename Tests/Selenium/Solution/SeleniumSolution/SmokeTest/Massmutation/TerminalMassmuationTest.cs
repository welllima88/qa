using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Massmuation;

namespace Six.Scs.QA.Selenium.SmokeTest.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    public class TerminalMassmuationTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            MassMutationMenu.Expand(true);
            MassMutationMenu.TerminalCreate.Click();
        }

        [Test]
        [Category("Massmutation"), Category("Terminal")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte geben Sie den Pfad zum Excel File mit den Terminaldaten an. Bitte stellen Sie sicher, dass sie das richtige File mit der Bezeichnung SCA verwenden. Die Bezeichnung befindet sich im Exceldatei an der Spalte B1. Die Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                MassmuationFileUpload.Description);
        }

        [Test]
        [Category("Massmutation"), Category("Terminal")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", MassmuationFileUpload.DownloadTemplate);
        }

        [Test]
        [Category("Massmutation"), Category("Terminal")]
        public void FileChooser()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileChooser.Text);
        }

        [Test]
        [Category("Massmutation"), Category("Terminal")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileUploadButton.Text);
        }

        [Test]
        [Category("Massmutation"), Category("Terminal")]
        public void Title()
        {
            Assert.AreEqual("Terminals", MassmuationFileUpload.Title);
        }
    }
}