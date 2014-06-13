using System;
using SIX.SCS.Tests.Selenium.Extension.TestData;

namespace SIX.SCS.Tests.Selenium.TestData
{
    public class CustomerData : ITestData
    {
        public ITestData GetAny()
        {
            return null; // new CustomerData();
        }

        public ITestData GetById(string id)
        {
            throw new NotImplementedException();
        }

        public string GetUrlPart()
        {
            return "Pages/Customer/CustomerEdit.aspx?CustomerId=" + "401152";
        }
    }
}