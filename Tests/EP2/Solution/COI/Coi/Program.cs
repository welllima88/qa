using System;
using SIX.EP2.Client;
using SIX.EP2.Core.Comm;
using SIX.EP2.Core.ContentHandling;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;
using SIX.EP2.Core.Crypto;
using SIX.EP2.Core.Header;
using SIX.EP2.Core.MessageHandling;
using SIX.EP2.Core.Protocol;

namespace SIX.SCS.QA.Tests.EP2.Coi
{
    public class MySecurityProvider : IProvideSecurityInfo
    {
        public ISessionKeyProvider SessionKeyProvider { get; private set; }
        public string SenderIdentifier { get; private set; }

        public SenderType SenderType
        {
            get { return SenderType.ServiceCenter; }
        }

        public byte[] CompSecret { get; private set; }

        public PublicKeyOwnerType PublicKeyOwner
        {
            get { return PublicKeyOwnerType.Acquirer; }
        }

        public string RecipientIdentifier
        {
            get { return "08000001"; }
        }

        public RsaKeyInfo Publickey { get; private set; }
    }

    public class MyHandler :
        IClientSessionHandler,
        IStartWith<ConfigDataNotification>,
        IHandleMessage<ConfigResponse>,
        IHandleMessage<ErrorNotification>

    {
        public void EnrichErrorMessage(ErrorNotification errorNotification, Exception ex)
        {
        }

        public bool IsDone
        {
            get { return true; }
        }

        public IMessage Respond(ConfigResponse request)
        {
            return null;
        }

        public IMessage Respond(ErrorNotification request)
        {
            return null;
        }

        public void FirstMessage(ConfigDataNotification msg)
        {
            msg.AcqID = "3";
        }
    }

    [Ep2Message("ep2:cfasf")]
    [Ep2Version("0530")]
    public class ConfigResponse : IMessage
    {
    }

    [Ep2Message("ep2:cfgstart")]
    [Ep2Version("0530")]
    public class ConfigRequest : IMessage
    {
        [Ep2DataElement(TagName = "AcqID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int AcqId { get; set; }

        [Ep2DataElement(TagName = "Blah", TagPrefix = "")]
        public string Blah { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            IMessageVersionMapper messageMapper =
                MessageVersionMapper.Builder.AddFromAssemblyOfType<ConfigRequest>().Build();

            IRequestResponseClient clientProtocol = ClientProtocolBuilder.ClientProtocolWith(messageMapper);
            var sessionHandler = new MyHandler();
            var comConfig = new ComConfig
            {
                Port = 2253,
                ServerAddress = "mdzhwcweb01",
                Version = "0530"
            };
            clientProtocol.SendWith(comConfig, sessionHandler);
        }
    }
}