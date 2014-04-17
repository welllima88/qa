using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Mpd;

namespace SIX.SCS.QA.Selenium.Extension.Worklow
{
    public class MpdService
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