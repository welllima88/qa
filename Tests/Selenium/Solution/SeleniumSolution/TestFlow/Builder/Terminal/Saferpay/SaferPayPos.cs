using System;
using NUnit.Framework;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.View.Terminal;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Terminal.Saferpay
{
    public class SaferPayPos : TerminalBuilder
    {
        public SaferPayPos()
        {
            Terminal = new Model.ValueObjects.Terminal {Type = "Saferpay POS Terminal"};
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
            ArticleChooser.Filter = "Saferpay";
            ArticleChooser.Select = Terminal.Type;
        }

        protected override void SetBasics()
        {
            ConfigCreate.Infotext = "E-Link" + Factory.GenerateTestId();
        }

        protected override void SetDetails()
        {
        }
    }
}