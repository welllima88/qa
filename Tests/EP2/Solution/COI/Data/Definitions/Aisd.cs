using System;

namespace Six.Scs.Ep2.Coi.Data.Definitions
{
    public static class Aisd
    {
        public static object Six()
        {
            throw new NotImplementedException();
        }

        public static object Swisscard()
        {
            return new SI.Config.Messages.Containers.Aisd
            {
                AcqID = 25,
                AcqInitPubKey =
                    "AAAAACUBEggBAYADrKtvCeH1tg2XfmMpkVP1SfIQq6B/VuNBDQaGFwjCpHB9qD05XSI7BYP3SE27GAr2x5jLU6xFuZdbZAuU+oG5y0Djx1hvw+ZzPO+6K9mwR4H09WYo2SjsvTtbZ5winhpuIpQGPvraF31/SFy/85u6/asxYKrOrHVBEfbkCWo/ylEBAAHu8PUXGeQV6Xyay0iDlOvL6VLrTA=="
            };
        }
    }
}

/*
 <?xml version="1.0" encoding="utf-8"?>
<ep2:message specversion="0600" xmlns:ep2="http://www.eftpos2000.ch">
	<ep2:cfgdatarsp>
		<ep2:AcqID>25</ep2:AcqID>
		<ep2:aisd>
			<ep2:AcqCctAddr>
				<ep2:CctFamN/>
				<ep2:CctFrstN/>
				<ep2:City>Horgen</ep2:City>
				<ep2:Cntry>Switzerland</ep2:Cntry>
				<ep2:CompName>Swisscard</ep2:CompName>
				<ep2:PC>8810</ep2:PC>
				<ep2:PhoneNo>+41 (0)44 659 61 11</ep2:PhoneNo>
				<ep2:StreetName>Neugasse 18</ep2:StreetName>
			</ep2:AcqCctAddr>
			<ep2:AcqID>25</ep2:AcqID>
			<ep2:AcqInitPubKey>AAAAACUBEggBAYADrKtvCeH1tg2XfmMpkVP1SfIQq6B/VuNBDQaGFwjCpHB9qD05XSI7BYP3SE27GAr2x5jLU6xFuZdbZAuU+oG5y0Djx1hvw+ZzPO+6K9mwR4H09WYo2SjsvTtbZ5winhpuIpQGPvraF31/SFy/85u6/asxYKrOrHVBEfbkCWo/ylEBAAHu8PUXGeQV6Xyay0iDlOvL6VLrTA==</ep2:AcqInitPubKey>
			<ep2:CommAddrAcqInitSrv />
			<ep2:ConfActivDate>20150604</ep2:ConfActivDate>
			<ep2:DataLastChDate>20150604</ep2:DataLastChDate>
			<ep2:DataStatus>1</ep2:DataStatus>
		</ep2:aisd>
		<ep2:SCID>8000000001</ep2:SCID>
	</ep2:cfgdatarsp>
</ep2:message> 
*/