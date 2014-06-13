using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Location;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.SearchResult;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Terminal.Dashboard;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.User;

namespace SIX.SCS.Tests.Selenium.Extension.Worklow
{
    public static class SearchService
    {
        public static void CustomerCanBeFoundByCustomerNumber(string customerId)
        {
            QuickSearch.Find(customerId);
            CustomerResult.Result().Click();

            Assert.AreEqual(customerId, CustomerView.CustomerNumber);
        }

        public static void LocationCanBeFoundByLocationName(string locationName)
        {
            QuickSearch.Find(locationName);
            LocationResult.Result().Click();

            Assert.AreEqual(locationName, LocationView.CompanyName);
        }

        public static void CustomerCanBeFoundByCustomerName(string customerName)
        {
            QuickSearch.Find(customerName);
            CustomerResult.Result().Click();

            Assert.AreEqual(customerName, CustomerView.CustomerName);
        }

        public static void TerminalCanBeFoundById(string terminalId)
        {
            QuickSearch.Find(terminalId);
            TerminalResult.First().Click();

            Assert.AreEqual(terminalId, TerminalInfo.TerminalId);
        }

        public static void UserCanBeFoundByCustomerName(string userName)
        {
            QuickSearch.Find(userName);
            UserResult.First().Click();

            Assert.AreEqual(userName, UserView.UserName);
        }
    }
}