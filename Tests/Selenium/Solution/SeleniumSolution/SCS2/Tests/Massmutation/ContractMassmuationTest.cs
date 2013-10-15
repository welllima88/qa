﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
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
            MassMutationMenu.ContractCreate.Click();
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void Title()
        {
            Assert.AreEqual("Mehrere Verträge erstellen", Massmuation.Title);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void Description()
        {
            Assert.AreEqual(
                "Mehrere Verträge hinzufügen",
                Massmuation.Description);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void FileUploadButton()
        {
            Assert.AreEqual("", Massmuation.FileUploadButton.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void FileChooser()
        {
            Assert.AreEqual("", Massmuation.FileChooser.Text);
        }

        [TestMethod]
        [TestCategory("Massmutation"), TestCategory("Contract")]
        public void DownloadTemplate()
        {
            Assert.AreEqual("Excel Vorlage herunterladen", Massmuation.DownloadTemplate);
        }
    }
}