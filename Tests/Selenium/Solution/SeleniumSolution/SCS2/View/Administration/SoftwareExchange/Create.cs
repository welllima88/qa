using System;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Administration.SoftwareExchange
{
    public class Create : WebObject
    {
        public static IWebElementAdapter SelectedTerminalType
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedTerminalType")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter IncludeDeactivated
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#IncludeDeactivated")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter IncludeCanceled
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#IncludeCancelled")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter SelectedCurrentRelease
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedCurrentReleaseCriteria")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter SelectedNewRelease
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedNewReleaseCriteria")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter SelectedNewTargetRelease
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedNewRelease")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter SelectedNetType
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedNetType")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter TidRangeStart
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TidRangeStart")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter TidRangeEnd
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TidRangeEnd")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter TerminalIdSelection
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#TerminalIdSelection")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter RecallNextFrom
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#RecallNextFrom")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter RecallNextUntil
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#RecallNextUntil")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter SelectedSupplierMandant
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedSupplierMandant")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter IncludeKeyAccounts
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#IncludeKeyAccounts")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter CustomerIds
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#CustomerIds")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter Zips
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#Zips")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter SelectedCountry
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SelectedCountry")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter ResultLimit
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ResultLimit")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter RefreshButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#refresh")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter BatchTitle
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#BatchTitle")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter SelectAllSwitch
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#selectAllSwitch")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter SelectOddEvenSwitch
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#selectOddEvenSwitch")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter StartDateTime
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#startDateTime")); }
            set { throw new NotImplementedException(); }
        }

        public static IWebElementAdapter BatchCreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#execute")); }
        }
    }
}