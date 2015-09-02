using System;
using NUnit.Framework;
using Six.Scs.Test.View.Terminal;
using Six.Scs.Test.View.Terminal.Dashboard;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Terminal.Ifsf
{
    public class Davinci2 : TerminalBuilder
    {
        public Davinci2()
        {
            Terminal = Factory.Terminal.DavinciIfsf();
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
        }

        protected override void ChooseArticle()
        {
            ArticleChooser.Filter = "iFSf";
            ArticleChooser.Select = Terminal.Type;
        }

        protected override void SetBasics()
        {
            ConfigCreate.Status = "Aktiviert";
            ConfigCreate.SubStatus = "Aktiviert";
            ConfigCreate.ServiceCenter = "SIX Payment Services SC";
            ConfigCreate.Pms = "SIX Payment Services PMS";
            ConfigCreate.Infotext = "Infotext SYR Terminal -" + Terminal.Type + Factory.Base.GenerateTestId();
            Assert.That(ConfigCreate.Protocol, Is.EqualTo("IFSF"));
        }

        protected override void SetDetails()
        {
            ConfigDetailsCreate.InstallType = "Abholung";
            ConfigDetailsCreate.Contract = "Leihgerät";
            ConfigDetailsCreate.SupportContract = "ServicePaket Pro+ - Störungsbehebung vor Ort Mo-So 5h";
            ConfigDetailsCreate.InstallRemark = "Install SYR Auto " + Terminal.Type + Factory.Base.GenerateTestId();
            ConfigDetailsCreate.MinimumContractPeriodDate = "20.02.2020";
        }
    }
}