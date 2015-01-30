using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.User
{
    public class Roles : WebObject
    {
        public static void Save()
        {
            WebDriver.FindAdaptedElement(By.Id("save")).Click();
        }

        public static void Set(string name)
        {
            WebDriver.FindElements(By.CssSelector("td#content form table.table tbody tr"))
                .FirstOrDefault(d => d.Text.Contains(name)).FindElement(By.CssSelector("td input[type='checkbox']"))
                .Click();
        }

        public static IEnumerable<string> GetAssignedRoles()
        {
            IEnumerable<string> rows =
                WebDriver.FindElements(By.CssSelector("table#roles tbody tr")).Select(d => d.Text);
            return rows;
        }
    }
}