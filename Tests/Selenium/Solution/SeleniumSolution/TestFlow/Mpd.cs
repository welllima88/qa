using NUnit.Framework;
using Six.Scs.QA.Selenium.Mpd;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Mpd
    {
        public static MpdData Create(CustomerData customer)
        {
            Customer.Open(customer);

            MpdData mpd = MpdFactory.Create();
            Workflow.Mpd.Create(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static MpdData Edit(MpdData _mpd)
        {
            Open(_mpd);
            MpdData mpd = MpdFactory.Create();
            mpd.Id = _mpd.Id; // keep Id

            Workflow.Mpd.Edit(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        private static void Open(MpdData mpd)
        {
            Search.MpdCanBeFoundById(mpd.Id);
        }

        public static void Check(MpdData m)
        {
            Assert.AreEqual(m.Id, MpdView.Id);
            Assert.AreEqual(m.Description, MpdView.Description);
            Assert.AreEqual(m.Adress, MpdView.Adress);
            Assert.AreEqual(m.Port, MpdView.Port);
        }
    }
}