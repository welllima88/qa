using SIX.EP2.Core.Crypto;
using SIX.EP2.Core.Header;
using SIX.EP2.Core.Protocol;
using SIX.EP2.Core.Util;

namespace SIX.SCS.QA.Tests.EP2.COI
{
    public class ProvideSecurityInfo : IProvideSecurityInfo
    {
        public ProvideSecurityInfo()
        {
            SenderType = SenderType.ServiceCenter;
            PublicKeyOwner = PublicKeyOwnerType.Acquirer;
            RecipientIdentifier = "08000000001";
            SenderIdentifier = "08000000027";
            Publickey =
                new PubKeyParser().ParseFromString(
                    "800000000101121001018003C4213D101DE8E6FD8259730711AB377A1BF0EBC1E66578FBC1497E0F20C79BC858FFAA2A139B98B6D234CB2DAD25A193AE9EF056824736396DA2F9314AEA525407C80CA69C86E975F8ED5CC2E4BAFFE8D78D22B25E398A50242AAC3C22A6FB69696C959CED0EED04D5A0CB29FCFF160424D855DD6B886C24196485DD6DCD8F83010001373BFDC75FF0D8A30893E002A798B5BDB89D9C66");
            CompSecret = "504237B4252ACAE353DF963151DE3054".AsHexBytes();
        }

        public ISessionKeyProvider SessionKeyProvider { get; private set; }
        public string SenderIdentifier { get; private set; }
        public SenderType SenderType { get; private set; }
        public byte[] CompSecret { get; private set; }
        public PublicKeyOwnerType PublicKeyOwner { get; private set; }
        public string RecipientIdentifier { get; private set; }
        public RsaKeyInfo Publickey { get; private set; }
    }
}