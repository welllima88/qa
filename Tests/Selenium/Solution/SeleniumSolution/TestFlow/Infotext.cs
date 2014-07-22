using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Infotext;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.TestData.ValueObjects;
using Six.Scs.QA.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Infotext
    {
        public static void Create(TestData.ValueObjects.Customer customer)
        {
            Customer.Open(customer);

            CreateAndSaveInfotext("Customer");
        }

        public static void Create(TestData.ValueObjects.Location location)
        {
            Location.Open(location);
            CreateAndSaveInfotext("Location");
        }

        public static void Create(TestData.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            CreateAndSaveInfotext("Terminal");
        }

        private static void CreateAndSaveInfotext(string parameter)
        {
            CustomerMenu.Infotexts.Click();
            InfoTextListView.CreateButton.Click();

            InfoText.Create(parameter);
            Check(parameter);
        }

        public static void Check(string infotext)
        {
            Assert.IsTrue(InfoTextListView.List.Contains(infotext));
        }
    }
}