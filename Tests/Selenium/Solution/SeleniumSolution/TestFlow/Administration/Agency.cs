using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Administration.Agency;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic.Administration
{
    public class Agency
    {
        public static TestData.ValueObjects.Agency Create()
        {
            TestData.ValueObjects.Agency agency = TestData.Factory.Agency.Default();
            Workflow.Agency.Create(agency);

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);

            return agency;
        }

        public static TestData.ValueObjects.Agency Edit(TestData.ValueObjects.Agency agency)
        {
            Lobby.OpenLatestElement();
            agency = TestData.Factory.Agency.Edit();
            Workflow.Agency.Edit(agency);

            Check(agency);
            Lobby.OpenLatestElement();
            Check(agency);

            return agency;
        }

        private static void Open(TestData.ValueObjects.Agency agency)
        {
            TestDirector.Navigate("Agency/List");
        }

        private static void Check(TestData.ValueObjects.Agency agency)
        {
            Assert.That(View.Status, Is.EqualTo(agency.Status));
            Assert.That(View.Name, Is.EqualTo(agency.Name));
            Assert.That(View.DisplayName, Is.EqualTo(agency.DisplayName));
            Assert.That(View.City, Is.EqualTo(agency.Adress.City));
            Assert.That(agency.Adress.Country, Is.StringMatching(View.Country)); // "Schweiz" vs "Schweiz [CH]"
            Assert.That(View.Telephone, Is.EqualTo(agency.Contact.Telephone));
            Assert.That(View.Language, Is.EqualTo(agency.Contact.Language));
            Assert.That(View.SbsAgentId, Is.EqualTo(agency.SbsAgentId));
            Assert.That(View.Supplier, Is.EqualTo(agency.Supplier));
        }

        public static void Deactivate(TestData.ValueObjects.Agency agency)
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