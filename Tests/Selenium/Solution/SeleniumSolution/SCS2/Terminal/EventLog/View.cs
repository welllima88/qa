using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.EventLog
{
    public class View : WebObject
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

        public static IWebElementAdapter EventTable
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("tbody tr#rowContent td#content table")); }
        }

        public static ReadOnlyCollection<IWebElementAdapter> EventList
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("td#content table tbody tr.Summary")); }
        }

        public static IWebElementAdapter Export
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#export")); }
        }
    }
}