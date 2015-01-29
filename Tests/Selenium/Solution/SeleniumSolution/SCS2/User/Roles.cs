using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;
using Six.Scs.QA.TestData.ValueObjects;

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

        public static ICollection<Service> GetAssignedServices()
        {
            ReadOnlyCollection<IWebElement> rows =
                WebDriver.FindElements(By.CssSelector("table#AssignedLoginServices tbody tr"));

            var services = new Collection<Service>();
            foreach (IWebElement row in rows)
            {
                services.Add(new Service
                {
                    Name = row.FindElement(By.CssSelector("td.Service")).Text,
                    Permission = row.FindElement(By.CssSelector("td.Permission")).Text
                });
            }
            return services;
        }
    }
}