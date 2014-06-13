using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.Tests.Selenium.Extension.TestObjects.Administration.SimCard
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