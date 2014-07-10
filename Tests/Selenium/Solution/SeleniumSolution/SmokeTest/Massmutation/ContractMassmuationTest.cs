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
    public class ContractMassmuationTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate();
            MassMutationMenu.Expand(true);
            MassMutationMenu.ContractCreate.Click();
        }

        [Test]
        [Category("Massmutation"), Category("Contract")]
        public void Description()
        {
            Assert.AreEqual(
                "Mehrere Verträge hinzufügen",
                MassmuationFileUpload.Description);
        }

        [Test]
        [Category("Massmutation"), Category("Contract")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", MassmuationFileUpload.DownloadTemplate);
        }

        [Test]
        [Category("Massmutation"), Category("Contract")]
        public void FileChooser()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileChooser.Text);
        }

        [Test]
        [Category("Massmutation"), Category("Contract")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", MassmuationFileUpload.FileUploadButton.Text);
        }

        [Test]
        [Category("Massmutation"), Category("Contract")]
        public void Title()
        {
            Assert.AreEqual("Verträge", MassmuationFileUpload.Title);
        }
    }
}