namespace Six.Scs.Test.Model.Factory
{
    public class Person
    {
        public static Model.Person Create()
        {
            return new Model.Person
            {
                FirstName = "SYR Contact" + Factory.GenerateTestId(),
                Name = "SYR - Create",
                Salutation = "Herr",
                Adress = Adress.Create(),
                Contact = Contact.Create()
            };
        }

        public static Model.Person Edit()
        {
            return new Model.Person
            {
                FirstName = "SYR Contact" + Factory.GenerateTestId(),
                Name = "SYR - Edit",
                Salutation = "Frau",
                Adress = Adress.Edit(),
                Contact = Contact.Edit()
            };
        }
    }
}