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
using OpenQA.Selenium.Support.UI;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.Support
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestClass]
    public class AddServiceToUsers
    {
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _tb = new ScsClassicTestDirector();
            _tb.DefaultTestSetup();
            _driver = _tb.WebDriver;
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _tb.ShutDownTest();
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "C:\\Users\\siegmund\\Desktop\\ProdSystemUsers.csv",
            "ProdSystemUsers#csv", DataAccessMethod.Sequential), TestMethod]
        public void AddScs2ServiceToUsers()
        {
            string userId = Convert.ToString(TestContext.DataRow[0]);

            OpenUserPage(userId);

            _driver.SwitchTo().Frame("main");

            CheckUser(userId);
            CheckMandant();
            CheckNewScs2IsNotAlreadySet();

            AddScs2Service();

            CheckUser(userId);
            CheckNewServiceIsSet();
        }

        private static void CheckNewServiceIsSet()
        {
            Assert.IsTrue(
                Regex.IsMatch(_driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*SCS2 Dummy[\\s\\S]*$"),
                "Seems to be already mutated");
            Assert.IsTrue(
                Regex.IsMatch(_driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*SCS2.0[\\s\\S]*$"),
                "Seems to be already mutated");
        }

        private static void CheckMandant()
        {
            Assert.IsTrue(Regex.IsMatch(_driver.FindElement(By.XPath("//tr[9]/td[2]/font/b")).Text, "TKCPOS"),
                          "Mandant is not TKCPOS");
        }

        private static void CheckUser(string userId)
        {
            Assert.AreEqual(userId, _driver.FindElement(By.XPath("//td[2]/font/b")).Text);
        }

        private static void AddScs2Service()
        {
            _driver.FindElement(By.CssSelector("img[alt=\"Service hinzufügen\"]")).Click();
            new SelectElement(_driver.FindElement(By.CssSelector("select[name=\"ServiceId\"]"))).SelectByText("SCS2.0");
            _driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            new SelectElement(_driver.FindElement(By.CssSelector("select[name=\"PTID_Perm\"]"))).SelectByText(
                "SCS2 Dummy");
            _driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        private static void CheckNewScs2IsNotAlreadySet()
        {
            Assert.IsFalse(
                Regex.IsMatch(_driver.FindElement(By.CssSelector("BODY")).Text, "^[\\s\\S]*SCS2 Dummy[\\s\\S]*$"),
                "Seems to be already mutated");
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "C:\\Users\\siegmund\\Desktop\\ProdSystemUsers.csv",
            "ProdSystemUsers#csv", DataAccessMethod.Sequential), TestMethod]
        public void CheckScs2ServiceToUsers()
        {
            string userId = Convert.ToString(TestContext.DataRow[0]);
            OpenUserPage(userId);

            _driver.SwitchTo().Frame("main");

            CheckUser(userId);
            CheckMandant();
            CheckNewServiceIsSet();
        }

        private static void OpenUserPage(string userId)
        {
            _driver.Navigate().GoToUrl(_tb.BaseUrl +
                                       "/login.asp?caller=&AcqName=&AcquirerLocationId=&username=" + userId);
        }
    }
}