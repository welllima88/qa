using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard
{
    public class SimCardView : WebObject
    {
        public static SimCardElementView SimCardElement;
        public static SimCardHistory SimCardHistory;

        public static IWebElement LockButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='lock']")); }
        }

        public static IWebElement UnlinkButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='unlink']")); }
        }

        public static IWebElement EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='edit']")); }
        }

        public static Collection<ISimCardElement> SimCardList
        {
            get { throw new NotImplementedException("SIM LIST"); }
        }

        public static IWebElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[value='Hinzufügen']")); }
        }
    }
}