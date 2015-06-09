using System;
using Six.Scs.Ep2.SI.Config.Messages.Containers.Services;
using SIX.EP2.Core.ContentHandling.Common;
using SIX.EP2.Core.ContentHandling.Serialization;

namespace Six.Scs.Ep2.SI.Config.Messages.Containers
{
    public abstract class TcdBase
    {
        /*Negativ Receipt Indikator */

        [Ep2DataElement(TagName = "NegReceiptInd", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public int? NegReceiptInd { get; set; }

        /*Config Receipt Indikator */

        [Ep2DataElement(TagName = "ConfigReceiptInd", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public int? ConfigReceiptInd { get; set; }

        /*Acquier Init Receipt Indikator */

        [Ep2DataElement(TagName = "AcquierInitReceiptInd", TagPrefix = CustomPrefixes.Six,
            DataType = Ep2DataType.n, IsMandatory = false, MaxLength = 1)]
        public int? AcquierInitReceiptInd { get; set; }

        /*Submission Transmission Receipt Indikator */

        [Ep2DataElement(TagName = "SubmTransmReceiptInd", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public int? SubmTransmReceiptInd { get; set; }

        /*Static IP Addressing */

        [Ep2DataElement(TagName = "StaticIpInd", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public bool? StaticIpInd { get; set; }

        /*Gklpinit required */

        [Ep2DataElement(TagName = "GKLPInit", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = true, MaxLength = 1)]
        public bool GKLPInit { get; set; }

        /*Instalment indicator */

        [Ep2DataElement(TagName = "InstalmentInd", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public bool? InstalmentInd { get; set; }

        /* */

        [Ep2DataElement(TagName = "CashBackInd", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public bool? CashBackInd { get; set; }

        /*Terminal Transaction Function Extended Capabilities */

        [Ep2DataElement(TagName = "TrmTrxFctCapExt", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.b,
            IsMandatory = false, MaxLength = 2)]
        public virtual byte[] TrmTrxFctCapExt { get; set; }

        /*Trace Definitionen */

        [Ep2DataElement(TagName = "TraceLogActSetup", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.ans,
            IsMandatory = false, MaxLength = 1024)]
        public string TraceLogActSetup { get; set; }

        /*Destination Device For Logdata */

        [Ep2DataElement(TagName = "TraceLogMedium", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public int? TraceLogMedium { get; set; }

        /*Container With Communication Parameters Of TraceLog Config */

        [Ep2DataElement(TagName = "TraceLogDestAddr", TagPrefix = CustomPrefixes.Six, IsMandatory = false)]
        public TraceLogDestAddr TraceLogDestAddr { get; set; }

        /*Neues Tag TrmRebootInt */

        [Ep2DataElement(TagName = "TrmRebootInt", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 2)]
        public int? TrmRebootInt { get; set; }

        /*Set if the Terminal performs online Financial Advices */

        [Ep2DataElement(TagName = "FinAdvSubmCopyInd", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = true, MaxLength = 1)]
        public bool FinAdvSubmCopyInd { get; set; }

        /*Queue Size */

        [Ep2DataElement(TagName = "MaxFinAdvQueueSize", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = true, MaxLength = 5)]
        public int MaxFinAdvQueueSize { get; set; }

        /*Additional Terminal Capabilities */

        [Ep2DataElement(TagName = "AddTrmCap", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = true,
            MaxLength = 5)]
        public byte[] AddTrmCap { get; set; }

        /*Auto Decline of Referral */

        [Ep2DataElement(TagName = "AutoDeclRef", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 1)]
        public bool AutoDeclRef { get; set; }

        /*CardTypeReader */

        [Ep2DataElement(TagName = "CrdRdType", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 2)]
        public int CrdRdType { get; set; }

        /*Cash Register Information */

        [Ep2DataElement(TagName = "CashRegIntgT", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 2)]
        public bool CashRegIntgT { get; set; }

        /*Communcation Addr PMS */

        [Ep2DataElement(TagName = "CommAddrPMS", TagPrefix = "ep2", IsMandatory = true)]
        public CommAddr CommAddrPMS { get; set; }

        /*Communication Addr Service Center Config */

        [Ep2DataElement(TagName = "CommAddrSCConf", TagPrefix = "ep2", IsMandatory = true)]
        public CommAddr CommAddrSCConf { get; set; }

        /*Component Secret */

        [Ep2DataElement(TagName = "CompSecret", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = false,
            Encrypted = true, MaxLength = 16)]
        public byte[] CompSecret { get; set; }

        /*Data Submission Mode */

        [Ep2DataElement(TagName = "DSub", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true, MaxLength = 1
            )]
        public int DSub { get; set; }

        /*Data Submission Max Retry */

        [Ep2DataElement(TagName = "DataSubmMaxRetry", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 2)]
        public int DataSubmMaxRetry { get; set; }

        /*Data Submission Retry Delay */

        [Ep2DataElement(TagName = "DataSubmRetryDel", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 6)]
        public int DataSubmRetryDel { get; set; }

        /*Data Submission Time */

        [Ep2DataElement(TagName = "DataSubmTime", TagPrefix = "ep2", DataType = Ep2DataType.time, IsMandatory = true,
            MaxLength = 6)]
        public DateTime DataSubmTime { get; set; }

        /*Data Submission Trigger */

        [Ep2DataElement(TagName = "DataSubmTrigg", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 1)]
        public int DataSubmTrigg { get; set; }

        /*Data Transmission Max Tetry */

        [Ep2DataElement(TagName = "DataTransMaxRetry", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 2)]
        public int DataTransMaxRetry { get; set; }

        /*Data Transmission Retry Delay */

        [Ep2DataElement(TagName = "DataTransRetryDel", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 6)]
        public int DataTransRetryDel { get; set; }

        /*Data Transmission Time */

        [Ep2DataElement(TagName = "DataTransTime", TagPrefix = "ep2", DataType = Ep2DataType.time, IsMandatory = true,
            MaxLength = 6)]
        public DateTime DataTransTime { get; set; }

        /*Data Transmission Trigger */

        [Ep2DataElement(TagName = "DataTransTrigg", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 1)]
        public int DataTransTrigg { get; set; }

        /*Max Storage Percentage */

        [Ep2DataElement(TagName = "MaxStor", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 3)]
        public int? MaxStor { get; set; }

        /*Merchant Identifier */

        [Ep2DataElement(TagName = "MctID", TagPrefix = "ep2", DataType = Ep2DataType.ans, IsMandatory = true,
            MaxLength = 15)]
        public string MctID { get; set; }

        /*Phone Prefix Number */

        [Ep2DataElement(TagName = "PhonePrfx", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 12)]
        public string PhonePrfx { get; set; }

        /*PMS Identifier */

        [Ep2DataElement(TagName = "PMSID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 11)]
        public string PMSID { get; set; }

        /*PMS Public Key */

        [Ep2DataElement(TagName = "PMSPubKey", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = false,
            MaxLength = 283)]
        public byte[] PMSPubKey { get; set; }

        /*Reversal Message Retry Deleay */

        [Ep2DataElement(TagName = "RevRetryDel", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int RevRetryDel { get; set; }

        /*Service Center Config Time */

        [Ep2DataElement(TagName = "SCConfTime", TagPrefix = "ep2", DataType = Ep2DataType.time, IsMandatory = true,
            MaxLength = 6)]
        public DateTime SCConfTime { get; set; }

        /*Service Center Identifier */

        [Ep2DataElement(TagName = "SCID", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 11)]
        public long SCID { get; set; }

        /*Service Center Interval Configuration */

        [Ep2DataElement(TagName = "SCIntConf", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int SCIntConf { get; set; }

        /*Service Center Public Key */

        [Ep2DataElement(TagName = "SCPubKey", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = false,
            MaxLength = 283)]
        public byte[] SCPubKey { get; set; }

        /*Static Key PAN Receipt */

        [Ep2DataElement(TagName = "StatKeyPANRct", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = false,
            MaxLength = 16)]
        public byte[] StatKeyPANRct { get; set; }

        /*Submission Interval */

        [Ep2DataElement(TagName = "SubmInt", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 6)]
        public int? SubmInt { get; set; }

        /*Support Phone Number */

        [Ep2DataElement(TagName = "SuppPhone", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 64)]
        public string SuppPhone { get; set; }

        /*Terminal Capabilities */

        [Ep2DataElement(TagName = "TrmCap", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = true,
            MaxLength = 3)]
        public byte[] TrmCap { get; set; }

        /*Terminal Country Code */

        [Ep2DataElement(TagName = "TrmCntryC", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 3)]
        public int? TrmCntryC { get; set; }

        /*Terminal Identifier */

        [Ep2DataElement(TagName = "TrmID", TagPrefix = "ep2", DataType = Ep2DataType.uan, IsMandatory = true,
            MaxLength = 8)]
        public string TrmID { get; set; }

        /*Terminal Local Language */

        [Ep2DataElement(TagName = "TrmLng", TagPrefix = "ep2", DataType = Ep2DataType.an, IsMandatory = true,
            MaxLength = 2)]
        public string TrmLng { get; set; }

        /*Terminal Risk Management Capability */

        [Ep2DataElement(TagName = "TrmRMCap", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = true,
            MaxLength = 1)]
        public byte[] TrmRMCap { get; set; }

        /*Terminal Trx Functions Capability */

        [Ep2DataElement(TagName = "TrmTrxFctCap", TagPrefix = "ep2", DataType = Ep2DataType.b, IsMandatory = true,
            MaxLength = 2)]
        public virtual byte[] TrmTrxFctCap { get; set; }

        /*Terminal Type */

        [Ep2DataElement(TagName = "TrmType", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 2)]
        public int TrmType { get; set; }

        /*Timeout Acq Init Srv Comm */

        [Ep2DataElement(TagName = "TOInitSrv", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TOInitSrv { get; set; }

        /*Timeout Auth Srv Comm */

        [Ep2DataElement(TagName = "TOAuthSrv", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TOAuthSrv { get; set; }

        /*Timeout Card Insertion */

        [Ep2DataElement(TagName = "TOCardIn", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TOCardIn { get; set; }

        /*Timeout Card Remove */

        [Ep2DataElement(TagName = "TOCardRem", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TOCardRem { get; set; }

        /*Timeout Confirmation Trx Amount */

        [Ep2DataElement(TagName = "TOConfTrx", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TOConfTrx { get; set; }

        /*Timeout Data Entry */

        [Ep2DataElement(TagName = "TODatEntry", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TODatEntry { get; set; }

        /*Timeout Fallback */

        [Ep2DataElement(TagName = "TOFB", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true, MaxLength = 4
            )]
        public int TOFB { get; set; }

        /*Timeout ICC Command */

        [Ep2DataElement(TagName = "TOICC", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TOICC { get; set; }

        /*Timeout PMS Communication */

        [Ep2DataElement(TagName = "TOPMS", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TOPMS { get; set; }

        /*Timeout POS Trx Req */

        [Ep2DataElement(TagName = "TOPosTrxRq", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TOPosTrxRq { get; set; }

        /*Timeout Reminder */

        [Ep2DataElement(TagName = "TORmdr", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 2)]
        public int TORmdr { get; set; }

        /*Timeout Service Center Config Srv Req */

        [Ep2DataElement(TagName = "TOSCReq", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TOSCReq { get; set; }

        /*Timeout Transmission Trx Amount */

        [Ep2DataElement(TagName = "TOTrxTrans", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TOTrxTrans { get; set; }

        /*Transaction Limit for Transmission */

        [Ep2DataElement(TagName = "TrxTransLim", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 8)]
        public int TrxTransLim { get; set; }

        /*Transmission Interval */

        [Ep2DataElement(TagName = "TransInt", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 6)]
        public int? TransInt { get; set; }

        /*User Entry Retry Count */

        [Ep2DataElement(TagName = "UsrRetryCnt", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 2)]
        public int UsrRetryCnt { get; set; }

        /*Version No of Trm SW */

        [Ep2DataElement(TagName = "VersSW", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 8)]
        public int VersSW { get; set; }

        /*Timeout Acq Data Sub Srv Comm
Timeout Acq Data Sub Srv Comm */

        [Ep2DataElement(TagName = "TODataSubSrv", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 4)]
        public int TODataSubSrv { get; set; }

        /*Transaction Limit for Submission */

        [Ep2DataElement(TagName = "TrxSubmLim", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 8)]
        public int TrxSubmLim { get; set; }

        /*Merchant Password (proprietär) */

        [Ep2DataElement(TagName = "MerchantPwd", TagPrefix = "", DataType = Ep2DataType.n, IsMandatory = true,
            MaxLength = 8)]
        public string MerchantPwd { get; set; }

        /*Belegkopf Linie 1 */

        [Ep2DataElement(TagName = "Line1", TagPrefix = "", DataType = Ep2DataType.ans, IsMandatory = false,
            MaxLength = 48)]
        public string Line1 { get; set; }

        /*Belegkopf Linie 2 */

        [Ep2DataElement(TagName = "Line2", TagPrefix = "", DataType = Ep2DataType.ans, IsMandatory = false,
            MaxLength = 48)]
        public string Line2 { get; set; }

        /*Belegkopf Linie 3 */

        [Ep2DataElement(TagName = "Line3", TagPrefix = "", DataType = Ep2DataType.ans, IsMandatory = false,
            MaxLength = 48)]
        public string Line3 { get; set; }

        /*LTBU Indicator */

        [Ep2DataElement(TagName = "LTBUInd", TagPrefix = "", DataType = Ep2DataType.n, IsMandatory = false,
            MaxLength = 1)]
        public bool? LTBUInd { get; set; }

        /*DCC-Indikator */

        [Ep2DataElement(TagName = "DCCInd", TagPrefix = "ep2", DataType = Ep2DataType.n, IsMandatory = false,
            MaxLength = 1)]
        public bool DCCInd { get; set; }

        [Ep2DataElement(TagName = "DCCInd", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public bool DCCIndTkc { get; set; }

        /*Final Balance Interval */

        [Ep2DataElement(TagName = "FinBalInt", TagPrefix = "", DataType = Ep2DataType.n, IsMandatory = false,
            MaxLength = 4)]
        public int? FinBalInt { get; set; }

        /*Auto Final Balance Time */

        [Ep2DataElement(TagName = "AutoFinBalTime", TagPrefix = "", DataType = Ep2DataType.time, IsMandatory = false,
            MaxLength = 6)]
        public DateTime? AutoFinBalTime { get; set; }

        /*Terminal Event Log Data Transmission Trigger */

        [Ep2DataElement(TagName = "TELDTransTrigg", TagPrefix = "", DataType = Ep2DataType.n, IsMandatory = false,
            MaxLength = 8)]
        public int TELDTransTrigg { get; set; }

        /*Terminal Trace Flag */

        [Ep2DataElement(TagName = "TerminalTrace", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 4)]
        public int? TerminalTrace { get; set; }

        /*Terminal Trace Url */

        [Ep2DataElement(TagName = "TraceUrl", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.ans,
            IsMandatory = false, MaxLength = 128)]
        public string TraceUrl { get; set; }

        /*Neue Brandnamen für VEZ */

        [Ep2DataElement(TagName = "BrandMannerNew", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 4)]
        public int? BrandMannerNew { get; set; }

        /*ECR */

        [Ep2DataElement(TagName = "ECRInterfaceType", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = true, MaxLength = 3)]
        public int ECRInterfaceType { get; set; }

        /*Communication Addr MPD */

        [Ep2DataElement(TagName = "CommAddrMPD", TagPrefix = CustomPrefixes.Six, IsMandatory = true)]
        public CommAddrIp CommAddrMPD { get; set; }

        /*Communication Addr MPD Backup */

        [Ep2DataElement(TagName = "CommAddrMPDBackup", TagPrefix = CustomPrefixes.Six, IsMandatory = true)]
        public CommAddrIp CommAddrMPDBackup { get; set; }

        /*IFSF Site Controller */

        [Ep2DataElement(TagName = "IFSFSiteCntr", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public int? IFSFSiteCntr { get; set; }

        /*Record Public Transportation */

        [Ep2DataElement(TagName = "RPTActivationFlag", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.an,
            IsMandatory = false, MaxLength = 1)]
        public string RPTActivationFlag { get; set; }

        /*Display mode (1 = split display on BATS ) */

        [Ep2DataElement(TagName = "DispMode", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public bool? DispMode { get; set; }

        /*Terminal Type Cashload (1 = Cashload aktiv, pure Cashterminal) */

        [Ep2DataElement(TagName = "TrmTypCashLoadInd", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public bool? TrmTypCashLoadInd { get; set; }

        /*For steering of pay@table */

        [Ep2DataElement(TagName = "PayAtTableInd", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 1)]
        public int? PayAtTableInd { get; set; }

        /*Sleep Mode on/off */

        [Ep2DataElement(TagName = "TrmSleepTimer", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            IsMandatory = false, MaxLength = 3)]
        public int? TrmSleepTimer { get; set; }

        /*Terminal prints bill */

        [Ep2DataElement(TagName = "PinpadPrintOnTerminal", TagPrefix = CustomPrefixes.Six,
            DataType = Ep2DataType.n, IsMandatory = false, MaxLength = 1)]
        public int? PinpadPrintOnTerminal { get; set; }

        //mcx specific. used for communication order retry mechanism
        [Ep2DataElement(TagName = "CommDevOrder", TagPrefix = CustomPrefixes.Six, DataType = Ep2DataType.n,
            MaxLength = 4, IsMandatory = false)]
        public string CommDevOrder { get; set; }

        [Ep2DataElement(TagName = "VMService", TagPrefix = CustomPrefixes.Six)]
        public VMService VMService { get; set; }

        [Ep2DataElement(TagName = "NFCLoyaltyService", TagPrefix = CustomPrefixes.Six)]
        public AIDBasedService NFCLoyaltyService { get; set; }

        [Ep2DataElement(TagName = "VEKAService", TagPrefix = CustomPrefixes.Six)]
        public AIDBasedService VekaService { get; set; }

        [Ep2DataElement(TagName = "TaxFreeService", TagPrefix = CustomPrefixes.Six)]
        public TFSService TFSService { get; set; }

        public abstract void Accept(IConfigNotificationVisitor visitor);
    }
}