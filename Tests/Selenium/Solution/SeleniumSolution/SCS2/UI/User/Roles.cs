using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.UI.User
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
            var rows =
                WebDriver.FindElements(By.CssSelector("table#user_roles tbody>tr>td>a")).Select(d => d.Text).ToList();
            return rows;
        }
    }
}