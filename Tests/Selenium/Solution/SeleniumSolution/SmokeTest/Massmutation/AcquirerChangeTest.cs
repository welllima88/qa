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
                "Bitte geben Sie den Pfad zum Excel File mit den Acquirerwechsel Daten an. Die Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                AcquirerChange.Description);
        }

        [Test]
        [Category("Massmutation"), Category("AcquirerChange")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", AcquirerChange.DownloadTemplate);
        }

        [Test]
        [Category("Massmutation"), Category("AcquirerChange")]
        public void FileChooser()
        {
            Assert.AreEqual("", AcquirerChange.FileChooser.Text);
        }

        [Test]
        [Category("Massmutation"), Category("AcquirerChange")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", AcquirerChange.FileUploadButton.Text);
        }

        [Test]
        [Category("Massmutation"), Category("AcquirerChange")]
        public void Title()
        {
            Assert.AreEqual("Mehrere Acquirer wechseln", AcquirerChange.Title);
        }
    }
}