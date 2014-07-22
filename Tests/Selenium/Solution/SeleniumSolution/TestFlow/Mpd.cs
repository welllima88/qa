using NUnit.Framework;
using Six.Scs.QA.Selenium.Mpd;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Mpd
    {
        public static TestData.ValueObjects.Mpd Create(TestData.ValueObjects.Customer customer)
        {
            Customer.Open(customer);

            TestData.ValueObjects.Mpd mpd = MpdFactory.Create();
            Workflow.Mpd.Create(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static TestData.ValueObjects.Mpd Edit(TestData.ValueObjects.Mpd _mpd)
        {
            Open(_mpd);
            TestData.ValueObjects.Mpd mpd = MpdFactory.Create();
            mpd.Id = _mpd.Id; // keep Id

            Workflow.Mpd.Edit(mpd);
            Check(mpd);

            Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        private static void Open(TestData.ValueObjects.Mpd mpd)
        {
            Search.MpdCanBeFoundById(mpd.Id);
        }

        public static void Check(TestData.ValueObjects.Mpd m)
        {
            Assert.AreEqual(m.Id, MpdView.Id);
            Assert.AreEqual(m.Description, MpdView.Description);
            Assert.AreEqual(m.Adress, MpdView.Adress);
            Assert.AreEqual(m.Port, MpdView.Port);
        }
    }
}