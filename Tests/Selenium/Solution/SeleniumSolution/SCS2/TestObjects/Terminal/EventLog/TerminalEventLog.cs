using System.Collections.ObjectModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.EventLog
{
    public class TerminalEventLog : WebObject
    {
        public TerminalEventLog(IWebDriverAdapter driver)
            : base(driver)
        {
        }

        /// <summary>
        /// Mulit selectable list for choosing log event entries by severity
        /// </summary>
        public SelectElement SeverityList
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("select#SelectedSeverities")).Selector(); }
        }

        public SelectElement TimeSpan
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("select#SelectedTimeSpan")).Selector(); }
        }

        public SelectElement EventTypes
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("select#SelectedEventTypes")).Selector(); }
        }

        public IWebElement EventTable
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("tbody tr#rowContent td#content table")); }
        }

        public ReadOnlyCollection<IWebElementAdapter> EventList
        {
            get { return Driver.FindAdaptedElements(By.CssSelector("td#content table tbody tr.Summary")); }
        }
    }
}