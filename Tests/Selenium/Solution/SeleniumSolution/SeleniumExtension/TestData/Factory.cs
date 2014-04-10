using System;

namespace SIX.SCS.QA.Selenium.Extension.TestData
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

        public static string GenerateTestId()
        {
            return DateTime.Now.Ticks.ToString();
        }
    }

    public class ContactFactory
    {
    }

    public class LocationFactory
    {
    }
}