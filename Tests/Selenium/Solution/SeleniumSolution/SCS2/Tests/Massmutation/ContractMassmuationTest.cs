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
    public class ContractMassmuationTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
            MassMutationMenu.Expand(true);
            MassMutationMenu.ContractCreate.Click();
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void Title()
        {
            Assert.AreEqual("Verträge", MassmuationFileUpload.Title);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void Description()
        {
            Assert.AreEqual(
                "Mehrere Verträge hinzufügen",
                MassmuationFileUpload.Description);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileUploadButton.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void FileChooser()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileChooser.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", MassmuationFileUpload.DownloadTemplate);
        }
    }
}