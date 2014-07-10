using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Administration.SimCard
{
    public class SimCardListView : WebObject
    {
        public static Collection<ISimCardElement> SimCardList
        {
            get
            {
                //_driver.FindAdaptedElements(By.CssSelector());
                return null;
            }
        }

        public static IWebElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[value='Hinzufügen']")); }
        }
    }
}