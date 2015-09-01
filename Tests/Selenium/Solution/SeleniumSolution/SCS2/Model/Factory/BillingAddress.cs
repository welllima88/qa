namespace Six.Scs.Test.Model.Factory
{
    public static class BillingAddress
    {
        public static Model.BillingAddress Create()
        {
            return new Model.BillingAddress
            {
                Adress = Adress.Create(),
                Contact = Contact.Create(),
                CompanyName = "SYR Billing Create" + Factory.GenerateTestId()
            };
        }

        public static Model.BillingAddress Edit()
        {
            return new Model.BillingAddress
            {
                Adress = Adress.Edit(),
                Contact = Contact.Edit(),
                CompanyName = "SYR Billing Edit" + Factory.GenerateTestId()
            };
        }
    }
}