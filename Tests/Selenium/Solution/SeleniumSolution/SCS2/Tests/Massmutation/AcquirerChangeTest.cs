using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Massmuation;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class AcquirerChangeTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
            MassMutationMenu.AcquirerChange.Click();
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("AcquirerChange")]
        public void Title()
        {
            Assert.AreEqual("Mehrere Acquirer wechseln", AcquirerChange.Title);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("AcquirerChange")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte geben Sie den Pfad zum Excel File mit den Acquirerwechsel Daten an. Die Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                AcquirerChange.Description);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("AcquirerChange")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", AcquirerChange.FileUploadButton.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("AcquirerChange")]
        public void FileChooser()
        {
            Assert.AreEqual("", AcquirerChange.FileChooser.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("AcquirerChange")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", AcquirerChange.DownloadTemplate);
        }
    }
}