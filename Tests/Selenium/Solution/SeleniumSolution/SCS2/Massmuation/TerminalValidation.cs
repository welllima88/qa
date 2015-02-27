using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Massmuation
{
    public class TerminalValidation : WebObject
    {
        public static List<string> Passwords
        {
            get
            {
                ReadOnlyCollection<IWebElementAdapter> passwords =
                    WebDriver.FindAdaptedElements(By.CssSelector("input[id$='inpPassword']"));
                var passwordsAsString = new List<string>(5);

                passwordsAsString.AddRange(passwords.Select(password => password.TextField().Text()));

                return passwordsAsString;
            }
        }

        public static List<string> ReferenceTerminalIds
        {
            get
            {
                ReadOnlyCollection<IWebElementAdapter> passwords =
                    WebDriver.FindAdaptedElements(By.CssSelector("input[id$='inpReferenceTerminalId']"));
                var passwordsAsString = new List<string>(5);

                passwordsAsString.AddRange(passwords.Select(password => password.TextField().Text()));

                return passwordsAsString;
            }
        }

        public static int Count
        {
            get { return WebDriver.FindElements(By.CssSelector("tr[id$='_rowData']")).Count; }
        }

        public static List<string> Locations
        {
            get
            {
                ReadOnlyCollection<IWebElementAdapter> passwords =
                    WebDriver.FindAdaptedElements(By.CssSelector("input[id$='_inpLocationId']"));
                var passwordsAsString = new List<string>(5);

                passwordsAsString.AddRange(passwords.Select(password => password.TextField().Text()));

                return passwordsAsString;
            }
        }

        public static IWebElementAdapter ExecuteButton
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("tbody input#ctl00_bodyContentPlaceHolder_btnProceed"));
            }
        }
    }
}