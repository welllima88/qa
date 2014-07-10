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
    public class BusinessTemplateMassmuationTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            MassMutationMenu.Expand(true);
            MassMutationMenu.BusinessTemplateMigrate.Click();
        }

        [Test]
        [Category("Massmutation"), Category("BusinessTemplate")]
        public void Description()
        {
            Assert.AreEqual(
                "Durch Einlesen des Files im unten stehenden Link können die Businesstemplates eingestellt sowie die neue FO-Schnittstelle aktiviert werden.",
                MassmuationFileUpload.Description);
        }

        [Test]
        [Category("Massmutation"), Category("BusinessTemplate")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", MassmuationFileUpload.DownloadTemplate);
        }

        [Test]
        [Category("Massmutation"), Category("BusinessTemplate")]
        public void FileChooser()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileChooser.Text);
        }

        [Test]
        [Category("Massmutation"), Category("BusinessTemplate")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileUploadButton.Text);
        }

        [Test]
        [Category("Massmutation"), Category("BusinessTemplate")]
        public void Title()
        {
            Assert.AreEqual("Businesstemplates", MassmuationFileUpload.Title);
        }
    }
}