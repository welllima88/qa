using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Model.Factory;
using Six.Scs.QA.Selenium.View.Terminal;
using Six.Scs.QA.Selenium.View.Terminal.Dashboard;
using Six.Scs.QA.Selenium.View.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Selenium.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Terminal.Ep2
{
    public class Xentissimo : TerminalBuilder
    {
        public Xentissimo()
        {
            Terminal = Selenium.Model.Factory.Terminal.Xentissimo();
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
            ConfigCreate.Infotext = "Infotext SYR Terminal - xentissimo MOBILE WLAN, TCP/IP " + Factory.GenerateTestId();
        }

        protected override void SetDetails()
        {
            ConfigDetailsCreate.InstallRemark = "Install SYR Auto " + Factory.GenerateTestId();
            ConfigDetailsCreate.MinimumContractPeriodDate = "20.02.2020";
        }
    }
}