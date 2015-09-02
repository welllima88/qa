namespace Six.Scs.Test.Factory
{
    public class Contact
    {
        public static Model.Contact Create()
        {
            return new Model.Contact
            {
                Language = "Deutsch [de]",
                Email = "marc.siegmund@six-group.de",
                Telephone = "0031 58 399 6237",
                Mobile = "0032 58 399 6237",
                Fax = "0033 58 399 6237",
                Web = "www.six-group.com/de-intern"
            };
        }

        public static Model.Contact Edit()
        {
            return new Model.Contact
            {
                Language = "Englisch [en]",
                Email = "marc.siegmund@six-group.proof",
                Telephone = "+31 - 58 399 6237",
                Mobile = "+32 - 58 399 6237",
                Fax = "+33 - 58 399 6237",
                Web = "www.six-group.com/en-intern"
            };
        }

        public static Model.Contact Invalid()
        {
            return new Model.Contact
            {
                Language = "Deutsch [de]",
                Email = "marc.siegmund@six-grou$°p.com",
                Telephone = "0031 58 399 6237$",
                Mobile = "0032 58 399 6237$",
                Fax = "0033 58 399 6237$",
                Web = "www.six-^°@}$.com/de-inte[]rn$°"
            };
        }
    }
}