using System;
using Six.Scs.Tests.Selenium.Extension.TestData;

namespace Six.Scs.Tests.Selenium.TestData
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