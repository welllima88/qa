using NUnit.Framework;
using Six.Scs.QA.Selenium.View.Customer;
using Six.Scs.QA.Selenium.View.Search;
using Six.Scs.QA.Selenium.View.Terminal.Dashboard;

namespace Six.Scs.QA.Testlogic
{
    public class Search
    {
        public static void CustomerCanBeFoundByCustomerNumber(string customerId)
        {
            Selenium.Workflow.Search.Find(customerId);
            new SearchResult(Result.Customer).First().Click();

            Assert.AreEqual(customerId, View.CustomerNumber);
        }

        public static void LocationCanBeFoundByLocationName(string locationName)
        {
            Selenium.Workflow.Search.Find(locationName);
            new SearchResult(Result.Location).First().Click();

            Assert.AreEqual(locationName, Selenium.View.Location.View.CompanyName);
        }

        public static void CustomerCanBeFoundByCustomerName(string customerName)
        {
            Selenium.Workflow.Search.Find(customerName);
            new SearchResult(Result.Customer).First().Click();

            Assert.AreEqual(customerName, View.CustomerName);
        }

        public static void TerminalCanBeFoundById(string terminalId)
        {
            Selenium.Workflow.Search.Find(terminalId);
            new SearchResult(Result.Terminal).First().Click();

            Assert.AreEqual(terminalId, TerminalInfo.TerminalId);
        }

        public static void UserCanBeFoundByCustomerName(string userName)
        {
            Selenium.Workflow.Search.Find(userName);
            new SearchResult(Result.User).First().Click();

            Assert.AreEqual(userName, Selenium.View.User.View.UserName);
        }

        public static void MpdCanBeFoundById(string id)
        {
            Selenium.Workflow.Search.Find(id);
            new SearchResult(Result.Mpd).First().Click();

            Assert.AreEqual(id, Selenium.View.Mpd.View.Id);
        }

        public static void SimcardBySimCardNumber(string simCardNumber)
        {
            Selenium.Workflow.Search.Find(simCardNumber);
            new SearchResult(Result.SimCard).First().Click();

            Assert.AreEqual(simCardNumber, Selenium.View.Administration.SimCard.View.SimCardNumber);
        }

        public static void TicketCanBeFoundById(string ticketId)
        {
            Selenium.Workflow.Search.Find(ticketId);
            new SearchResult(Result.Ticket).First().Click();

            StringAssert.Contains(ticketId, Selenium.View.Tickets.Trouble.View.Header);
        }
    }
}