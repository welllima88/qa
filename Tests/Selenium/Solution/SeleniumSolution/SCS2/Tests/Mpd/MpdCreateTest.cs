using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Mpd;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Mpd
{
    [TestClass]
    public class MpdCreateTest
    {
        [TestMethod]
        public void CreateMpdToCustomer()
        {
            TestDirector.Navigate("Mpd/ListByCustomer/?CUSTOMERID=402200");

            CustomerMenu.AllMpds.Click();
            MpdListView.CreateButton.Click();
            Create();
        }

        [TestMethod]
        public void MpdId()
        {
            // MpdView.Id;
        }

        [TestMethod]
        public void Description()
        {
            Assert.AreEqual("SYR Auto Description", MpdView.Description);
        }

        [TestMethod]
        public void Adress()
        {
            Assert.AreEqual("Adress", MpdView.Adress);
        }

        [TestMethod]
        public void Port()
        {
            Assert.AreEqual("Port", MpdView.Port);
        }

        public static void Create()
        {
            MpdCreate.Description = "SYR Auto Description";
            MpdCreate.Adress = "Adress";
            MpdCreate.Port = "Port";
            MpdCreate.SaveButton.Click();
        }

        public static void Check()
        {
            Assert.AreEqual("SYR Auto Description", MpdView.Description);
            Assert.AreEqual("Adress", MpdView.Adress);
            Assert.AreEqual("Port", MpdView.Port);
        }
    }
}