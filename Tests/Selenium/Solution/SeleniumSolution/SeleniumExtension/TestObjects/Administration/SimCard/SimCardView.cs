using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard
{
    public class SimCardView : WebObject
    {
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

        public static string NetProvider
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#NetworkProvider")).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string SimCardNumber
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCardNumber")).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string MobileNumber
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#MobileNumber")).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Pin
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#PIN")).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Puk
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#PUK")).Text; }
            set { throw new NotImplementedException(); }
        }

        public static bool Status
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCardState")).Text.Equals("aktiv"); }
            set { throw new NotImplementedException(); }
        }

        public static string TerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TerminalId")).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Region
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_LocationId")).Text; }
            set { throw new NotImplementedException(); }
        }

        public static string Usage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_UsageId")).Text; }
            set { throw new NotImplementedException(); }
        }
    }
}