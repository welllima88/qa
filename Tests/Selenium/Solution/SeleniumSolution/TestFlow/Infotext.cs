using NUnit.Framework;
using Six.Scs.QA.Application.View.Common.Infotext;
using Six.Scs.QA.Application.View.Common.Menu;
using Six.Scs.QA.Application.View.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Application.Workflow;

namespace Six.Scs.QA.Testlogic
{
    public class Infotext
    {
        public static void Create(Application.Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            CustomerMenu.Infotexts.Click();
            CreateAndSaveInfotext("Customer");
        }

        public static void Create(Application.Model.ValueObjects.Location location)
        {
            Location.Open(location);
            LocationMenu.Infotexts.Click();
            CreateAndSaveInfotext("Location");
        }

        public static void Create(Application.Model.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            TerminalTexts.Infotexts.Click();
            CreateAndSaveInfotext("Terminal");
        }

        private static void CreateAndSaveInfotext(string parameter)
        {
            ListView.CreateButton.Click();
            string infotext = InfoText.Create(parameter);
            Check(infotext);
        }

        public static void Check(string infotext)
        {
            Assert.IsTrue(ListView.List.Contains(infotext));
        }
    }
}