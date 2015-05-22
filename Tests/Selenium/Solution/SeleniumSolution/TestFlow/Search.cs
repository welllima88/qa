using NUnit.Framework;
using Six.Scs.Test.View.Search;
using Six.Scs.Test.View.Terminal.Dashboard;

namespace Six.Scs.Test
{
    public class Search
    {
        public static void CustomerCanBeFoundByCustomerNumber(string customerId)
        {
            Workflow.Search.Find(customerId);
            new SearchResult(Result.Customer).First().Click();

            Assert.AreEqual(customerId, View.Customer.View.CustomerNumber);
        }

        public static void LocationCanBeFoundByLocationName(string locationName)
        {
            Workflow.Search.Find(locationName);
            new SearchResult(Result.Location).First().Click();

            Assert.AreEqual(locationName, View.Location.View.CompanyName);
        }

        public static void CustomerCanBeFoundByCustomerName(string customerName)
        {
            Workflow.Search.Find(customerName);
            new SearchResult(Result.Customer).First().Click();

            Assert.AreEqual(customerName, View.Customer.View.CustomerName);
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

            Assert.AreEqual(userName, View.User.View.UserName);
        }

        public static void MpdCanBeFoundById(string id)
        {
            Workflow.Search.Find(id);
            new SearchResult(Result.Mpd).First().Click();

            Assert.AreEqual(id, View.Mpd.View.Id);
        }

        public static void SimcardBySimCardNumber(string simCardNumber)
        {
            Workflow.Search.Find(simCardNumber);
            new SearchResult(Result.SimCard).First().Click();

            Assert.AreEqual(simCardNumber, View.Administration.SimCard.View.SimCardNumber);
        }

        public static void TicketCanBeFoundById(string ticketId)
        {
            Workflow.Search.Find(ticketId);
            new SearchResult(Result.Ticket).First().Click();

            StringAssert.Contains(ticketId, View.Tickets.Trouble.View.Header);
        }

        public static void BillingAddressCanBeFoundByName(string companyName)
        {
            Workflow.Search.Find(companyName);
            new SearchResult(Result.BillingAddress).First().Click();

            StringAssert.Contains(companyName, View.Location.BillingAddress.View.CompanyName);
        }
    }
}