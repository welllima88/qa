using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.Test.Model;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.User
{
    public class LoginSetup : WebObject
    {
        public static IWebElement SaveButton
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
            var rows =
                WebDriver.FindElements(By.CssSelector("table#AssignedLoginServices tbody tr"));

            var services = new Collection<Service>();
            foreach (var row in rows)
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