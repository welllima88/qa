using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SimCard
{
    internal class SimCardView
    {
        private readonly IWebDriverAdapter _driver;

        public SimCardElementView SimCardElement;
        public SimCardHistory SimCardHistory;

        public SimCardView(IWebDriver driver)
        {
            _driver = new WebDriverAdapter(driver);
            SimCardElement = new SimCardElementView(_driver);
            SimCardHistory = new SimCardHistory(_driver);
        }

        public IWebElement LockButton
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("button[name='lock']")); }
        }

        public IWebElement UnlinkButton
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("button[name='unlink']")); }
        }

        public IWebElement EditButton
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("button[name='edit']")); }
        }

        public Collection<ISimCardElement> SimCardList
        {
            get { throw new NotImplementedException("SIM LIST"); }
        }

        public IWebElement CreateButton
        {
            get { return _driver.FindAdaptedElement(By.CssSelector("input.button[value='Hinzufügen']")); }
        }
    }
}