using System;
using NUnit.Framework;
using Six.Scs.Test.Factory;
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
            SaferPay.Reason = "GICC" + Base.GenerateTestId();
        }

        protected override void SetDetails()
        {
        }

        public override void Create()
        {
            ChooseArticle();
            SetBasics();
            SaferPay.Save();
            AddContracts();
            ReadInfo();
        }
    }
}