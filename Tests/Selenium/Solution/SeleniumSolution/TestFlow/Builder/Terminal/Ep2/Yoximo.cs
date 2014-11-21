using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Terminal.Ep2
{
    public class Yoximo : ArticelChangePerformer
    {
        public void Check()
        {
            Assert.AreEqual("yoximo MOBILE WLAN, TCP/IP ep2 (DNS)", BusinessViewpoint.TerminalType);
        }

        protected override void SelectArticle()
        {
            ArticleChooser.Select = article;
        }

        protected override void CheckInfos()
        {
            throw new NotImplementedException();
        }
    }
}