﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Massmuation;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class TerminalMassmuationTest
    {
        private static LobbyView _lobbyView;
        private static Massmuation _massmuation;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _lobbyView = new LobbyView();
            _massmuation = new Massmuation();
            TestLauncher.Navigate("");
            _lobbyView.Menu.MassMutation.TerminalCreate.Click();
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Terminal")]
        public void Title()
        {
            Assert.AreEqual("Mehrere Terminals erstellen", _massmuation.Title);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Terminal")]
        public void Description()
        {
            Assert.AreEqual(
                "Bitte geben Sie den Pfad zum Excel File mit den Terminaldaten an. Bitte stellen Sie sicher, dass sie das richtige File mit der Bezeichnung SCA verwenden. Die Bezeichnung befindet sich im Exceldatei an der Spalte B1. Die Vorlage kann mittels untenstehendem Link heruntergeladen werden.",
                _massmuation.Description);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Terminal")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", _massmuation.FileUploadButton.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Terminal")]
        public void FileChooser()
        {
            Assert.AreEqual("", _massmuation.FileChooser.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Terminal")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", _massmuation.DownloadTemplate);
        }
    }
}