using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Infotext;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Infotext
    {
        public static void Create(TestData.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            CustomerMenu.Infotexts.Click();
            CreateAndSaveInfotext("Customer");
        }

        public static void Create(TestData.ValueObjects.Location location)
        {
            Location.Open(location);
            LocationMenu.Infotexts.Click();
            CreateAndSaveInfotext("Location");
        }

        public static void Create(TestData.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            TerminalTexts.Infotexts.Click();
            CreateAndSaveInfotext("Terminal");
        }

        private static void CreateAndSaveInfotext(string parameter)
        {
            InfoTextListView.CreateButton.Click();
            string infotext = InfoText.Create(parameter);
            Check(infotext);
        }

        public static void Check(string infotext)
        {
            Assert.IsTrue(InfoTextListView.List.Contains(infotext));
        }
    }
}