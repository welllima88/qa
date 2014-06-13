using System;
using SIX.SCS.Tests.Selenium.Extension.TestData;

namespace SIX.SCS.Tests.Selenium.TestData
{
    public class TestDataRepository : ITestDataRepository
    {
        public static ITestData Customer
        {
            get { return new CustomerData(); }
        }
    }

    public class NaviElement : INaviElement
    {
        public string GetUrl()
        {
            throw new NotImplementedException();
        }
    }
}