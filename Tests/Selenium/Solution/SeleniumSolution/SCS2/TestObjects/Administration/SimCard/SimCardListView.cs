using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SimCard
{
    internal class SimCardListView
    {
        private readonly IWebDriverAdapter _driver;

        public SimCardListView(IWebDriver driver)
        {
            _driver = new WebDriverAdapter(driver);
        }

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
            get { return _driver.FindAdaptedElement(By.CssSelector("input.button[value='Hinzufügen']")); }
        }
    }
}