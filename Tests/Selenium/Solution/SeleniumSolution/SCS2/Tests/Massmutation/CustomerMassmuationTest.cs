using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Massmuation;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class CustomerMassmuationTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestLauncher.Navigate();
            MassMutationMenu.CustomerCreate.Click();
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Customer")]
        public void Title()
        {
            Assert.AreEqual("Mehrere Kunden erstellen", Massmuation.Title);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Customer")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte geben Sie den Pfad zum Excel File mit den Kundendaten an. Bitte stellen Sie sicher, dass sie das richtige File mit der Bezeichnung SCA verwenden. Die Bezeichnung befindet sich im Exceldatei an der Spalte B1. Die Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                Massmuation.Description);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Customer")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", Massmuation.FileUploadButton.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Customer")]
        public void FileChooser()
        {
            Assert.AreEqual("", Massmuation.FileChooser.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Customer")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", Massmuation.DownloadTemplate);
        }
    }
}