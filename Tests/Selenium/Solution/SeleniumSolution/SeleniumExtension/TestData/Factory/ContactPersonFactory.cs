using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;

namespace Six.Scs.QA.Selenium.Extension.TestData.Factory
{
    public class ContactPersonFactory
    {
        public static ContactPersonData Create()
        {
            return new ContactPersonData
            {
                FirstName = "SYR Contact" + Factory.GenerateTestId(),
                Name = "SYR - Create",
                Salutation = "Herr",
                Adress = AdressFactory.Create(),
                Contact = ContactFactory.Create(),
            };
        }

        public static ContactPersonData Edit()
        {
            return new ContactPersonData
            {
                FirstName = "SYR Contact" + Factory.GenerateTestId(),
                Name = "SYR - Edit",
                Salutation = "Frau",
                Adress = AdressFactory.Edit(),
                Contact = ContactFactory.Edit(),
            };
        }
    }
}