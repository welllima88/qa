using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.Tests.Selenium.Extension.TestObjects.Massmuation
{
    public class TerminalMassValidation : WebObject
    {
        public static List<string> Passwords
        {
            get
            {
                ReadOnlyCollection<IWebElementAdapter> passwords =
                    WebDriver.FindAdaptedElements(By.CssSelector("input[id$='inpPassword']"));
                var passwordsAsString = new List<string>(5);

                passwordsAsString.AddRange(passwords.Select(password => password.TextBox().Text()));

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

                passwordsAsString.AddRange(passwords.Select(password => password.TextBox().Text()));

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

                passwordsAsString.AddRange(passwords.Select(password => password.TextBox().Text()));

                return passwordsAsString;
            }
        }
    }
}