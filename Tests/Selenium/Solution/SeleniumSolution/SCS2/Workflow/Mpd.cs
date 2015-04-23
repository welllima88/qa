using Six.Scs.QA.Selenium.View.Common.Menu;
using Six.Scs.QA.Selenium.View.Mpd;

namespace Six.Scs.QA.Selenium.Workflow
{
    public static class Mpd
    {
        public static void Create(Selenium.Model.ValueObjects.Mpd m)
        {
            CustomerMenu.AllMpds.Click();
            ListView.CreateButton.Click();

            View.Mpd.Create.Description = m.Description;
            View.Mpd.Create.Adress = m.Adress;
            View.Mpd.Create.Port = m.Port;

            View.Mpd.Create.SaveButton.Click();

            m.Id = View.Mpd.View.Id;
        }

        public static void Edit(Selenium.Model.ValueObjects.Mpd m)
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