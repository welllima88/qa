using NUnit.Framework;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.Selenium.Mpd;
using Six.Scs.QA.Selenium.SearchResult;
using Six.Scs.QA.Selenium.Terminal.Dashboard;
using Six.Scs.QA.Selenium.User;

namespace Six.Scs.QA.Testlogic
{
    public class Search
    {
        public static void CustomerCanBeFoundByCustomerNumber(string customerId)
        {
            Workflow.Search.Find(customerId);
            CustomerResult.Result().Click();

            Assert.AreEqual(customerId, CustomerView.CustomerNumber);
        }

        public static void LocationCanBeFoundByLocationName(string locationName)
        {
            Workflow.Search.Find(locationName);
            LocationResult.Result().Click();

            Assert.AreEqual(locationName, LocationView.CompanyName);
        }

        public static void CustomerCanBeFoundByCustomerName(string customerName)
        {
            Workflow.Search.Find(customerName);
            CustomerResult.Result().Click();

            Assert.AreEqual(customerName, CustomerView.CustomerName);
        }

        public static void TerminalCanBeFoundById(string terminalId)
        {
            Workflow.Search.Find(terminalId);
            TerminalResult.First().Click();

            Assert.AreEqual(terminalId, TerminalInfo.TerminalId);
        }

        public static void UserCanBeFoundByCustomerName(string userName)
        {
            Workflow.Search.Find(userName);
            UserResult.First().Click();

            Assert.AreEqual(userName, UserView.UserName);
        }

        public static void MpdCanBeFoundById(string id)
        {
            Workflow.Search.Find(id);
            MpdResult.First().Click();

            Assert.AreEqual(id, MpdView.Id);
        }
    }
}