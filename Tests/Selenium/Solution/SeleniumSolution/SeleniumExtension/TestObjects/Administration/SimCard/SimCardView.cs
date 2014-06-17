using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Administration.SimCard
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

        public static IWebElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input.button[value='Hinzufügen']")); }
        }

        public static string NetProvider
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#NetworkProvider")).Text; }
        }

        public static string SimCardNumber
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCardNumber")).Text; }
        }

        public static string MobileNumber
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#MobileNumber")).Text; }
        }

        public static string Pin
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#PIN")).Text; }
        }

        public static string Puk
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#PUK")).Text; }
        }

        public static bool Status
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCardState")).Text.Equals("aktiv"); }
        }

        public static string TerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TerminalId")).Text; }
        }

        public static string Region
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_LocationId")).Text; }
        }

        public static string Usage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_UsageId")).Text; }
        }

        public static IEnumerable<SimHistoryElement> SimHistory
        {
            get
            {
                // take alle History Elements/ Wrap each in a SimHistory Element/ return a List of SimHistoryElements
                IEnumerable<IWebElement> d = WebDriver.FindElements(By.CssSelector("#SIMCard_History"));
                //d.;
                //IEnumerable<SimHistoryElement> simHistory;
                //return simHistory;
                throw new NotImplementedException();
            }
        }
    }

    public class SimHistoryElement : WebObject
    {
        public SimHistoryElement(IWebElement webElement)
        {
        }

        //public string Date { get; }
        //public string User { get; }
        //public string Description { get; }
    }
}