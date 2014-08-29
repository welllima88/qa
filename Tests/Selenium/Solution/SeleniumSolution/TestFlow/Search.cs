using NUnit.Framework;
using Six.Scs.QA.Selenium.Administration.SimCard;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Location;
using Six.Scs.QA.Selenium.Mpd;
using Six.Scs.QA.Selenium.Search;
using Six.Scs.QA.Selenium.Search.Result;
using Six.Scs.QA.Selenium.Terminal.Dashboard;
using Six.Scs.QA.Selenium.User;
using View = Six.Scs.QA.Selenium.Location.View;

namespace Six.Scs.QA.Testlogic
{
    public class Search
    {
        public static void CustomerCanBeFoundByCustomerNumber(string customerId)
        {
            Workflow.Search.Find(customerId);
            SearchResult.First(new Selenium.Search.Result.Customer()).Click();

            Assert.AreEqual(customerId, Selenium.Customer.View.CustomerNumber);
        }

        public static void LocationCanBeFoundByLocationName(string locationName)
        {
            Workflow.Search.Find(locationName);
            SearchResult.First(new Selenium.Search.Result.Location()).Click();

            Assert.AreEqual(locationName, View.CompanyName);
        }

        public static void CustomerCanBeFoundByCustomerName(string customerName)
        {
            Workflow.Search.Find(customerName);
            SearchResult.First(new Selenium.Search.Result.Customer()).Click();

            Assert.AreEqual(customerName, Selenium.Customer.View.CustomerName);
        }

        public static void TerminalCanBeFoundById(string terminalId)
        {
            Workflow.Search.Find(terminalId);
            SearchResult.First(new Selenium.Search.Result.Terminal()).Click();

            Assert.AreEqual(terminalId, TerminalInfo.TerminalId);
        }

        public static void UserCanBeFoundByCustomerName(string userName)
        {
            Workflow.Search.Find(userName);
            SearchResult.First(new Selenium.Search.Result.User()).Click();

            Assert.AreEqual(userName, Selenium.User.View.UserName);
        }

        public static void MpdCanBeFoundById(string id)
        {
            Workflow.Search.Find(id);
            SearchResult.First(new Selenium.Search.Result.Mpd()).Click();

            Assert.AreEqual(id, Selenium.Mpd.View.Id);
        }

        public static void SimcardBySimCardNumber(string simCardNumber)
        {
            Workflow.Search.Find(simCardNumber);
            SearchResult.First(new Selenium.Search.Result.SimCard()).Click();

            Assert.AreEqual(simCardNumber, Selenium.Administration.SimCard.View.SimCardNumber);
        }
    }
}