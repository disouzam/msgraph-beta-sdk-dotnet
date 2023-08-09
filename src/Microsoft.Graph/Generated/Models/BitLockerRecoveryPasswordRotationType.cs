// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>BitLocker recovery password rotation type</summary>
    public enum BitLockerRecoveryPasswordRotationType {
        /// <summary>Not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Recovery password rotation off</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Recovery password rotation on for Azure AD joined devices</summary>
        [EnumMember(Value = "enabledForAzureAd")]
        EnabledForAzureAd,
        /// <summary>Recovery password rotation on for both Azure AD joined and hybrid joined devices</summary>
        [EnumMember(Value = "enabledForAzureAdAndHybrid")]
        EnabledForAzureAdAndHybrid,
    }
}
