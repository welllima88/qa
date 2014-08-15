using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Mpd;

namespace Six.Scs.QA.Workflow
{
    public static class Mpd
    {
        public static void Create(TestData.ValueObjects.Mpd m)
        {
            CustomerMenu.AllMpds.Click();
            ListView.CreateButton.Click();

            Selenium.Mpd.Create.Description = m.Description;
            Selenium.Mpd.Create.Adress = m.Adress;
            Selenium.Mpd.Create.Port = m.Port;

            Selenium.Mpd.Create.SaveButton.Click();

            m.Id = View.Id;
        }

        public static void Edit(TestData.ValueObjects.Mpd m)
        {
            View.EditButton.Click();

            Selenium.Mpd.Create.Description = m.Description;
            Selenium.Mpd.Create.Adress = m.Adress;
            Selenium.Mpd.Create.Port = m.Port;

            Selenium.Mpd.Create.SaveButton.Click();
        }
    }
}