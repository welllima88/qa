using TestData.ValueObjects;

namespace TestData.Factory
{
    public class LocationFactory
    {
        public static LocationData Create()
        {
            return new LocationData
            {
                Adress = AdressFactory.Create(),
                Contact = ContactFactory.Create(),
                CompanyName = "SYR Location Create" + Factory.GenerateTestId(),
                SapNumber = "4444",
                Ep2MerchantId = "",
            };
        }

        public static LocationData Edit()
        {
            return new LocationData
            {
                Adress = AdressFactory.Edit(),
                Contact = ContactFactory.Edit(),
                CompanyName = "SYR Location Edit" + Factory.GenerateTestId(),
                SapNumber = "1234",
            };
        }

        public static LocationData Invalid()
        {
            return new LocationData
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