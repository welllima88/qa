using Six.Scs.QA.Selenium.Administration.Agency;

namespace Six.Scs.QA.Workflow
{
    public static class Agency

    {
        public static void Create(TestData.ValueObjects.Agency agency)
        {
            List.Create.Click();

            Selenium.Administration.Agency.Create.Name = agency.Name;
            Selenium.Administration.Agency.Create.DisplayName = agency.DisplayName;
            Selenium.Administration.Agency.Create.StreetNo = agency.Adress.StreetNo;
            Selenium.Administration.Agency.Create.Zip = agency.Adress.Zip;
            Selenium.Administration.Agency.Create.City = agency.Adress.City;
            Selenium.Administration.Agency.Create.Country = agency.Adress.Country;
            Selenium.Administration.Agency.Create.Language = agency.Contact.Language;
            Selenium.Administration.Agency.Create.Telephone = agency.Contact.Telephone;
            Selenium.Administration.Agency.Create.Supplier = agency.Supplier;
            Selenium.Administration.Agency.Create.SbsAgentId = agency.SbsAgentId;
            Selenium.Administration.Agency.Create.Status = agency.Status;

            Selenium.Administration.Agency.Create.SaveButton.Click();
        }

        public static void Edit(TestData.ValueObjects.Agency agency)
        {
            View.Edit();

            Selenium.Administration.Agency.Create.Name = agency.Name;
            Selenium.Administration.Agency.Create.DisplayName = agency.DisplayName;
            Selenium.Administration.Agency.Create.StreetNo = agency.Adress.StreetNo;
            Selenium.Administration.Agency.Create.Zip = agency.Adress.Zip;
            Selenium.Administration.Agency.Create.City = agency.Adress.City;
            Selenium.Administration.Agency.Create.Country = agency.Adress.Country;
            Selenium.Administration.Agency.Create.Language = agency.Contact.Language;
            Selenium.Administration.Agency.Create.Telephone = agency.Contact.Telephone;
            Selenium.Administration.Agency.Create.Supplier = agency.Supplier;
            Selenium.Administration.Agency.Create.SbsAgentId = agency.SbsAgentId;
            Selenium.Administration.Agency.Create.Status = agency.Status;

            Selenium.Administration.Agency.Create.SaveButton.Click();
        }

        public static void Deactivate()
        {
            View.Edit();

            Selenium.Administration.Agency.Create.Status = false;

            Selenium.Administration.Agency.Create.SaveButton.Click();
        }
    }
}