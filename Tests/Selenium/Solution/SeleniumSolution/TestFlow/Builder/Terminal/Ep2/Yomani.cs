using System;
using NUnit.Framework;
using Six.Scs.Test.UI.Terminal;
using Six.Scs.Test.UI.Terminal.Dashboard;
using Six.Scs.Test.UI.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Terminal.Ep2
{
    public class Yomani : TerminalBuilder
    {
        public Yomani()
        {
            Terminal = Factory.Terminal.Yomani();
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
            ArticleChooser.Filter = "1550";
            ArticleChooser.Select = Terminal.Type;
        }

        protected override void SetBasics()
        {
            ConfigCreate.Status = "Aktiviert";
            ConfigCreate.SubStatus = "Aktiviert";
            ConfigCreate.ServiceCenter = "SIX Payment Services SC";
            ConfigCreate.Pms = "SIX Payment Services PMS";
        }

        protected override void SetDetails()
        {
            ConfigDetailsCreate.InstallType = "Installation";
            ConfigDetailsCreate.Contract = "Mietvertrag";
            ConfigDetailsCreate.SupportContract = "ServicePaket Pro+ - Störungsbehebung vor Ort Mo-So 5h";
            ConfigDetailsCreate.InstallRemark = "Install SYR Auto " + Factory.Base.GenerateTestId();
            ConfigDetailsCreate.EcrInterface = "MPD over IP";
            ConfigDetailsCreate.EcrText = "SYR with MPD over IP";
            ConfigDetailsCreate.MinimumContractPeriodDate = "20.02.2020";
        }
    }
}