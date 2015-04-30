using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Massmuation
{
    public class TerminalValidation : WebObject
    {
        public static List<string> Passwords
        {
            get
            {
                var passwords =
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
                var passwords =
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
                var passwords =
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
                    WebDriver.FindAdaptedElement(By.Id("save"));
            }
        }
    }
}