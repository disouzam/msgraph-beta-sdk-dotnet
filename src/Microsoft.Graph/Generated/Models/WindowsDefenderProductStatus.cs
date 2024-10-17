// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Product Status of Windows Defender</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    [Flags]
    public enum WindowsDefenderProductStatus
    {
        /// <summary>No status</summary>
        [EnumMember(Value = "noStatus")]
        NoStatus = 1,
        /// <summary>Service not running</summary>
        [EnumMember(Value = "serviceNotRunning")]
        ServiceNotRunning = 2,
        /// <summary>Service started without any malware protection engine</summary>
        [EnumMember(Value = "serviceStartedWithoutMalwareProtection")]
        ServiceStartedWithoutMalwareProtection = 4,
        /// <summary>Pending full scan due to threat action</summary>
        [EnumMember(Value = "pendingFullScanDueToThreatAction")]
        PendingFullScanDueToThreatAction = 8,
        /// <summary>Pending reboot due to threat action</summary>
        [EnumMember(Value = "pendingRebootDueToThreatAction")]
        PendingRebootDueToThreatAction = 16,
        /// <summary>Pending manual steps due to threat action </summary>
        [EnumMember(Value = "pendingManualStepsDueToThreatAction")]
        PendingManualStepsDueToThreatAction = 32,
        /// <summary>AV signatures out of date</summary>
        [EnumMember(Value = "avSignaturesOutOfDate")]
        AvSignaturesOutOfDate = 64,
        /// <summary>AS signatures out of date</summary>
        [EnumMember(Value = "asSignaturesOutOfDate")]
        AsSignaturesOutOfDate = 128,
        /// <summary>No quick scan has happened for a specified period</summary>
        [EnumMember(Value = "noQuickScanHappenedForSpecifiedPeriod")]
        NoQuickScanHappenedForSpecifiedPeriod = 256,
        /// <summary>No full scan has happened for a specified period</summary>
        [EnumMember(Value = "noFullScanHappenedForSpecifiedPeriod")]
        NoFullScanHappenedForSpecifiedPeriod = 512,
        /// <summary>System initiated scan in progress</summary>
        [EnumMember(Value = "systemInitiatedScanInProgress")]
        SystemInitiatedScanInProgress = 1024,
        /// <summary>System initiated clean in progress</summary>
        [EnumMember(Value = "systemInitiatedCleanInProgress")]
        SystemInitiatedCleanInProgress = 2048,
        /// <summary>There are samples pending submission</summary>
        [EnumMember(Value = "samplesPendingSubmission")]
        SamplesPendingSubmission = 4096,
        /// <summary>Product running in evaluation mode</summary>
        [EnumMember(Value = "productRunningInEvaluationMode")]
        ProductRunningInEvaluationMode = 8192,
        /// <summary>Product running in non-genuine Windows mode</summary>
        [EnumMember(Value = "productRunningInNonGenuineMode")]
        ProductRunningInNonGenuineMode = 16384,
        /// <summary>Product expired</summary>
        [EnumMember(Value = "productExpired")]
        ProductExpired = 32768,
        /// <summary>Off-line scan required</summary>
        [EnumMember(Value = "offlineScanRequired")]
        OfflineScanRequired = 65536,
        /// <summary>Service is shutting down as part of system shutdown</summary>
        [EnumMember(Value = "serviceShutdownAsPartOfSystemShutdown")]
        ServiceShutdownAsPartOfSystemShutdown = 131072,
        /// <summary>Threat remediation failed critically</summary>
        [EnumMember(Value = "threatRemediationFailedCritically")]
        ThreatRemediationFailedCritically = 262144,
        /// <summary>Threat remediation failed non-critically</summary>
        [EnumMember(Value = "threatRemediationFailedNonCritically")]
        ThreatRemediationFailedNonCritically = 524288,
        /// <summary>No status flags set (well initialized state)</summary>
        [EnumMember(Value = "noStatusFlagsSet")]
        NoStatusFlagsSet = 1048576,
        /// <summary>Platform is out of date</summary>
        [EnumMember(Value = "platformOutOfDate")]
        PlatformOutOfDate = 2097152,
        /// <summary>Platform update is in progress</summary>
        [EnumMember(Value = "platformUpdateInProgress")]
        PlatformUpdateInProgress = 4194304,
        /// <summary>Platform is about to be outdated</summary>
        [EnumMember(Value = "platformAboutToBeOutdated")]
        PlatformAboutToBeOutdated = 8388608,
        /// <summary>Signature or platform end of life is past or is impending</summary>
        [EnumMember(Value = "signatureOrPlatformEndOfLifeIsPastOrIsImpending")]
        SignatureOrPlatformEndOfLifeIsPastOrIsImpending = 16777216,
        /// <summary>Windows SMode signatures still in use on non-Win10S install</summary>
        [EnumMember(Value = "windowsSModeSignaturesInUseOnNonWin10SInstall")]
        WindowsSModeSignaturesInUseOnNonWin10SInstall = 33554432,
    }
}
