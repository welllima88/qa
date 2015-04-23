namespace Six.Scs.QA.Selenium.Model.Factory
{
    public class Customer
    {
        public static ValueObjects.Customer Create()
        {
            return new ValueObjects.Customer
            {
                Supplier = "SIX Payment Services AG",
                SbsCurrency = "Euro",
                SbsBillingTenant = "SIX Payment Services (Europe)",
                CustomerName = "SYR Customer Create" + Factory.GenerateTestId(),
                CategoryCode = "3364: AGENCY RENT-A-CAR",
                SupportContract = "ServicePaket Top Account - Störungsbehebung vor Ort Mo-So 5h",
                CashIntegrator = "Wincor Nixdorf AG, Brüttisellen",
                SbsSegment = "01_CH",
                WesMandant = "TKCPOS",
                Location = Location.Create(),
            };
        }

        public static ValueObjects.Customer Edit()
        {
            return new ValueObjects.Customer
            {
                CustomerName = "SYR Customer Edit" + Factory.GenerateTestId(),
                Location = Location.Edit(),
            };
        }

        public static ValueObjects.Customer Invalid()
        {
            return new ValueObjects.Customer
            {
                Supplier = "SIX Payment Services AG",
                SbsCurrency = "EUR",
                SbsBillingTenant = "SIX Payment Services (Europe)",
                CustomerName = "SYR Sele Kunde A$°",
                CustomerNumber = "^@}$°",
                Location = Location.Invalid(),
            };
        }
    }
}