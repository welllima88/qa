using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Massmuation
{
    public class TerminalMassValidation : WebObject
    {
        public static List<string> Passwords
        {
            get
            {
                ReadOnlyCollection<IWebElement> passwords =
                    WebDriver.FindElements(By.CssSelector("input[id$='inpPassword']"));
                var passwordsAsString = new List<string>(5);

                passwordsAsString.AddRange(passwords.Select(password => password.GetAttribute("value")));

                return passwordsAsString;
            }
        }

        public static List<string> ReferenceTerminalIds
        {
            get
            {
                ReadOnlyCollection<IWebElement> passwords =
                    WebDriver.FindElements(By.CssSelector("input[id$='inpReferenceTerminalId']"));
                var passwordsAsString = new List<string>(5);

                passwordsAsString.AddRange(passwords.Select(password => password.GetAttribute("value")));

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
                ReadOnlyCollection<IWebElement> passwords =
                    WebDriver.FindElements(By.CssSelector("input[id$='_inpLocationId']"));
                var passwordsAsString = new List<string>(5);

                passwordsAsString.AddRange(passwords.Select(password => password.GetAttribute("value")));

                return passwordsAsString;
            }
        }
    }
}