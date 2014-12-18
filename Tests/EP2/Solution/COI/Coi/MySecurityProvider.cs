using SIX.EP2.Core.Crypto;
using SIX.EP2.Core.Header;
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
}