using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;

namespace Six.Scs.QA.Selenium.Extension.TestData.Factory
{
    public class UserFactory
    {
        public static UserData Create()
        {
            return new UserData
            {
                UserName = "s" + Factory.GenerateTestId(),
                Salutation = "Herr",
                FirstName = "SYR User" + Factory.GenerateTestId(),
                Name = "SYR User",
                Language = "Deutsch [de]",
                Email = "marc.siegmund@six-group.com",
                SecurId = "tksyr",
                Comment = "User created by automated test",
                WesMandant = "TKCPOS",
            };
        }
    }
}