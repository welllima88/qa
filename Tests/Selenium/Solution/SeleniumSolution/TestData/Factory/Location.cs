namespace Six.Scs.QA.TestData.Factory
{
    public class Location
    {
        public static ValueObjects.Location Create()
        {
            return new ValueObjects.Location
            {
                Adress = Adress.Create(),
                Contact = Contact.Create(),
                CompanyName = "SYR Location Create" + Factory.GenerateTestId(),
                SapNumber = "4444",
                Agency = "B05 Leiser Peter",
                Ep2MerchantId = "",
            };
        }

        public static ValueObjects.Location Edit()
        {
            return new ValueObjects.Location
            {
                Adress = Adress.Edit(),
                Contact = Contact.Edit(),
                CompanyName = "SYR Location Edit" + Factory.GenerateTestId(),
                SapNumber = "1234",
                Agency = "SIX Payment Services (Europe)",
            };
        }

        public static ValueObjects.Location Invalid()
        {
            return new ValueObjects.Location
            {
                Adress = Adress.Invalid(),
                Contact = Contact.Invalid(),
                SapNumber = "444$°",
                CompanyName = "444$°?",
                Ep2MerchantId = "12D%FF_3-3",
                Agency = "Albert Brun & Partner",
            };
        }
    }
}