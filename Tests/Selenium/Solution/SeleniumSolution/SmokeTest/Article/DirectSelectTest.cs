using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Common.Menu;
using Six.Scs.QA.Selenium.View.Terminal;

namespace Six.Scs.QA.Selenium.SmokeTest.Article
{
    [TestFixture]
    public class DirectSelectTest
    {
        [TestFixtureSetUp]
        public void TestInit()
        {
            TestDirector.Navigate("Location?LocationId=261a0d6e-8136-4b48-95f4-bfcb986a142c");
            LocationMenu.TerminalCreate.Click();
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
            Assert.IsTrue(View.Common.Lobby.Headline.Text.Contains(article));
        }
    }
}