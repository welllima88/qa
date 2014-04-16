using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.TestData
{
    public class CustomerFactory
    {
        public CustomerData Create()
        {
            return new CustomerData
            {
                Supplier = "SIX Payment Services AG",
                SbsCurrency = "Euro",
                SbsBillingTenant = "SIX Payment Services (Europe)",
                CustomerName = "SYR Customer Create" + Factory.GenerateTestId(),
                CategoryCode = "3364: AGENCY RENT-A-CAR",
                SupportContract = "ServicePaket Top Account - Störungsbehebung vor Ort Mo-So 5h",
                CashIntegrator = "Wincor Nixdorf AG, Brüttisellen",
                Segment = "01_CH",
                Agency = "B05 Leiser Peter",
                Location = Factory.Location.Create(),
            };
        }

        public CustomerData Edit()
        {
            return new CustomerData
            {
                CustomerName = "SYR Customer Edit" + Factory.GenerateTestId(),
                Location = Factory.Location.Edit(),
                Agency = "SIX Payment Services (Europe)",                
            };
        }

        public CustomerData Invalid()
        {
            return new CustomerData
            {
                Supplier = "SIX Payment Services AG",
                SbsCurrency = "EUR",
                SbsBillingTenant = "SIX Payment Services (Europe)",
                CustomerName = "SYR Sele Kunde A$°",
                CustomerNumber = "^@}$°",
                Agency = "Albert Brun & Partner",
                Location = Factory.Location.Invalid(),
            };
        }
    }
}