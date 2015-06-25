using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.View.Common.Infotext;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow;

namespace Six.Scs.Test
{
    public class Infotext
    {
        public static void Create(Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            View.Customer.View.Infotexts.Click();
            CreateAndSaveInfotext("Customer");
        }

        public static void Create(Model.ValueObjects.Location location)
        {
            Location.Open(location);
            LocationMenu.Infotexts.Click();
            CreateAndSaveInfotext("Location");
        }

        public static void Create(Model.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            TerminalTexts.Infotexts.Click();
            CreateAndSaveInfotext("Terminal");
        }

        private static void CreateAndSaveInfotext(string parameter)
        {
            ListView.CreateButton.Click();
            var infotext = InfoText.Create(parameter);
            Check(infotext);
        }

        public static void Check(string infotext)
        {
            Assert.That(ListView.List.Contains(infotext));
        }
    }
}