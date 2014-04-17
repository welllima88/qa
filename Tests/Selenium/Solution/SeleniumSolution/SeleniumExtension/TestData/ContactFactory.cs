using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.TestData
{
    public class ContactFactory
    {
        public ContactData Create()
        {
            return new ContactData
            {
                Language = "Deutsch [de]",
                Email = "marc.siegmund@six-group.de",
                Telephone = "0031 58 399 6237",
                Mobile = "0032 58 399 6237",
                Fax = "0033 58 399 6237",
                Web = "www.six-group.com/de-intern",
            };
        }

        public ContactData Edit()
        {
            return new ContactData
            {
                Language = "Englisch [en]",
                Email = "marc.siegmund@six-group.uk",
                Telephone = "+31 - 58 399 6237",
                Mobile = "+32 - 58 399 6237",
                Fax = "+33 - 58 399 6237",
                Web = "www.six-group.com/en-intern"
            };
        }

        public ContactData Invalid()
        {
            return new ContactData
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