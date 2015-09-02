using NUnit.Framework;
using Six.Scs.Test.Factory;
using Six.Scs.Test.UI.Common.Infotext;
using Six.Scs.Test.UI.Customer;
using Six.Scs.Test.UI.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow;

namespace Six.Scs.Test
{
    public class Infotext
    {
        public static void Create(Model.Customer customer)
        {
            Customer.Open(customer);
            View.CreateInfotext.Click();
            var infotext = InfoText.Create("Customer", Base.GenerateTestId());

            Assert.That(View.Infotexts, Has.Exactly(1).ContainsSubstring(infotext));
        }

        public static void Create(Model.Location location)
        {
            Location.Open(location);
            UI.Location.View.CreateInfotext.Click();
            var infotext = InfoText.Create("Location", Base.GenerateTestId());

            Assert.That(UI.Location.View.Infotexts, Has.Exactly(1).ContainsSubstring(infotext));
        }

        public static void Create(Model.Terminal terminal)
        {
            Terminal.Open(terminal);
            TerminalTexts.CreateInfotext.Click();
            var infotext = InfoText.Create("Terminal", Base.GenerateTestId());

            Assert.That(ListView.List, Has.Exactly(1).ContainsSubstring(infotext));
        }
    }
}