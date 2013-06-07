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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.Support
{
    /// <summary>
    /// be careful with menu expander because they prevent some actions and need special handling 
    /// </summary>
    [TestClass]
    public class AddScs2ServiceToUsers
    {
        private const string BaseUrl = "https://gateint.telekurs.ch/scsc-qa-l";
        private static IWebDriverAdapter _driver;
        private static TestDirector _tb;
        private string userId = "tksyr";

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

        [TestMethod]
        public void CheckLobbyMenu()
        {
            _driver.Navigate().GoToUrl(BaseUrl +
                                       "/login.asp?caller=&AcqName=&AcquirerLocationId=&username=" + userId);
            _driver.SwitchTo().Frame("main");
            _driver.FindElement(By.CssSelector("img[alt=\"Service hinzufügen\"]")).Click();
            new SelectElement(_driver.FindElement(By.CssSelector("select[name=\"ServiceId\"]"))).SelectByText("");
            _driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            new SelectElement(_driver.FindElement(By.CssSelector("select[name=\"PTID_Perm\"]"))).SelectByText("ummy");
            _driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
            Assert.AreEqual("plgre", _driver.FindElement(By.XPath("//td[2]/font/b")).Text);
        }
    }
}