using Six.Scs.Tests.Selenium.Extension.TestObjects.Definitions;

namespace Six.Scs.Tests.Selenium.Extension.TestData
{
    public class UserFactory
    {
        public UserData Create()
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