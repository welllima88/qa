using NUnit.Framework;
using Six.Scs.QA.Selenium.Administration.SimCard;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.Selenium.Mpd;
using Six.Scs.QA.Selenium.Search;
using Six.Scs.QA.Selenium.Terminal.Dashboard;
using Six.Scs.QA.Selenium.User;

namespace Six.Scs.QA.Testlogic
{
    public class Search
    {
        public static void CustomerCanBeFoundByCustomerNumber(string customerId)
        {
            Workflow.Search.Find(customerId);
            SearchResult.First(new CustomerResult()).Click();

            Assert.AreEqual(customerId, View.CustomerNumber);
        }

        public static void LocationCanBeFoundByLocationName(string locationName)
        {
            Workflow.Search.Find(locationName);
            SearchResult.First(new LocationResult()).Click();

            Assert.AreEqual(locationName, LocationView.CompanyName);
        }

        public static void CustomerCanBeFoundByCustomerName(string customerName)
        {
            Workflow.Search.Find(customerName);
            SearchResult.First(new CustomerResult()).Click();

            Assert.AreEqual(customerName, View.CustomerName);
        }

        public static void TerminalCanBeFoundById(string terminalId)
        {
            Workflow.Search.Find(terminalId);
            SearchResult.First(new TerminalResult()).Click();

            Assert.AreEqual(terminalId, TerminalInfo.TerminalId);
        }

        public static void UserCanBeFoundByCustomerName(string userName)
        {
            Workflow.Search.Find(userName);
            SearchResult.First(new UserResult()).Click();

            Assert.AreEqual(userName, UserView.UserName);
        }

        public static void MpdCanBeFoundById(string id)
        {
            Workflow.Search.Find(id);
            SearchResult.First(new MpdResult()).Click();

            Assert.AreEqual(id, MpdView.Id);
        }

        public static void SimcardBySimCardNumber(string simCardNumber)
        {
            Workflow.Search.Find(simCardNumber);
            SearchResult.First(new Selenium.Search.SimCard()).Click();

            Assert.AreEqual(simCardNumber, SimCardView.SimCardNumber);
        }
    }
}