using NUnit.Framework;
using Six.Scs.QA.Selenium.Mpd;

namespace Six.Scs.QA.Testlogic
{
    public class Mpd
    {
        public static TestData.ValueObjects.Mpd Create(TestData.ValueObjects.Customer customer)
        {
            Customer.Open(customer);

            TestData.ValueObjects.Mpd mpd = TestData.Factory.Mpd.Create();
            Workflow.Mpd.Create(mpd);
            Check(mpd);

            Workflow.Lobby.OpenLatestElement();
            Check(mpd);
            return mpd;
        }

        public static TestData.ValueObjects.Mpd Edit(TestData.ValueObjects.Mpd _mpd)
        {
            Open(_mpd);
            TestData.ValueObjects.Mpd mpd = TestData.Factory.Mpd.Create();
            mpd.Id = _mpd.Id; // keep Id

            Workflow.Mpd.Edit(mpd);
            Check(mpd);

            Workflow.Lobby.OpenLatestElement();
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