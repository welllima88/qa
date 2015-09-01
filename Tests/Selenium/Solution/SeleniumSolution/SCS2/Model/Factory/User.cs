namespace Six.Scs.Test.Model.Factory
{
    public class User
    {
        public static Model.User Create()
        {
            return new Model.User
            {
                UserName = "s" + Factory.GenerateTestId(),
                Salutation = "Herr",
                FirstName = "SYR User" + Factory.GenerateTestId(),
                Name = "SYR User",
                Language = "Deutsch [de]",
                Email = "marc.siegmund@six-group.com",
                SecurId = "tksyr",
                Comment = "User created by automated test",
                WesMandant = "tkcpos"
            };
        }
    }
}