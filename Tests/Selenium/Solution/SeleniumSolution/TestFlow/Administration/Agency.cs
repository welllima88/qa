using NUnit.Framework;
using Six.Scs.Test.Workflow;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Administration
{
    public class Agency
    {
        public static Model.Agency Create()
        {
            var agency = Factory.Agency.Default();
            Workflow.Agency.Create(agency);

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);

            return agency;
        }

        public static Model.Agency Edit(Model.Agency agency)
        {
            Lobby.OpenLatestElement();
            agency = Factory.Agency.Edit();
            Workflow.Agency.Edit(agency);

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);

            return agency;
        }

        private static void Open(Model.Agency agency)
        {
            TestDirector.Navigate("Agency/List");
        }

        private static void Check(Model.Agency agency)
        {
            Assert.That(View.Administration.Agency.View.Status, Is.EqualTo(agency.Status));
            Assert.That(View.Administration.Agency.View.Name, Is.EqualTo(agency.Name));
            Assert.That(View.Administration.Agency.View.DisplayName, Is.EqualTo(agency.DisplayName));
            Assert.That(View.Administration.Agency.View.City, Is.EqualTo(agency.Adress.City));
            Assert.That(View.Administration.Agency.View.StreetNo, Is.EqualTo(agency.Adress.StreetNo));
            Assert.That(agency.Adress.Country, Is.StringMatching(View.Administration.Agency.View.Country));
            // "Schweiz" vs "Schweiz [CH]"
            Assert.That(View.Administration.Agency.View.SbsAgentId, Is.EqualTo(agency.SbsAgentId));
            Assert.That(View.Administration.Agency.View.Supplier, Is.EqualTo(agency.Supplier));
        }

        public static void Deactivate(Model.Agency agency)
        {
            Lobby.OpenLatestElement();
            Workflow.Agency.Deactivate();
            agency.Status = false;

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);
        }
    }
}