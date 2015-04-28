using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Application.View.Administration.Agency;
using Six.Scs.QA.Application.Workflow;

namespace Six.Scs.QA.Testlogic.Administration
{
    public class Agency
    {
        public static Application.Model.ValueObjects.Agency Create()
        {
            Application.Model.ValueObjects.Agency agency = Application.Model.Factory.Agency.Default();
            Application.Workflow.Agency.Create(agency);

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);

            return agency;
        }

        public static Application.Model.ValueObjects.Agency Edit(Application.Model.ValueObjects.Agency agency)
        {
            Lobby.OpenLatestElement();
            agency = Application.Model.Factory.Agency.Edit();
            Application.Workflow.Agency.Edit(agency);

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);

            return agency;
        }

        private static void Open(Application.Model.ValueObjects.Agency agency)
        {
            TestDirector.Navigate("Agency/List");
        }

        private static void Check(Application.Model.ValueObjects.Agency agency)
        {
            Assert.That(View.Status, Is.EqualTo(agency.Status));
            Assert.That(View.Name, Is.EqualTo(agency.Name));
            Assert.That(View.DisplayName, Is.EqualTo(agency.DisplayName));
            Assert.That(View.City, Is.EqualTo(agency.Adress.City));
            Assert.That(View.StreetNo, Is.EqualTo(agency.Adress.StreetNo));
            Assert.That(agency.Adress.Country, Is.StringMatching(View.Country)); // "Schweiz" vs "Schweiz [CH]"
            Assert.That(View.SbsAgentId, Is.EqualTo(agency.SbsAgentId));
            Assert.That(View.Supplier, Is.EqualTo(agency.Supplier));
        }

        public static void Deactivate(Application.Model.ValueObjects.Agency agency)
        {
            Lobby.OpenLatestElement();
            Application.Workflow.Agency.Deactivate();
            agency.Status = false;

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);
        }
    }
}