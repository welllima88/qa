using NUnit.Framework;
using SIX.EP2.Client;
using SIX.EP2.Core.Comm;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;
using SIX.SCS.QA.Tests.EP2.Common;

namespace SIX.SCS.QA.Tests.EP2.Laid
{
    [TestFixture]
    [Category("COI"), Category("EP2"), Category("LAID")]
    public class LaidRequestTest
    {
        private IRequestResponseClient _clientProtocol;
        private ComConfig _comConfig;

        [TestFixtureSetUp]
        public void SendMessage()
        {
            IMessageVersionMapper messageMapper =
                MessageVersionMapper.Builder.AddFromAssemblyOfType<ConfigDataRequest>().Build();

            _comConfig = new ComConfig
            {
                Port = 2253,
                ServerAddress = "mdzhwcweb01",
                Version = "0600"
            };

            _clientProtocol = ClientProtocolBuilder.ClientProtocolWith(messageMapper);

            // _clientProtocol.WithSecurityProvider(new SecurityProvider());
        }

        [Test]
        public void ResponseWithCorrectData()
        {
            var handlerSessionHandler = new LaidHandler();
            _clientProtocol.SendWith(_comConfig, handlerSessionHandler);

            Assert.AreEqual(19, handlerSessionHandler.ListOfAid.Count);
            CollectionAssert.AreEquivalent(Defined.Laid(), handlerSessionHandler.ListOfAid);
        }
    }
}