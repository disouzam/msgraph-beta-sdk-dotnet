// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>A list of possible Azure Attestation states for a device. Azure Attestation setting status is determined by report sent from Microsoft Azure Attestation service. Only Windows 11 devices will have values &quot;enabled&quot; or &quot;disabled&quot;. Windows 10 devices will have value &quot;notApplicable&quot;.</summary>
    public enum AzureAttestationSettingStatus {
        /// <summary>Indicates that the device is not a Windows 11 device.</summary>
        [EnumMember(Value = "notApplicable")]
        NotApplicable,
        /// <summary>Indicates that the device has the Azure attestation setting enabled.</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
        /// <summary>Indicates that the device has the Azure attestation setting disabled.</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
