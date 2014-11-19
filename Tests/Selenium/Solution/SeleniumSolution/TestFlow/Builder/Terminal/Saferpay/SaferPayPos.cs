using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Terminal.Saferpay
{
    public class SaferPayPos : TerminalBuilder
    {
        public SaferPayPos()
        {
            Terminal = new TestData.ValueObjects.Terminal {Type = "Saferpay POS Terminal"};
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