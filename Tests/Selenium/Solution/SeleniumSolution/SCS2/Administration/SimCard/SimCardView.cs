using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Administration.SimCard
{
    public class SimCardView : WebObject
    {
        public static ButtonElement LockButton
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/SIMCard/LockCard?simCardId=']")).Button();
            }
        }

        public static ButtonElement UnlinkButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button[name='unlink']")).Button(); }
        }

        public static ButtonElement EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("edit")).Button(); }
        }

        public static ButtonElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/SIMCard/New']")).Button(); }
        }

        public static ButtonElement ImportButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("a[href$='/SIMCard/Import']")).Button(); }
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
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#state")).Text.Equals("aktiv"); }
        }

        public static string TerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TerminalId")).Text; }
        }

        public static string Region
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#Location")).Text; }
        }

        public static string Usage
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#Usage")).Text; }
        }

        public static IEnumerable<SimHistoryElement> SimHistory
        {
            get
            {
                // take alle History Elements/ Wrap each in a SimHistory Element/ return a List of SimHistoryElements
                // IEnumerable<IWebElementAdapter> d = WebDriver.FindElements(By.CssSelector("#SIMCard_History"));
                // d.;
                // IEnumerable<SimHistoryElement> simHistory;
                // return simHistory;
                throw new NotImplementedException();
            }
        }
    }

    public class SimHistoryElement : WebObject
    {
        //public string Date { get; }
        //public string User { get; }
        //public string Description { get; }
    }
}