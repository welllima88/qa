using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.EventLog
{
    public class TerminalEventLog : WebObject
    {
        /// <summary>
        ///     Mulit selectable list for choosing log event entries by severity
        /// </summary>
        public static SelectElement SeverityList
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("select#SelectedSeverities")).Selector(); }
        }

        public static SelectElement TimeSpan
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("select#SelectedTimeSpan")).Selector(); }
        }

        public static SelectElement EventTypes
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("select#SelectedEventTypes")).Selector(); }
        }

        public static IWebElement EventTable
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("tbody tr#rowContent td#content table")); }
        }

        public static ReadOnlyCollection<IWebElementAdapter> EventList
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("td#content table tbody tr.Summary")); }
        }

        public static IWebElement Export
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value='Export']")); }
        }
    }
}