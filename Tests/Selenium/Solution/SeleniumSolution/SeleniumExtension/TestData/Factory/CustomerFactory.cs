using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;

namespace Six.Scs.QA.Selenium.Extension.TestData.Factory
{
    public class CustomerFactory
    {
        public static CustomerData Create()
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
                Location = LocationFactory.Create(),
            };
        }

        public static CustomerData Edit()
        {
            return new CustomerData
            {
                CustomerName = "SYR Customer Edit" + Factory.GenerateTestId(),
                Location = LocationFactory.Edit(),
                Agency = "SIX Payment Services (Europe)",                
            };
        }

        public static CustomerData Invalid()
        {
            return new CustomerData
            {
                Supplier = "SIX Payment Services AG",
                SbsCurrency = "EUR",
                SbsBillingTenant = "SIX Payment Services (Europe)",
                CustomerName = "SYR Sele Kunde A$°",
                CustomerNumber = "^@}$°",
                Agency = "Albert Brun & Partner",
                Location = LocationFactory.Invalid(),
            };
        }
    }
}