using NUnit.Framework;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Search;
using Six.Scs.QA.Selenium.Terminal.Dashboard;

namespace Six.Scs.QA.Testlogic
{
    public class Search
    {
        public static void CustomerCanBeFoundByCustomerNumber(string customerId)
        {
            Workflow.Search.Find(customerId);
            new SearchResult(Result.Customer).First().Click();

            Assert.AreEqual(customerId, View.CustomerNumber);
        }

        public static void LocationCanBeFoundByLocationName(string locationName)
        {
            Workflow.Search.Find(locationName);
            new SearchResult(Result.Location).First().Click();

            Assert.AreEqual(locationName, Selenium.Location.View.CompanyName);
        }

        public static void CustomerCanBeFoundByCustomerName(string customerName)
        {
            Workflow.Search.Find(customerName);
            new SearchResult(Result.Customer).First().Click();

            Assert.AreEqual(customerName, View.CustomerName);
        }

        public static void TerminalCanBeFoundById(string terminalId)
        {
            Workflow.Search.Find(terminalId);
            new SearchResult(Result.Terminal).First().Click();

            Assert.AreEqual(terminalId, TerminalInfo.TerminalId);
        }

        public static void UserCanBeFoundByCustomerName(string userName)
        {
            Workflow.Search.Find(userName);
            new SearchResult(Result.User).First().Click();

            Assert.AreEqual(userName, Selenium.User.View.UserName);
        }

        public static void MpdCanBeFoundById(string id)
        {
            Workflow.Search.Find(id);
            new SearchResult(Result.Mpd).First().Click();

            Assert.AreEqual(id, Selenium.Mpd.View.Id);
        }

        public static void SimcardBySimCardNumber(string simCardNumber)
        {
            Workflow.Search.Find(simCardNumber);
            new SearchResult(Result.SimCard).First().Click();

            Assert.AreEqual(simCardNumber, Selenium.Administration.SimCard.View.SimCardNumber);
        }
    }
}