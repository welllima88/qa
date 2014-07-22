using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.TestData.Factory
{
    public class ContactFactory
    {
        public static Contact Create()
        {
            return new Contact
            {
                Language = "Deutsch [de]",
                Email = "marc.siegmund@six-group.de",
                Telephone = "0031 58 399 6237",
                Mobile = "0032 58 399 6237",
                Fax = "0033 58 399 6237",
                Web = "www.six-group.com/de-intern",
            };
        }

        public static Contact Edit()
        {
            return new Contact
            {
                Language = "Englisch [en]",
                Email = "marc.siegmund@six-group.uk",
                Telephone = "+31 - 58 399 6237",
                Mobile = "+32 - 58 399 6237",
                Fax = "+33 - 58 399 6237",
                Web = "www.six-group.com/en-intern"
            };
        }

        public static Contact Invalid()
        {
            return new Contact
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