using NUnit.Framework;
using Six.Scs.Test.View.Search;
using Six.Scs.Test.View.Terminal.Dashboard;

namespace Six.Scs.Test
{
    public class Search
    {
        public static void CustomerCanBeFoundByCustomerNumber(string customerId)
        {
            Test.Workflow.Search.Find(customerId);
            new SearchResult(Result.Customer).First().Click();

            Assert.AreEqual(customerId, View.Customer.View.CustomerNumber);
        }

        public static void LocationCanBeFoundByLocationName(string locationName)
        {
            Test.Workflow.Search.Find(locationName);
            new SearchResult(Result.Location).First().Click();

            Assert.AreEqual(locationName, Test.View.Location.View.CompanyName);
        }

        public static void CustomerCanBeFoundByCustomerName(string customerName)
        {
            Test.Workflow.Search.Find(customerName);
            new SearchResult(Result.Customer).First().Click();

            Assert.AreEqual(customerName, View.Customer.View.CustomerName);
        }

        public static void TerminalCanBeFoundById(string terminalId)
        {
            Test.Workflow.Search.Find(terminalId);
            new SearchResult(Result.Terminal).First().Click();

            Assert.AreEqual(terminalId, TerminalInfo.TerminalId);
        }

        public static void UserCanBeFoundByCustomerName(string userName)
        {
            Test.Workflow.Search.Find(userName);
            new SearchResult(Result.User).First().Click();

            Assert.AreEqual(userName, Test.View.User.View.UserName);
        }

        public static void MpdCanBeFoundById(string id)
        {
            Test.Workflow.Search.Find(id);
            new SearchResult(Result.Mpd).First().Click();

            Assert.AreEqual(id, Test.View.Mpd.View.Id);
        }

        public static void SimcardBySimCardNumber(string simCardNumber)
        {
            Test.Workflow.Search.Find(simCardNumber);
            new SearchResult(Result.SimCard).First().Click();

            Assert.AreEqual(simCardNumber, Test.View.Administration.SimCard.View.SimCardNumber);
        }

        public static void TicketCanBeFoundById(string ticketId)
        {
            Test.Workflow.Search.Find(ticketId);
            new SearchResult(Result.Ticket).First().Click();

            StringAssert.Contains(ticketId, Test.View.Tickets.Trouble.View.Header);
        }
    }
}