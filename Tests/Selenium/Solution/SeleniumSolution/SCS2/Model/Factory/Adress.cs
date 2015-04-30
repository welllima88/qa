namespace Six.Scs.Test.Model.Factory
{
    public class Adress
    {
        public static ValueObjects.Adress Create()
        {
            return new ValueObjects.Adress
            {
                StreetNo = "Hardturmstr. 201",
                Zip = "8021",
                City = "Zürich",
                Po = "Po-O1",
                AdressAddition = "SYR",
                Region = "Reg 55",
                Country = "Schweiz [CH]"
            };
        }

        public static ValueObjects.Adress Edit()
        {
            return new ValueObjects.Adress
            {
                StreetNo = "Theater Platz 1a-3c",
                AdressAddition = "SYR/Stage 3",
                Po = "PFO1-44",
                Zip = "01067",
                City = "Dresden",
                Region = "Mitte",
                Country = "Deutschland [DE]"
            };
        }

        public static ValueObjects.Adress Invalid()
        {
            return new ValueObjects.Adress
            {
                StreetNo = "Hardturmstr. 201$°",
                Zip = "802$°",
                City = "Zürich$°",
                Po = "PFO1$°",
                AdressAddition = "Etage 3$°",
                Region = "Reg 3[]$°",
                Country = "Schweiz [CH]"
            };
        }
    }
}