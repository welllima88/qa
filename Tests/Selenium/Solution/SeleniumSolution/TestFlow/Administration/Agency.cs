using NUnit.Framework;
using Six.Scs.Test.Workflow;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Administration
{
    public class Agency
    {
        public static Model.ValueObjects.Agency Create()
        {
            var agency = Model.Factory.Agency.Default();
            Workflow.Agency.Create(agency);

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);

            return agency;
        }

        public static Model.ValueObjects.Agency Edit(Model.ValueObjects.Agency agency)
        {
            Lobby.OpenLatestElement();
            agency = Model.Factory.Agency.Edit();
            Workflow.Agency.Edit(agency);

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);

            return agency;
        }

        private static void Open(Model.ValueObjects.Agency agency)
        {
            TestDirector.Navigate("Agency/List");
        }

        private static void Check(Model.ValueObjects.Agency agency)
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

        public static void Deactivate(Model.ValueObjects.Agency agency)
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