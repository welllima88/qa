using Six.Scs.QA.Selenium.Extension.TestObjects.Definitions;

namespace Six.Scs.QA.Selenium.Extension.TestData
{
    public class AdressFactory
    {
        public static AdressData Create()
        {
            return new AdressData
            {
                StreetNo = "Hardturmstr. 201",
                Zip = "8021",
                City = "Zürich",
                Po = "Po-O1",
                AdressAddition = "SYR",
                Region = "Reg 55",
                Country = "Schweiz [CH]",
            };
        }

        public static AdressData Edit()
        {
            return new AdressData
            {
                StreetNo = "Theater Platz 1a-3c",
                AdressAddition = "SYR/Stage 3",
                Po = "PFO1-44",
                Zip = "01067",
                City = "Dresden",
                Region = "Mitte",
                Country = "Deutschland [DE]",
            };
        }

        public static AdressData Invalid()
        {
            return new AdressData
            {
                StreetNo = "Hardturmstr. 201$°",
                Zip = "802$°",
                City = "Zürich$°",
                Po = "PFO1$°",
                AdressAddition = "Etage 3$°",
                Region = "Reg 3[]$°",
                Country = "Schweiz [CH]",
            };
        }
    }
}