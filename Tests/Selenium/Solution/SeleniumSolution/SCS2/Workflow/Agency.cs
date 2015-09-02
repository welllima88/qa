using Six.Scs.Test.UI.Administration.Agency;

namespace Six.Scs.Test.Workflow
{
    public static class Agency

    {
        public static void Create(Model.Agency agency)
        {
            List.Create.Click();

            UI.Administration.Agency.Create.Name = agency.Name;
            UI.Administration.Agency.Create.DisplayName = agency.DisplayName;
            UI.Administration.Agency.Create.StreetNo = agency.Adress.StreetNo;
            UI.Administration.Agency.Create.Zip = agency.Adress.Zip;
            UI.Administration.Agency.Create.City = agency.Adress.City;
            UI.Administration.Agency.Create.Country = agency.Adress.Country;
            UI.Administration.Agency.Create.Supplier = agency.Supplier;
            UI.Administration.Agency.Create.SbsAgentId = agency.SbsAgentId;
            UI.Administration.Agency.Create.Status = agency.Status;

            UI.Administration.Agency.Create.SaveButton.Click();
        }

        public static void Edit(Model.Agency agency)
        {
            View.Edit();

            UI.Administration.Agency.Create.Name = agency.Name;
            UI.Administration.Agency.Create.DisplayName = agency.DisplayName;
            UI.Administration.Agency.Create.StreetNo = agency.Adress.StreetNo;
            UI.Administration.Agency.Create.Zip = agency.Adress.Zip;
            UI.Administration.Agency.Create.City = agency.Adress.City;
            UI.Administration.Agency.Create.Country = agency.Adress.Country;
            UI.Administration.Agency.Create.Supplier = agency.Supplier;
            UI.Administration.Agency.Create.SbsAgentId = agency.SbsAgentId;
            UI.Administration.Agency.Create.Status = agency.Status;
            UI.Administration.Agency.Create.SaveButton.Click();
        }

        public static void Deactivate()
        {
            View.Edit();

            UI.Administration.Agency.Create.Status = false;

            UI.Administration.Agency.Create.SaveButton.Click();
        }
    }
}