using SIX.EP2.Core.Crypto;
using SIX.EP2.Core.Header;
using SIX.EP2.Core.Protocol;
using SIX.EP2.Core.Util;

namespace SIX.SCS.QA.Tests.EP2.Common
{
    public class SecurityProvider : IProvideSecurityInfo
    {
        private const string PublicKey =
            "800000000101121001018003C4213D101DE8E6FD8259730711AB377A1BF0EBC1E66578FBC1497E0F20C79BC858FFAA2A139B98B6D234CB2DAD25A193AE9EF056824736396DA2F9314AEA525407C80CA69C86E975F8ED5CC2E4BAFFE8D78D22B25E398A50242AAC3C22A6FB69696C959CED0EED04D5A0CB29FCFF160424D855DD6B886C24196485DD6DCD8F83010001373BFDC75FF0D8A30893E002A798B5BDB89D9C66";

        private static readonly byte[] ComponentSecret = "504237B4252ACAE353DF963151DE3054".AsHexBytes();

        public ISessionKeyProvider SessionKeyProvider { get; private set; }

        public string SenderIdentifier
        {
            get { return "8000000001"; }
        }

        public SenderType SenderType
        {
            get { return SenderType.ServiceCenter; }
        }

        public byte[] CompSecret
        {
            get { return ComponentSecret; }
        }

        public PublicKeyOwnerType PublicKeyOwner
        {
            get { return PublicKeyOwnerType.Acquirer; }
        }

        public string RecipientIdentifier
        {
            get { return "2"; }
        }

        public RsaKeyInfo Publickey
        {
            get { return new PubKeyParser().ParseFromString(PublicKey); }
        }
    }
}