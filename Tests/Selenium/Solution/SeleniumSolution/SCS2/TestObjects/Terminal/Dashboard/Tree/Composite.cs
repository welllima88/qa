using System.Collections.Generic;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard.Tree
{
    public class Composite : IComponent
    {
        private readonly IList<IComponent> _composite;

        public Composite()
        {
            _composite = new List<IComponent>();
        }

        public void Add(IComponent webComponent)
        {
            _composite.Add(webComponent);
        }

        public void Remove(IComponent webComponent)
        {
            _composite.Remove(webComponent);
        }
    }
}