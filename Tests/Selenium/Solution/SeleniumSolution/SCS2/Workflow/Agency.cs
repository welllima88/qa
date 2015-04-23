using Six.Scs.QA.Selenium.View.Administration.Agency;

namespace Six.Scs.QA.Selenium.Workflow
{
    public static class Agency

    {
        public static void Create(Selenium.Model.ValueObjects.Agency agency)
        {
            List.Create.Click();

            View.Administration.Agency.Create.Name = agency.Name;
            View.Administration.Agency.Create.DisplayName = agency.DisplayName;
            View.Administration.Agency.Create.StreetNo = agency.Adress.StreetNo;
            View.Administration.Agency.Create.Zip = agency.Adress.Zip;
            View.Administration.Agency.Create.City = agency.Adress.City;
            View.Administration.Agency.Create.Country = agency.Adress.Country;
            View.Administration.Agency.Create.Supplier = agency.Supplier;
            View.Administration.Agency.Create.SbsAgentId = agency.SbsAgentId;
            View.Administration.Agency.Create.Status = agency.Status;

            View.Administration.Agency.Create.SaveButton.Click();
        }

        public static void Edit(Selenium.Model.ValueObjects.Agency agency)
        {
            View.Administration.Agency.View.Edit();

            View.Administration.Agency.Create.Name = agency.Name;
            View.Administration.Agency.Create.DisplayName = agency.DisplayName;
            View.Administration.Agency.Create.StreetNo = agency.Adress.StreetNo;
            View.Administration.Agency.Create.Zip = agency.Adress.Zip;
            View.Administration.Agency.Create.City = agency.Adress.City;
            View.Administration.Agency.Create.Country = agency.Adress.Country;
            View.Administration.Agency.Create.Supplier = agency.Supplier;
            View.Administration.Agency.Create.SbsAgentId = agency.SbsAgentId;
            View.Administration.Agency.Create.Status = agency.Status;
            View.Administration.Agency.Create.SaveButton.Click();
        }

        public static void Deactivate()
        {
            View.Administration.Agency.View.Edit();

            View.Administration.Agency.Create.Status = false;

            View.Administration.Agency.Create.SaveButton.Click();
        }
    }
}