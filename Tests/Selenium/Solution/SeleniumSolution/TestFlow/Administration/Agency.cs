using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Administration.Agency;
using Six.Scs.QA.Selenium.Workflow;

namespace Six.Scs.QA.Testlogic.Administration
{
    public class Agency
    {
        public static Selenium.Model.ValueObjects.Agency Create()
        {
            Selenium.Model.ValueObjects.Agency agency = Selenium.Model.Factory.Agency.Default();
            Selenium.Workflow.Agency.Create(agency);

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);

            return agency;
        }

        public static Selenium.Model.ValueObjects.Agency Edit(Selenium.Model.ValueObjects.Agency agency)
        {
            Lobby.OpenLatestElement();
            agency = Selenium.Model.Factory.Agency.Edit();
            Selenium.Workflow.Agency.Edit(agency);

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);

            return agency;
        }

        private static void Open(Selenium.Model.ValueObjects.Agency agency)
        {
            TestDirector.Navigate("Agency/List");
        }

        private static void Check(Selenium.Model.ValueObjects.Agency agency)
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

        public static void Deactivate(Selenium.Model.ValueObjects.Agency agency)
        {
            Lobby.OpenLatestElement();
            Selenium.Workflow.Agency.Deactivate();
            agency.Status = false;

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);
        }
    }
}