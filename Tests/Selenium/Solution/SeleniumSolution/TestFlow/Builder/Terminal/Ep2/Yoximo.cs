using NUnit.Framework;
using Six.Scs.Test.View.Terminal;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Terminal.Ep2
{
    public class Yoximo : ArticelChangePerformer
    {
        public override void Check()
        {
            Assert.AreEqual("yoximo MOBILE WLAN, TCP/IP ep2 (DNS)", BusinessViewpoint.TerminalType);
        }

        protected override void SelectArticle()
        {
            // select and change and select again:
            ArticleChooser.Select = "yoximo MOBILE WLAN, TCP/IP ep2 (DNS)";
            ArticleChange.Change.Click();
            ArticleChooser.Select = "yoximo MOBILE WLAN, TCP/IP ep2 (DNS)";
        }

        protected override void CheckInfos()
        {
            Assert.IsTrue(ArticleChange.Change.Displayed);
        }
    }
}