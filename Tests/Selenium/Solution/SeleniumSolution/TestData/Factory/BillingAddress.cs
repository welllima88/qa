namespace Six.Scs.QA.TestData.Factory
{
    public static class BillingAddress
    {
        public static ValueObjects.BillinngAddress Create()
        {
            return new ValueObjects.BillinngAddress
            {
                Adress = Adress.Create(),
                Contact = Contact.Create(),
                CompanyName = "SYR Billing Create" + Factory.GenerateTestId(),                
            };
        }
        public static ValueObjects.BillinngAddress Edit()
        {
            return new ValueObjects.BillinngAddress
            {
                Adress = Adress.Edit(),
                Contact = Contact.Edit(),
                CompanyName = "SYR Billing Edit" + Factory.GenerateTestId(),                
            };
        }
    }
}