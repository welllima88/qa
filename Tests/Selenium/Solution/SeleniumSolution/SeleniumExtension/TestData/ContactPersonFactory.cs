using SIX.SCS.Tests.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.Tests.Selenium.Extension.TestData
{
    public class ContactPersonFactory
    {
        public ContactPersonData Create()
        {
            return new ContactPersonData
            {
                FirstName = "SYR Contact" + Factory.GenerateTestId(),
                Name = "SYR - Create",
                Salutation = "Herr",
                Adress = Factory.Adress.Create(),
                Contact = Factory.Contact.Create(),
            };
        }

        public ContactPersonData Edit()
        {
            return new ContactPersonData
            {
                FirstName = "SYR Contact" + Factory.GenerateTestId(),
                Name = "SYR - Edit",
                Salutation = "Frau",
                Adress = Factory.Adress.Edit(),
                Contact = Factory.Contact.Edit(),
            };
        }
    }
}