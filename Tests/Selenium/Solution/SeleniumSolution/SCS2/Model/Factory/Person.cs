namespace Six.Scs.QA.Application.Model.Factory
{
    public class Person
    {
        public static ValueObjects.Person Create()
        {
            return new ValueObjects.Person
            {
                FirstName = "SYR Contact" + Factory.GenerateTestId(),
                Name = "SYR - Create",
                Salutation = "Herr",
                Adress = Adress.Create(),
                Contact = Contact.Create(),
            };
        }

        public static ValueObjects.Person Edit()
        {
            return new ValueObjects.Person
            {
                FirstName = "SYR Contact" + Factory.GenerateTestId(),
                Name = "SYR - Edit",
                Salutation = "Frau",
                Adress = Adress.Edit(),
                Contact = Contact.Edit(),
            };
        }
    }
}