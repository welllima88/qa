using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
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
            TestDirector.Navigate();
            MassMutationMenu.LocationCreate.Click();
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Location")]
        public void Title()
        {
            Assert.AreEqual("Mehrere Standorte erstellen", MassmuationFileUpload.Title);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Location")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte geben Sie den Pfad zum Excel File mit den Standortdaten an. Bitte stellen Sie sicher, dass sie das richtige File mit der Bezeichnung SCA verwenden. Die Bezeichnung befindet sich im Exceldatei an der Spalte B1. Die Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                MassmuationFileUpload.Description);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Location")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileUploadButton.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Location")]
        public void FileChooser()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileChooser.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Location")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", MassmuationFileUpload.DownloadTemplate);
        }
    }
}