using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Massmuation;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class LocationMassmuationTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate("");
            LobbyMenu.MassMutation.LocationCreate.Click();
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Location")]
        public void Title()
        {
            Assert.AreEqual("Mehrere Standorte erstellen", Massmuation.Title);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Location")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte geben Sie den Pfad zum Excel File mit den Standortdaten an. Bitte stellen Sie sicher, dass sie das richtige File mit der Bezeichnung SCA verwenden. Die Bezeichnung befindet sich im Exceldatei an der Spalte B1. Die Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                Massmuation.Description);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Location")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", Massmuation.FileUploadButton.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Location")]
        public void FileChooser()
        {
            Assert.AreEqual("", Massmuation.FileChooser.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Location")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", Massmuation.DownloadTemplate);
        }
    }
}