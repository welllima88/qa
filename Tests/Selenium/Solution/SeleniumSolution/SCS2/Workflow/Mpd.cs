using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Mpd;

namespace Six.Scs.Test.Workflow
{
    public static class Mpd
    {
        public static void Create(Model.ValueObjects.Mpd m)
        {
            CustomerMenu.AllMpds.Click();
            ListView.CreateButton.Click();

            View.Mpd.Create.Description = m.Description;
            View.Mpd.Create.Adress = m.Adress;
            View.Mpd.Create.Port = m.Port;

            View.Mpd.Create.SaveButton.Click();

            m.Id = View.Mpd.View.Id;
        }

        public static void Edit(Model.ValueObjects.Mpd m)
        {
            View.Mpd.View.EditButton.Click();

            View.Mpd.Create.Description = m.Description;
            View.Mpd.Create.Adress = m.Adress;
            View.Mpd.Create.Port = m.Port;

            View.Mpd.Create.SaveButton.Click();

            m.Id = View.Mpd.View.Id;
        }
    }
}