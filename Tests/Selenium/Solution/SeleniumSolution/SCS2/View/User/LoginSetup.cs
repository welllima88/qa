using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;
using Six.Scs.QA.Selenium.Model.ValueObjects;

namespace Six.Scs.QA.Selenium.View.User
{
    public class LoginSetup : WebObject
    {
        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }

        public static void Set(string name, string permission)
        {
            WebDriver.FindAdaptedElement(
                By.CssSelector("table#NewLoginServices tr[id='" + name + "'] td.Permission select"))
                .Selector()
                .SelectByText(permission);
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