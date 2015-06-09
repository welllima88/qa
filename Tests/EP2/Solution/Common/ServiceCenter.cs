using SIX.EP2.Core.Header;

namespace Six.Scs.Ep2.Test
{
    public class ServiceCenter : IServiceCenter

    {
        public string ComponentSecret = "504237B4252ACAE353DF963151DE3054"; // SIX (Acq-Key?? -SCS?
        public int Port = 2253;

        public string PublicKey =
            "800000000101121001018003C4213D101DE8E6FD8259730711AB377A1BF0EBC1E66578FBC1497E0F20C79BC858FFAA2A139B98B6D234CB2DAD25A193AE9EF056824736396DA2F9314AEA525407C80CA69C86E975F8ED5CC2E4BAFFE8D78D22B25E398A50242AAC3C22A6FB69696C959CED0EED04D5A0CB29FCFF160424D855DD6B886C24196485DD6DCD8F83010001373BFDC75FF0D8A30893E002A798B5BDB89D9C66";

        public PublicKeyOwnerType PublicKeyOwnerType = PublicKeyOwnerType.Acquirer;
        public string RecipientId = "08000000001";
        public string SenderId = "08000000027";
        public SenderType SenderType = SenderType.ServiceCenter;
        public string ServerAddress = "mdzhwcweb01";
        public string SessionKey = "11 22 33 44 55 66 77 88 99 00 11 22 33 44 55 66";
        public string Version = "0520";
    }

    public interface IServiceCenter
    {
    }
}