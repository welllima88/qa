using System;
using NUnit.Framework;
using Six.Scs.Test.View.Terminal;
using Six.Scs.Test.View.Terminal.Dashboard;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Terminal.Ep2
{
    public class Xentissimo : TerminalBuilder
    {
        public Xentissimo()
        {
            Terminal = Factory.Terminal.Xentissimo();
        }

        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override void Check()
        {
            Assert.AreEqual(Terminal.Id, TerminalInfo.TerminalId);
            Assert.AreEqual("Aktiviert - Aktiviert", BusinessViewpoint.Status);
            Assert.AreEqual(Terminal.Type, BusinessViewpoint.TerminalType);
            Assert.AreEqual(Terminal.Color, BusinessViewpoint.Color);
        }

        protected override void ChooseArticle()
        {
            ArticleChooser.Filter = "xentissimo MOBILE WLAN, TCP/IP";
            ArticleChooser.Select = "xentissimo MOBILE WLAN, TCP/IP";
        }

        protected override void SetBasics()
        {
            ConfigCreate.Infotext = "Infotext SYR Terminal - xentissimo MOBILE WLAN, TCP/IP " + Factory.Base.GenerateTestId();
        }

        protected override void SetDetails()
        {
            ConfigDetailsCreate.InstallRemark = "Install SYR Auto " + Factory.Base.GenerateTestId();
            ConfigDetailsCreate.MinimumContractPeriodDate = "20.02.2020";
        }
    }
}