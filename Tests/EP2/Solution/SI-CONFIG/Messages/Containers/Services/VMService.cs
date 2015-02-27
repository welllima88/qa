using System.Collections.Generic;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers.Services
{
	public class VMService : AIDBasedService
	{
		public VMService()
		{
			SetCrdTableRanges = new SetCrdTableRanges();
		}

		/*[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, MaxLength = 16)]
		public byte[] AID { get; set; }

		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, MaxLength = 16)]
		public string AppLabel { get; set; }

		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, MaxLength = 16)]
		public string Brand { get; set; }*/

		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, MaxLength = 4)]
		public byte[] VMTrmTrxFctCap { get; set; }

		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix)]
		public SetCrdTableRanges SetCrdTableRanges { get; set; }

		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix)]
		public CommAddrServHost CommAddrServHost { get; set; }
	}

    public class SetCrdTableRanges
	{
		public SetCrdTableRanges()
		{
			CrdTableRange = new List<CrdTableRanges>();
		}
		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix)]
		public IList<CrdTableRanges> CrdTableRange { get; set; }
	}

	public class CommAddrServHost
	{
		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, DataType = Ep2DataType.ans)]
		public string CommIpAddr { get; set; }
		
		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix)]
		public string CommIpPortNo { get; set; }
		
		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix)]
		public string CommNoPSTN { get; set; }
		
		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix)]
		public string InternetAddr { get; set; }

		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix)]
		public string InternetPortNo { get; set; }
	}

	public class CrdTableRanges
	{
		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix)]
		public int CrdTableStrtPrfx { get; set; }

		[Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix)]
		public int CrdTableEndPrfx { get; set; }
	}
}