using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Definitions;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Administration.SimCard
{
    internal class SimCardListView : WebObject
    {
        public Collection<ISimCardElement> SimCardList
        {
            get
            {
                //_driver.FindAdaptedElements(By.CssSelector());
                return null;
            }
        }

        public IWebElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[value='Hinzufügen']")); }
        }
    }
}