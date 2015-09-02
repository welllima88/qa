using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Mpd;

namespace Six.Scs.Test.Workflow
{
    public static class Mpd
    {
        public static void Create(Model.Mpd m)
        {
            CustomerMenu.AllMpds.Click();
            ListView.CreateButton.Click();

            UI.Mpd.Create.Description = m.Description;
            UI.Mpd.Create.Adress = m.Adress;
            UI.Mpd.Create.Port = m.Port;

            UI.Mpd.Create.SaveButton.Click();

            m.Id = View.Id;
        }

        public static void Edit(Model.Mpd m)
        {
            View.EditButton.Click();

            UI.Mpd.Create.Description = m.Description;
            UI.Mpd.Create.Adress = m.Adress;
            UI.Mpd.Create.Port = m.Port;

            UI.Mpd.Create.SaveButton.Click();

            m.Id = View.Id;
        }
    }
}