using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Massmuation;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class BusinessTemplateMassmuationTest
    {
        private static LobbyView LobbyView;
        private static Massmuation Massmuation;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            LobbyView = new LobbyView();
            Massmuation = new Massmuation();
            TestLauncher.Navigate("");
            LobbyMenu.MassMutation.BusinessTemplateMigrate.Click();
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("BusinessTemplate")]
        public void Title()
        {
            Assert.AreEqual("Businesstemplates mit neuer FO-Schnittstelle aktivieren", Massmuation.Title);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("BusinessTemplate")]
        public void Description()
        {
            Assert.AreEqual(
                "Durch Einlesen des Files im unten stehenden Link können die Businesstemplates eingestellt sowie die neue FO-Schnittstelle aktiviert werden.",
                Massmuation.Description);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("BusinessTemplate")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", Massmuation.FileUploadButton.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("BusinessTemplate")]
        public void FileChooser()
        {
            Assert.AreEqual("", Massmuation.FileChooser.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("BusinessTemplate")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", Massmuation.DownloadTemplate);
        }
    }
}