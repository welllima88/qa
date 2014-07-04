using NUnit.Framework;
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
            Find(customerId);
            CustomerResult.Result().Click();

            Assert.AreEqual(customerId, CustomerView.CustomerNumber);
        }

        public static void LocationCanBeFoundByLocationName(string locationName)
        {
            Find(locationName);
            LocationResult.Result().Click();

            Assert.AreEqual(locationName, LocationView.CompanyName);
        }

        public static void CustomerCanBeFoundByCustomerName(string customerName)
        {
            Find(customerName);
            CustomerResult.Result().Click();

            Assert.AreEqual(customerName, CustomerView.CustomerName);
        }

        public static void TerminalCanBeFoundById(string terminalId)
        {
            Find(terminalId);
            TerminalResult.First().Click();

            Assert.AreEqual(terminalId, TerminalInfo.TerminalId);
        }

        public static void UserCanBeFoundByCustomerName(string userName)
        {
            Find(userName);
            UserResult.First().Click();

            Assert.AreEqual(userName, UserView.UserName);
        }

        public static void Find(string searchString)
        {
            QuickSearch.SearchField = searchString;
            QuickSearch.HitEnter();
        }
    }
}