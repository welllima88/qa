namespace Six.Scs.Test.Factory
{
    public static class BillingAddress
    {
        public static Model.BillingAddress Create()
        {
            return new Model.BillingAddress
            {
                Adress = Adress.Create(),
                Contact = Contact.Create(),
                CompanyName = "SYR Billing Create" + Base.GenerateTestId()
            };
        }

        public static Model.BillingAddress Edit()
        {
            return new Model.BillingAddress
            {
                Adress = Adress.Edit(),
                Contact = Contact.Edit(),
                CompanyName = "SYR Billing Edit" + Base.GenerateTestId()
            };
        }
    }
}