using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Massmuation;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class BusinessTemplateMassmuationTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate();
            MassMutationMenu.Expand(true);
            MassMutationMenu.BusinessTemplateMigrate.Click();
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("BusinessTemplate")]
        public void Title()
        {
            Assert.AreEqual("Businesstemplates", MassmuationFileUpload.Title);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("BusinessTemplate")]
        public void Description()
        {
            Assert.AreEqual(
                "Durch Einlesen des Files im unten stehenden Link können die Businesstemplates eingestellt sowie die neue FO-Schnittstelle aktiviert werden.",
                MassmuationFileUpload.Description);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("BusinessTemplate")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileUploadButton.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("BusinessTemplate")]
        public void FileChooser()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileChooser.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("BusinessTemplate")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", MassmuationFileUpload.DownloadTemplate);
        }
    }
}