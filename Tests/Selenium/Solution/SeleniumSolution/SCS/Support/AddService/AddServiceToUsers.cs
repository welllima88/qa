/* RegExp
 * http://openbook.galileocomputing.de/csharp/kap17.htm
 * 
 * Strings als Parameter:
 * http://openbook.galileocomputing.de/csharp/kap19.htm
 * "Kundenname" statt k.Name Feld-Bezeichnung ist viel flexibler für zukünftige Struktur
 *  
 * http://openbook.galileocomputing.de/csharp/kap31.htm#t25
 * 
 */

using System;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.Tests.Selenium.Extension.Selenium;

namespace SIX.SCS.Tests.Selenium.Support.AddService
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class AddServiceToUsers
    {
        private static IWebDriverAdapter _driver;
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void Prepare(TestContext testContext)
        {
            _driver = new WebDriverAdapter(TestDirector.WebDriver);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"C:\Users\siegmund\Desktop\ProdSystemUsers.csv",
            "ProdSystemUsers#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void AddScs2ServiceToUsers()
        {
            string userId = Convert.ToString(TestContext.DataRow[0]);

            OpenUserPage(userId);

            CheckUser(userId);
            CheckMandant("TKCPOS");
            Assert.IsTrue(CheckServiceIsSet("Analyzer", "Service Benutzer"));

            AddService("SCS2.0", "SCS2 Dummy");

            CheckUser(userId);
            Assert.IsTrue(CheckServiceIsSet("Analyzer", "Service Benutzer"));
        }

        [DataSource("System.Data.Odbc",
            @"Dsn=Excel Files;dbq=C:\Users\siegmund\Desktop\users in Prod which use analyzer.xlsx", "UsersProd$",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void RemoveAndAddAnalyzerToRepairWesState()
        {
            string login = Convert.ToString(TestContext.DataRow["Login_Id"]);

            Console.Out.WriteLine("- User {0} begin", login);
            try
            {
                RemoveService(login, "18");
            }
            catch (UserNotFoundException)
            {
                Console.Error.WriteLine("no valid user found: {0}", login);
            }

            AddService("Analyzer", "Service Benutzer");

            CheckUser(login);
            Assert.IsTrue(CheckServiceIsSet("Analyzer", "Service Benutzer"));
            Console.Out.WriteLine("+ User {0} finished", login);
        }

        public static void RemoveService(string userId, string serviceId)
        {
            _driver.Navigate().GoToUrl(TestDirector.BaseUrl +
                                       "index.asp?mode=Delete&username=" + userId + "&ServiceId=" + serviceId +
                                       "&caller=&AcqName=&AcquirerLocationId=&reloadurl=/scsc-qa-l/LoginService.asp");
            _driver.SwitchTo().Frame("main");
            try
            {
                _driver.FindElement(By.CssSelector("td a img[alt='Login Status']"));
            }
            catch (Exception)
            {
                throw new UserNotFoundException();
            }

            _driver.FindElement(By.CssSelector("input[value='löschen']")).Click();
        }

        private static bool CheckServiceIsSet(string serviceName, string templateName)
        {
            bool cond1 = Regex.IsMatch(_driver.FindElement(By.CssSelector("BODY")).Text,
                                       "^[\\s\\S]*" + serviceName + "[\\s\\S]*$");
            bool cond2 =
                Regex.IsMatch(_driver.FindElement(By.CssSelector("BODY")).Text,
                              "^[\\s\\S]*" + templateName + "[\\s\\S]*$");
            return cond1 || cond2;
        }

        private static void CheckMandant(string mandant)
        {
            Assert.IsTrue(Regex.IsMatch(_driver.FindElement(By.XPath("//tr[9]/td[2]/font/b")).Text, mandant),
                          "Mandant is not TKCPOS");
        }

        private static void CheckUser(string userId)
        {
            Assert.AreEqual(userId, _driver.FindElement(By.XPath("//td[2]/font/b")).Text);
        }

        private static void AddService(string serviceName, string templateName)
        {
            for (int i = 5; i > 0; i--)
            {
                try
                {
                    _driver.FindElement(By.CssSelector("img[alt=\"Service hinzufügen\"]")).Click();
                    _driver.FindAdaptedElement(By.CssSelector("select[name=\"ServiceId\"]")).Selector().SelectByText(
                        serviceName);
                    _driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
                    _driver.FindAdaptedElement((By.CssSelector("select[name=\"PTID_Perm\"]"))).Selector().SelectByText(
                        templateName);

                    i = 0;

                    _driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
                }
                catch (Exception)
                {
                    Console.Error.WriteLine("Still not deleted...retry {0}", i);
                }
            }
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "C:\\Users\\siegmund\\Desktop\\ProdSystemUsers.csv",
            "ProdSystemUsers#csv", DataAccessMethod.Sequential), TestMethod]
        public void CheckScs2ServiceToUsers()
        {
            string userId = Convert.ToString(TestContext.DataRow[0]);
            OpenUserPage(userId);

            CheckUser(userId);
            CheckMandant("TKCPOS");
            CheckServiceIsSet("SCS2.0", "SCS2 Dummy");
        }

        private static void OpenUserPage(string userId)
        {
            _driver.Navigate().GoToUrl(TestDirector.BaseUrl +
                                       "/login.asp?caller=&AcqName=&AcquirerLocationId=&username=" + userId);
            _driver.SwitchTo().Frame("main");
        }
    }

    public class UserNotFoundException : Exception
    {
    }
}