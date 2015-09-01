using NUnit.Framework;
using Six.Scs.Test.View.Common.Menu;
using Six.Scs.Test.View.Terminal;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Article
{
    [TestFixture]
    public class DirectSelectTest
    {
        [TestFixtureSetUp]
        public void TestInit()
        {
            TestDirector.Navigate("Location?LocationId=261a0d6e-8136-4b48-95f4-bfcb986a142c");
            View.Location.View.TerminalCreate.Click();
        }

        [Test]
        public void DirectArticleSelect()
        {
            const string termType = "xentissimo";
            const string article = "xentissimo MOBILE WLAN, TCP/IP";

            ArticleChooser.Filter = " ";
            ArticleChooser.Filter = "";
            ArticleChooser.Select = article;

            Assert.That(ConfigCreate.TerminalType.Equals(termType));
            Assert.That(View.Common.Lobby.Headline.Text.Contains(article));
        }
    }
}