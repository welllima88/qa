using NUnit.Framework;
using Six.Scs.QA.Application.View.Customer;
using Six.Scs.QA.Application.View.Search;
using Six.Scs.QA.Application.View.Terminal.Dashboard;

namespace Six.Scs.QA.Testlogic
{
    public class Search
    {
        public static void CustomerCanBeFoundByCustomerNumber(string customerId)
        {
            Application.Workflow.Search.Find(customerId);
            new SearchResult(Result.Customer).First().Click();

            Assert.AreEqual(customerId, View.CustomerNumber);
        }

        public static void LocationCanBeFoundByLocationName(string locationName)
        {
            Application.Workflow.Search.Find(locationName);
            new SearchResult(Result.Location).First().Click();

            Assert.AreEqual(locationName, Application.View.Location.View.CompanyName);
        }

        public static void CustomerCanBeFoundByCustomerName(string customerName)
        {
            Application.Workflow.Search.Find(customerName);
            new SearchResult(Result.Customer).First().Click();

            Assert.AreEqual(customerName, View.CustomerName);
        }

        public static void TerminalCanBeFoundById(string terminalId)
        {
            Application.Workflow.Search.Find(terminalId);
            new SearchResult(Result.Terminal).First().Click();

            Assert.AreEqual(terminalId, TerminalInfo.TerminalId);
        }

        public static void UserCanBeFoundByCustomerName(string userName)
        {
            Application.Workflow.Search.Find(userName);
            new SearchResult(Result.User).First().Click();

            Assert.AreEqual(userName, Application.View.User.View.UserName);
        }

        public static void MpdCanBeFoundById(string id)
        {
            Application.Workflow.Search.Find(id);
            new SearchResult(Result.Mpd).First().Click();

            Assert.AreEqual(id, Application.View.Mpd.View.Id);
        }

        public static void SimcardBySimCardNumber(string simCardNumber)
        {
            Application.Workflow.Search.Find(simCardNumber);
            new SearchResult(Result.SimCard).First().Click();

            Assert.AreEqual(simCardNumber, Application.View.Administration.SimCard.View.SimCardNumber);
        }

        public static void TicketCanBeFoundById(string ticketId)
        {
            Application.Workflow.Search.Find(ticketId);
            new SearchResult(Result.Ticket).First().Click();

            StringAssert.Contains(ticketId, Application.View.Tickets.Trouble.View.Header);
        }
    }
}