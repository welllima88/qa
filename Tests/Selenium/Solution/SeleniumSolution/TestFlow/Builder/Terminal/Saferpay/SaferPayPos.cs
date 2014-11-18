using System;
using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Terminal.Saferpay
{
    public class SaferPayPos : TerminalBuilder
    {
        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override void Check()
        {
            throw new NotImplementedException();
        }

        protected override void ChooseArticle()
        {
            ArticleChooser.Filter = "Saferpay";
            ArticleChooser.Select = "Saferpay POS Terminal";
        }

        protected override void SetBasics()
        {
            ConfigCreate.Infotext = "E-Link" + Factory.GenerateTestId();
        }

        protected override void SetDetails()
        {
            // nothing
        }
    }
}