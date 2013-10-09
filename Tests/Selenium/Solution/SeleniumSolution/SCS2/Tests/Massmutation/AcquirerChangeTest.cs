using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Massmuation;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class AcquirerChangeTest
    {
        private static LobbyView _lobbyView;
        private static AcquirerChange _acquirerChange;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _lobbyView = new LobbyView();
            _acquirerChange = new AcquirerChange();
            TestLauncher.Navigate("");
            _lobbyView.Menu.MassMutation.AcquirerChange.Click();
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("AcquirerChange")]
        public void Title()
        {
            Assert.AreEqual("Mehrere Acquirer wechseln", _acquirerChange.Title);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("AcquirerChange")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte geben Sie den Pfad zum Excel File mit den Acquirerwechsel Daten an. Die Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                _acquirerChange.Description);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("AcquirerChange")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", _acquirerChange.FileUploadButton.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("AcquirerChange")]
        public void FileChooser()
        {
            Assert.AreEqual("", _acquirerChange.FileChooser.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("AcquirerChange")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", _acquirerChange.DownloadTemplate);
        }
    }
}