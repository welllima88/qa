using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Mpd;

namespace SIX.SCS.Tests.Selenium.Extension.Worklow
{
    public static class MpdService
    {
        public static void Create(MpdData m)
        {
            CustomerMenu.AllMpds.Click();
            MpdListView.CreateButton.Click();

            MpdCreate.Description = m.Description;
            MpdCreate.Adress = m.Adress;
            MpdCreate.Port = m.Port;

            MpdCreate.SaveButton.Click();

            m.Id = MpdView.Id;
        }

        public static void Check(MpdData m)
        {
            Assert.AreEqual(m.Id, MpdView.Id);
            Assert.AreEqual(m.Description, MpdView.Description);
            Assert.AreEqual(m.Adress, MpdView.Adress);
            Assert.AreEqual(m.Port, MpdView.Port);
        }
    }
}