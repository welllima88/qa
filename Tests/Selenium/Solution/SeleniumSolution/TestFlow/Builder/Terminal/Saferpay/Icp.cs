using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Terminal;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Terminal.Saferpay
{
    public class Icp : TerminalBuilder
    {
        public Icp()
        {
            Terminal = new TestData.ValueObjects.Terminal {Type = "ICP"};
        }

        public override void Create()
        {
            ChooseArticle();
            SetBasics();
            Save();
            AddContracts();
            ReadInfo();
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