using NUnit.Framework;
using Six.Scs.QA.Application.View.Mpd;
using Six.Scs.QA.Application.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Mpd
    {
        public static Application.Model.ValueObjects.Mpd Create(Application.Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);

            Application.Model.ValueObjects.Mpd mpd = Application.Model.Factory.Mpd.Create();
            Application.Workflow.Mpd.Create(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static Application.Model.ValueObjects.Mpd Edit(Application.Model.ValueObjects.Mpd _mpd)
        {
            Open(_mpd);
            Application.Model.ValueObjects.Mpd mpd = Application.Model.Factory.Mpd.Edit();
            mpd.Id = _mpd.Id; // keep Id

            Application.Workflow.Mpd.Edit(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static void Open(Application.Model.ValueObjects.Mpd mpd)
        {
            Search.MpdCanBeFoundById(mpd.Id);
        }

        public static void Check(Application.Model.ValueObjects.Mpd m)
        {
            Assert.AreEqual(m.Id, View.Id);
            Assert.AreEqual(m.Description, View.Description);
            Assert.AreEqual(m.Adress, View.Adress);
            Assert.AreEqual(m.Port, View.Port);
        }
    }
}