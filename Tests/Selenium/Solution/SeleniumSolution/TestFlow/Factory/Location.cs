﻿namespace Six.Scs.Test.Factory
{
    public class Location
    {
        public static Model.Location Create()
        {
            return new Model.Location
            {
                Adress = Adress.Create(),
                Contact = Contact.Create(),
                CompanyName = "SYR Location Create" + Base.GenerateTestId(),
                SapNumber = "4444",
                Agency = "B05 Leiser Peter",
                Ep2MerchantId = ""
            };
        }

        public static Model.Location Edit()
        {
            return new Model.Location
            {
                Adress = Adress.Edit(),
                Contact = Contact.Edit(),
                CompanyName = "SYR Location Edit" + Base.GenerateTestId(),
                SapNumber = "1234",
                Agency = "SIX Payment Services (Europe)"
            };
        }

        public static Model.Location Invalid()
        {
            return new Model.Location
            {
                Adress = Adress.Invalid(),
                Contact = Contact.Invalid(),
                SapNumber = "444$°",
                CompanyName = "444$°?",
                Ep2MerchantId = "12D%FF_3-3",
                Agency = "Albert Brun & Partner"
            };
        }
    }
}