using Six.Scs.Tests.Selenium.Extension.TestObjects.Definitions;

namespace Six.Scs.Tests.Selenium.Extension.TestData
{
    public class LocationFactory
    {
        public LocationData Create()
        {
            return new LocationData
            {
                Adress = Factory.Adress.Create(),
                Contact = Factory.Contact.Create(),
                CompanyName = "SYR Location Create" + Factory.GenerateTestId(),
                SapNumber = "4444",
                Ep2MerchantId = "",
            };
        }

        public LocationData Edit()
        {
            return new LocationData
            {
                Adress = Factory.Adress.Edit(),
                Contact = Factory.Contact.Edit(),
                CompanyName = "SYR Location Edit" + Factory.GenerateTestId(),
                SapNumber = "1234",
            };
        }

        public LocationData Invalid()
        {
            return new LocationData
            {
                Adress = Factory.Adress.Invalid(),
                Contact = Factory.Contact.Invalid(),
                SapNumber = "444$°",
                CompanyName = "444$°?",
                Ep2MerchantId = "12D%FF_3-3",
            };
        }
    }
}