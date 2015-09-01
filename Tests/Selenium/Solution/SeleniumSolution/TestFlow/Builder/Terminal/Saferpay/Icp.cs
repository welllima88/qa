using System;
using NUnit.Framework;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.View.Terminal;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Terminal.Saferpay
{
    public class Icp : TerminalBuilder
    {
        public Icp()
        {
            Terminal = new Model.Terminal {Type = "ICP"};
        }

        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override void Check()
        {
            Assert.AreEqual(Terminal.Type, BusinessViewpoint.TerminalType);
        }

        protected override void ChooseArticle()
        {
            ArticleChooser.Select = Terminal.Type;
        }

        protected override void SetBasics()
        {
            ConfigCreate.Infotext = "GICC" + Factory.GenerateTestId();
        }

        protected override void SetDetails()
        {
        }
    }
}