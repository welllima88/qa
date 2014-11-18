using System;
using Six.Scs.QA.Selenium.Terminal;
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
            throw new NotImplementedException();
        }

        protected override void ChooseArticle()
        {
            ArticleChooser.Select = Terminal.Type;
        }

        protected override void SetBasics()
        {
            Console.Out.WriteLine("No basic Settings");
        }

        protected override void SetDetails()
        {
            Console.Out.WriteLine("No detail Settings");
        }
    }
}