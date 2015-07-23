using NUnit.Framework;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow;

namespace Six.Scs.Test
{
    public class Infotext
    {
        public static void Create(Model.ValueObjects.Customer customer)
        {
            Customer.Open(customer);
            View.Customer.View.CreateInfotext.Click();
            var infotext = InfoText.Create("Customer");

            Assert.That(View.Customer.View.Infotexts, Has.Exactly(1).ContainsSubstring(infotext));
        }

        public static void Create(Model.ValueObjects.Location location)
        {
            Location.Open(location);
            View.Location.View.CreateInfotext.Click();
            var infotext = InfoText.Create("Location");

            Assert.That(View.Location.View.Infotexts, Has.Exactly(1).ContainsSubstring(infotext));
        }

        public static void Create(Model.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            TerminalTexts.CreateInfotext.Click();
            var infotext = InfoText.Create("Terminal");

            Assert.That(View.Common.Infotext.ListView.List, Has.Exactly(1).ContainsSubstring(infotext));
        }
    }
}