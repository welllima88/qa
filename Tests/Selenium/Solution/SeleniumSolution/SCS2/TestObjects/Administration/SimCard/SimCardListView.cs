using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Administration.SimCard
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