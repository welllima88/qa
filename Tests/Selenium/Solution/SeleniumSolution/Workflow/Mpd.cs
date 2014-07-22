using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Mpd;

namespace Six.Scs.QA.Workflow
{
    public static class Mpd
    {
        public static void Create(TestData.ValueObjects.Mpd m)
        {
            CustomerMenu.AllMpds.Click();
            MpdListView.CreateButton.Click();

            MpdCreate.Description = m.Description;
            MpdCreate.Adress = m.Adress;
            MpdCreate.Port = m.Port;

            MpdCreate.SaveButton.Click();

            m.Id = MpdView.Id;
        }

        public static void Edit(TestData.ValueObjects.Mpd m)
        {
            MpdView.EditButton.Click();

            MpdCreate.Description = m.Description;
            MpdCreate.Adress = m.Adress;
            MpdCreate.Port = m.Port;

            MpdCreate.SaveButton.Click();
        }
    }
}