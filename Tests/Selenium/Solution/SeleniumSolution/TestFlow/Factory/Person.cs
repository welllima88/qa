namespace Six.Scs.Test.Factory
{
    public class Person
    {
        public static Model.Person Create()
        {
            return new Model.Person
            {
                FirstName = "SYR Contact" + Base.GenerateTestId(),
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
                FirstName = "SYR Contact" + Base.GenerateTestId(),
                Name = "SYR - Edit",
                Salutation = "Frau",
                Adress = Adress.Edit(),
                Contact = Contact.Edit()
            };
        }
    }
}