using NUnit.Framework;
using Six.Scs.Test.Workflow;

namespace Six.Scs.Test
{
    public class Mpd
    {
        public static Test.Model.ValueObjects.Mpd Create(Test.Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);

            Test.Model.ValueObjects.Mpd mpd = Test.Model.Factory.Mpd.Create();
            Test.Workflow.Mpd.Create(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static Test.Model.ValueObjects.Mpd Edit(Test.Model.ValueObjects.Mpd _mpd)
        {
            Open(_mpd);
            Test.Model.ValueObjects.Mpd mpd = Test.Model.Factory.Mpd.Edit();
            mpd.Id = _mpd.Id; // keep Id

            Test.Workflow.Mpd.Edit(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static void Open(Test.Model.ValueObjects.Mpd mpd)
        {
            Search.MpdCanBeFoundById(mpd.Id);
        }

        public static void Check(Test.Model.ValueObjects.Mpd m)
        {
            Assert.AreEqual(m.Id, View.Mpd.View.Id);
            Assert.AreEqual(m.Description, View.Mpd.View.Description);
            Assert.AreEqual(m.Adress, View.Mpd.View.Adress);
            Assert.AreEqual(m.Port, View.Mpd.View.Port);
        }
    }
}