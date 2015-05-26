using System;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.QA.Tests.EP2.Message.Elements
{
    [Ep2DataElement(TagName = "tcd")]
    public class Tcd
    {
        [Ep2DataElement(TagName = "CtlessInd", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false)]
        public int? CtlessInd { get; set; }

        [Ep2DataElement(TagName = "AddTrmCap", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = true)]
        public byte[] AddTrmCap { get; set; }

        [Ep2DataElement(TagName = "AutoDeclRef", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false)]
        public int AutoDeclRef { get; set; }

        [Ep2DataElement(TagName = "CashRegIntgT", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int? CashRegIntgT { get; set; }

        [Ep2DataElement(TagName = "CompSecret", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = false,
            Encrypted = true)]
        public byte[] CompSecret { get; set; }

        [Ep2DataElement(TagName = "CrdRdType", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int CrdRdType { get; set; }

        [Ep2DataElement(TagName = "DataSubmMaxRetry", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int DataSubmMaxRetry { get; set; }

        [Ep2DataElement(TagName = "DataSubmRetryDel", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int DataSubmRetryDel { get; set; }

        [Ep2DataElement(TagName = "DataSubmTime", TagPrefix = "ep2", DataType = Ep2DataType.time, IsMandatory = false)]
        public DateTime DataSubmTime { get; set; }

        [Ep2DataElement(TagName = "DataSubmTrigg", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int DataSubmTrigg { get; set; }

        [Ep2DataElement(TagName = "DSub", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int DSub { get; set; }

        [Ep2DataElement(TagName = "MctCC", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int? MctCC { get; set; }

        [Ep2DataElement(TagName = "MerchantPwd", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false)]
        public int? MerchantPwd { get; set; }

        [Ep2DataElement(TagName = "MctID", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string MctID { get; set; }

        [Ep2DataElement(TagName = "PMSID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false)]
        public string PMSID { get; set; }

        [Ep2DataElement(TagName = "SCID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public string SCID { get; set; }

        [Ep2DataElement(TagName = "SCIntConf", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int? SCIntConf { get; set; }

        [Ep2DataElement(TagName = "SubmInt", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int? SubmInt { get; set; }

        [Ep2DataElement(TagName = "SuppPhone", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public string SuppPhone { get; set; }

        [Ep2DataElement(TagName = "TrmCap", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = true)]
        public byte[] TrmCap { get; set; }

        [Ep2DataElement(TagName = "TrmCntryC", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int TrmCntryC { get; set; }

        [Ep2DataElement(TagName = "TrmID", TagPrefix = "ep2", DataType = Ep2DataType.uan, IsMandatory = true)]
        public string TrmID { get; set; }

        [Ep2DataElement(TagName = "TrmProd", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = false)]
        public string TrmProd { get; set; }

        [Ep2DataElement(TagName = "TrmRMCap", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = true)]
        public byte[] TrmRMCap { get; set; }

        [Ep2DataElement(TagName = "TrmTrxFctCap", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = true)]
        public byte[] TrmTrxFctCap { get; set; }

        [Ep2DataElement(TagName = "TrmType", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int TrmType { get; set; }

        [Ep2DataElement(TagName = "TSUID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false)]
        public string TSUID { get; set; }

        [Ep2DataElement(TagName = "TSUName", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = false)]
        public string TSUName { get; set; }

        [Ep2DataElement(TagName = "VersSW", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int VersSW { get; set; }

        [Ep2DataElement(TagName = "SCConfTime", TagPrefix = "ep2", DataType = Ep2DataType.time, IsMandatory = false)]
        public DateTime? SCConfTime { get; set; }

        [Ep2DataElement(TagName = "TrxSubmLim", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int TrxSubmLim { get; set; }

        [Ep2DataElement(TagName = "ConfActivDate", TagPrefix = "ep2", DataType = Ep2DataType.date, IsMandatory = true)]
        public DateTime? ConfActivDate { get; set; }

        [Ep2DataElement(TagName = "AdminRem", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true)]
        public string AdminRem { get; set; }

        [Ep2DataElement(TagName = "FinBalInd", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false)]
        public int? FinBalInd { get; set; }

        [Ep2DataElement(TagName = "DataStatus", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int DataStatus { get; set; }

        [Ep2DataElement(TagName = "DataLastChDate", TagPrefix = "ep2", DataType = Ep2DataType.date, IsMandatory = true)]
        public DateTime? DataLastChDate { get; set; }

        [Ep2DataElement(TagName = "ContractPNo", TagPrefix = "ep2", DataType = Ep2DataType.an, IsMandatory = false)]
        public string ContractPNo { get; set; }

        [Ep2DataElement(TagName = "CommType", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true)]
        public int? CommType { get; set; }

        [Ep2DataElement(TagName = "SCType", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false)]
        public int? SCType { get; set; }

        [Ep2DataElement(TagName = "DCCProvider", TagPrefix = "ep2")]
        public int? DccProviderId { get; set; }
    }
}