using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.TestData.Factory
{
    public class AdressFactory
    {
        public static Adress Create()
        {
            return new Adress
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

        public static Adress Edit()
        {
            return new Adress
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

        public static Adress Invalid()
        {
            return new Adress
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