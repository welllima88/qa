using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Administration.SimCard
{
    internal class SimCardView : WebObject
    {
        public SimCardElementView SimCardElement;
        public SimCardHistory SimCardHistory;

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