using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers.Services
{
    /// <summary>
    ///     A Sevice controlled by an AID which is sent to the terminal
    /// </summary>
    public class AIDBasedService
    {
        [Ep2DataElement(TagPrefix = CustomPrefixes.Six, MaxLength = 16)]
        public byte[] AID { get; set; }

        [Ep2DataElement(TagPrefix = CustomPrefixes.Six, MaxLength = 16)]
        public string AppLabel { get; set; }

        [Ep2DataElement(TagPrefix = CustomPrefixes.Six, MaxLength = 16)]
        public string Brand { get; set; }
    }
}