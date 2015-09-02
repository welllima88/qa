using NUnit.Framework;
using Six.Scs.Test.UI.Mpd;
using Six.Scs.Test.Workflow;

namespace Six.Scs.Test
{
    public class Mpd
    {
        public static Model.Mpd Create(Model.Customer customer)
        {
            Customer.Open(customer);

            var mpd = Factory.Mpd.Create();
            Workflow.Mpd.Create(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static Model.Mpd Edit(Model.Mpd _mpd)
        {
            Open(_mpd);
            var mpd = Factory.Mpd.Edit();
            mpd.Id = _mpd.Id; // keep Id

            Workflow.Mpd.Edit(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static void Open(Model.Mpd mpd)
        {
            Search.MpdCanBeFoundById(mpd.Id);
        }

        public static void Check(Model.Mpd m)
        {
            Assert.AreEqual(m.Id, View.Id);
            Assert.AreEqual(m.Description, View.Description);
            Assert.AreEqual(m.Adress, View.Adress);
            Assert.AreEqual(m.Port, View.Port);
        }
    }
}