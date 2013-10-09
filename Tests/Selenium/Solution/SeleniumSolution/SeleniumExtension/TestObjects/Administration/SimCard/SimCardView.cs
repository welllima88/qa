using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard
{
    public class SimCardView : WebObject
    {
        public readonly SimCardElementView SimCardElement;
        public readonly SimCardHistory SimCardHistory;

        public SimCardView()
        {
            SimCardElement = new SimCardElementView();
            SimCardHistory = new SimCardHistory();
        }

        public IWebElement LockButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='lock']")); }
        }

        public IWebElement UnlinkButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='unlink']")); }
        }

        public IWebElement EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='edit']")); }
        }

        public Collection<ISimCardElement> SimCardList
        {
            get { throw new NotImplementedException("SIM LIST"); }
        }

        public IWebElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[value='Hinzufügen']")); }
        }
    }
}