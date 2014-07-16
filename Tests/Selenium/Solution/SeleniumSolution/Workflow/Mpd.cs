using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Mpd;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Workflow
{
    public static class Mpd
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

        public static void Edit(MpdData m)
        {
            MpdView.EditButton.Click();
            
            MpdCreate.Description = m.Description;
            MpdCreate.Adress = m.Adress;
            MpdCreate.Port = m.Port;

            MpdCreate.SaveButton.Click();

            m.Id = MpdView.Id;
        }
    }
}