using NUnit.Framework;
using SIX.EP2.Client;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;
using SIX.SCS.QA.Tests.EP2.Laid;
using SIX.SCS.QA.Tests.EP2.Message;
using SIX.SCS.QA.Tests.EP2.Setup;

namespace SIX.SCS.QA.Tests.EP2.Test
{
    [TestFixture]
    [Category("COI"), Category("EP2"), Category("LAID")]
    public class LaidRequestTest
    {
        [SetUp]
        public void SendMessage()
        {
            var messageMapper =
                MessageVersionMapper.Builder.AddFromAssemblyOfType<ConfigDataRequest>().Build();

            _clientProtocol = ClientProtocolBuilder.ClientProtocolWith(messageMapper);

            // _clientProtocol.WithSecurityProvider(new SecurityProvider());
        }

        private IRequestResponseClient _clientProtocol;

        [Test]
        public void ResponseWithCorrectData()
        {
            var handlerSessionHandler = new LaidHandler();
            _clientProtocol.SendWith(Communication.Dev(), handlerSessionHandler);

            Assert.That(handlerSessionHandler.ListOfAid.Count, Is.EqualTo(19));
            // CollectionAssert.AreEquivalent(Defined.Laid(), handlerSessionHandler.ListOfAid);
            Assert.That(handlerSessionHandler.ListOfAid, Is.EquivalentTo(Defined.Laid()));
        }
    }
}