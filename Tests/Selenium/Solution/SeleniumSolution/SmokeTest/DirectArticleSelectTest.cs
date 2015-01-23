using NUnit.Framework;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Terminal;

namespace Six.Scs.QA.Selenium.SmokeTest
{
    [TestFixture]
    public class DirectArticleSelectTest
    {
        [TestFixtureSetUp]
        public void TestInit()
        {
            TestDirector.Navigate("Customer/?CustomerId=1");
            CustomerMenu.TerminalCreate.Click();
        }

        [Test]
        public void DirectArticleSelect()
        {
            const string termType = "xentissimo";
            const string article = "xentissimo MOBILE WLAN, TCP/IP";

            ArticleChooser.Filter = " ";
            ArticleChooser.Filter = "";
            ArticleChooser.Select = article;

            Assert.IsTrue(ConfigCreate.TerminalType.Equals(termType));
            Assert.IsTrue(Common.Lobby.Headline.Text.Contains(article));

            // get to initial point
            CustomerMenu.TerminalCreate.Click();
        }
    }
}