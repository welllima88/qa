using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.TestData.Factory
{
    public class LocationFactory
    {
        public static Location Create()
        {
            return new Location
            {
                Adress = AdressFactory.Create(),
                Contact = ContactFactory.Create(),
                CompanyName = "SYR Location Create" + Factory.GenerateTestId(),
                SapNumber = "4444",
                Ep2MerchantId = "",
            };
        }

        public static Location Edit()
        {
            return new Location
            {
                Adress = AdressFactory.Edit(),
                Contact = ContactFactory.Edit(),
                CompanyName = "SYR Location Edit" + Factory.GenerateTestId(),
                SapNumber = "1234",
            };
        }

        public static Location Invalid()
        {
            return new Location
            {
                Adress = AdressFactory.Invalid(),
                Contact = ContactFactory.Invalid(),
                SapNumber = "444$°",
                CompanyName = "444$°?",
                Ep2MerchantId = "12D%FF_3-3",
            };
        }
    }
}