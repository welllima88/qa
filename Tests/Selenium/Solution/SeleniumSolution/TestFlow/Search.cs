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
            SearchResult.First(Result.Customer).Click();

            Assert.AreEqual(customerId, View.Customer.View.CustomerNumber);
        }

        public static void LocationCanBeFoundByLocationName(string locationName)
        {
            Workflow.Search.Find(locationName);
            SearchResult.First(Result.Location).Click();

            Assert.AreEqual(locationName, View.Location.View.CompanyName);
        }

        public static void CustomerCanBeFoundByCustomerName(string customerName)
        {
            Workflow.Search.Find(customerName);
            SearchResult.First(Result.Customer).Click();

            Assert.AreEqual(customerName, View.Customer.View.CustomerName);
        }

        public static void TerminalCanBeFoundById(string terminalId)
        {
            Workflow.Search.Find(terminalId);
            SearchResult.First(Result.Terminal).Click();

            Assert.AreEqual(terminalId, TerminalInfo.TerminalId);
        }

        public static void UserCanBeFoundByCustomerName(string userName)
        {
            Workflow.Search.Find(userName);
            SearchResult.First(Result.User).Click();

            Assert.AreEqual(userName, View.User.View.UserName);
        }

        public static void MpdCanBeFoundById(string id)
        {
            Workflow.Search.Find(id);
            SearchResult.First(Result.Mpd).Click();

            Assert.AreEqual(id, View.Mpd.View.Id);
        }

        public static void SimcardBySimCardNumber(string simCardNumber)
        {
            Workflow.Search.Find(simCardNumber);
            SearchResult.First(Result.SimCard).Click();

            Assert.AreEqual(simCardNumber, View.Administration.SimCard.View.SimCardNumber);
        }

        public static void TicketCanBeFoundById(string ticketId)
        {
            Workflow.Search.Find(ticketId);
            SearchResult.First(Result.Ticket).Click();

            StringAssert.Contains(ticketId, View.Tickets.Trouble.View.Header);
        }

        public static void BillingAddressCanBeFoundByName(string companyName)
        {
            Workflow.Search.Find(companyName);
            SearchResult.First(Result.BillingAddress).Click();

            StringAssert.Contains(companyName, View.Location.BillingAddress.View.CompanyName);
        }
    }
}