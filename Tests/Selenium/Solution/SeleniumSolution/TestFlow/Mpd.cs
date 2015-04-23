using NUnit.Framework;
using Six.Scs.QA.Selenium.View.Mpd;
using Six.Scs.QA.Selenium.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Mpd
    {
        public static Selenium.Model.ValueObjects.Mpd Create(Selenium.Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);

            Selenium.Model.ValueObjects.Mpd mpd = Selenium.Model.Factory.Mpd.Create();
            Selenium.Workflow.Mpd.Create(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static Selenium.Model.ValueObjects.Mpd Edit(Selenium.Model.ValueObjects.Mpd _mpd)
        {
            Open(_mpd);
            Selenium.Model.ValueObjects.Mpd mpd = Selenium.Model.Factory.Mpd.Edit();
            mpd.Id = _mpd.Id; // keep Id

            Selenium.Workflow.Mpd.Edit(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static void Open(Selenium.Model.ValueObjects.Mpd mpd)
        {
            Search.MpdCanBeFoundById(mpd.Id);
        }

        public static void Check(Selenium.Model.ValueObjects.Mpd m)
        {
            Assert.AreEqual(m.Id, View.Id);
            Assert.AreEqual(m.Description, View.Description);
            Assert.AreEqual(m.Adress, View.Adress);
            Assert.AreEqual(m.Port, View.Port);
        }
    }
}