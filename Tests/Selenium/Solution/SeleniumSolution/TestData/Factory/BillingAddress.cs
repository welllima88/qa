namespace Six.Scs.QA.TestData.Factory
{
    public static class BillingAddress
    {
        public static ValueObjects.BillingAddress Create()
        {
            return new ValueObjects.BillingAddress
            {
                Adress = Adress.Create(),
                Contact = Contact.Create(),
                CompanyName = "SYR Billing Create" + Factory.GenerateTestId(),
            };
        }

        public static ValueObjects.BillingAddress Edit()
        {
            return new ValueObjects.BillingAddress
            {
                Adress = Adress.Edit(),
                Contact = Contact.Edit(),
                CompanyName = "SYR Billing Edit" + Factory.GenerateTestId(),
            };
        }
    }
}