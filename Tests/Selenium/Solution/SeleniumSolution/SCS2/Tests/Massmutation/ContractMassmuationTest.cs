using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Massmuation;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class ContractMassmuationTest
    {
        private static LobbyView _lobbyView;
        private static Massmuation _massmuation;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _lobbyView = new LobbyView();
            _massmuation = new Massmuation();
            TestLauncher.Navigate("");
            _lobbyView.Menu.MassMutation.ContractCreate.Click();
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void Title()
        {
            Assert.AreEqual("Mehrere Verträge erstellen", _massmuation.Title);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void Description()
        {
            Assert.AreEqual(
                "Mehrere Verträge hinzufügen",
                _massmuation.Description);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", _massmuation.FileUploadButton.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void FileChooser()
        {
            Assert.AreEqual("", _massmuation.FileChooser.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", _massmuation.DownloadTemplate);
        }
    }
}