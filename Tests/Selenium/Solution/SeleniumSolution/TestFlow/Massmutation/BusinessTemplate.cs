using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Massmutation
{
    public class BusinessTemplate
    {
        public static void Change(IEnumerable<Model.ValueObjects.Terminal> duplicatedTerminals)
        {
            TestDirector.Navigate();
            MassMutationMenu.MassMutation.Click();
            MassMutationMenu.BusinessTemplate.Click();
            View.Massmuation.BusinessTemplate.TerminalIds = duplicatedTerminals.Select(t => t.Id);
            View.Massmuation.BusinessTemplate.Acquirer = "SIX Payment Services";
            View.Massmuation.BusinessTemplate.ActualBusinessTemplate = "0 - f�r alle Business-Templates";
            View.Massmuation.BusinessTemplate.NewBusinessTemplate = "Key_Account_300";

            Assert.That(View.Massmuation.BusinessTemplate.AffectedTerminals,
                Is.EquivalentTo(duplicatedTerminals.Select(t => t.Id)));

            View.Massmuation.BusinessTemplate.Save.Click();
            foreach (var terminal in duplicatedTerminals)
            {
                Terminal.Open(terminal);
                BrandPortlet.ExpandAll();
                Assert.That(BrandPortlet.Acquirer("acq_multipay").BusinessTemplate, Is.EqualTo("Key_Account_300"));
            }
        }
    }
}