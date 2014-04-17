using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.TestData
{
    public class UserFactory
    {
        public UserData Create()
        {
            return new UserData
            {
                UserName = "",
                Salutation = "Herr",
                FirstName = "SYR User" + Factory.GenerateTestId(),
                Name = "SYR User",
                Language = "Deutsch [DE]",
                Email = "marc.siegmund@six-group.com",
                SecurId = "",
                Comment = "User created by automated test",
                WesMandant = "TKCPOS",
            };
        }
    }
}