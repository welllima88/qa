using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.Helper;
using Six.Scs.Test.UI.Common.Menu;
using Six.Scs.Test.UI.Terminal.Dashboard.Portlets.Brand;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Massmutation
{
    public class BusinessTemplate
    {
        public static void Change(IEnumerable<Model.Terminal> terminals)
        {
            TestDirector.Navigate();
            MassMutationMenu.MassMutation.Click();
            MassMutationMenu.BusinessTemplate.Click();
            UI.Massmuation.BusinessTemplate.TerminalIds = terminals.Select(t => t.Id);
            UI.Massmuation.BusinessTemplate.Acquirer = "SIX Payment Services";
            UI.Massmuation.BusinessTemplate.ActualBusinessTemplate = "0 - für alle Business-Templates";
            UI.Massmuation.BusinessTemplate.NewBusinessTemplate = "Key_Account_300";

            Assert.That(UI.Massmuation.BusinessTemplate.AffectedTerminals,
                Is.EquivalentTo(terminals.Select(t => t.Id)));

            UI.Massmuation.BusinessTemplate.Save.Click();
            TestDirector.Navigate();
            foreach (var terminal in terminals)
            {
                Terminal.Open(terminal);
                BrandPortlet.ExpandAll();
                Verify.With(
                    () =>
                        Assert.That(BrandPortlet.Acquirer("acq_multipay").BusinessTemplate,
                            Is.EqualTo("Key_Account_300")))
                    .Check();
            }
        }
    }
}