using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.TestObjects.Customer;
using Six.Scs.QA.Selenium.Extension.TestObjects.Location;
using Six.Scs.QA.Selenium.Extension.TestObjects.SearchResult;
using Six.Scs.QA.Selenium.Extension.TestObjects.Terminal.Dashboard;
using Six.Scs.QA.Selenium.Extension.TestObjects.User;

namespace Six.Scs.QA.Selenium.Extension.Worklow
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