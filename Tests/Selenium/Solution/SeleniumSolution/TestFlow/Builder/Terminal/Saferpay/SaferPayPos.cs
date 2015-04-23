using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Model.Factory;
using Six.Scs.QA.Selenium.View.Terminal;
using Six.Scs.QA.Selenium.View.Terminal.Dashboard.Portlets;
using Six.Scs.QA.Selenium.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Terminal.Saferpay
{
    public class SaferPayPos : TerminalBuilder
    {
        public SaferPayPos()
        {
            Terminal = new Selenium.Model.ValueObjects.Terminal {Type = "Saferpay POS Terminal"};
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