using System;

namespace SIX.SCS.Tests.Selenium.Extension.TestData
{
    public static class Factory
    {
        public static CustomerFactory Customer
        {
            get { return new CustomerFactory(); }
        }

        public static LocationFactory Location
        {
            get { return new LocationFactory(); }
        }

        public static ContactFactory Contact
        {
            get { return new ContactFactory(); }
        }

        public static AdressFactory Adress
        {
            get { return new AdressFactory(); }
        }

        public static ContactPersonFactory ContactPerson
        {
            get { return new ContactPersonFactory(); }
        }

        public static MpdFactory Mpd
        {
            get { return new MpdFactory(); }
        }

        public static UserFactory User
        {
            get { return new UserFactory(); }
        }

        public static string GenerateTestId()
        {
            return DateTime.Now.Ticks.ToString();
        }
    }
}