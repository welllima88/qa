namespace Six.Scs.Test.Factory
{
    public class Customer
    {
        public static Model.Customer Create()
        {
            return new Model.Customer
            {
                Supplier = "SIX Payment Services AG",
                SbsCurrency = "Euro",
                SbsBillingTenant = "SIX Payment Services (Europe)",
                CustomerName = "SYR Customer Create" + Base.GenerateTestId(),
                CategoryCode = "3364: AGENCY RENT-A-CAR",
                SupportContract = "ServicePaket Top Account - Störungsbehebung vor Ort Mo-So 5h",
                CashIntegrator = "Wincor Nixdorf AG, Brüttisellen",
                SbsSegment = "01_CH",
                WesMandant = "tkcpos",
                Location = Location.Create()
            };
        }

        public static Model.Customer Edit()
        {
            return new Model.Customer
            {
                CustomerName = "SYR Customer Edit" + Base.GenerateTestId(),
                SbsSegment = "01_CH",
                Location = Location.Edit()
            };
        }

        public static Model.Customer Invalid()
        {
            return new Model.Customer
            {
                Supplier = "SIX Payment Services AG",
                SbsCurrency = "EUR",
                SbsBillingTenant = "SIX Payment Services (Europe)",
                CustomerName = "SYR Sele Kunde A$°",
                CustomerNumber = "^@}$°",
                SbsSegment = "01_CH",
                Location = Location.Invalid()
            };
        }
    }
}