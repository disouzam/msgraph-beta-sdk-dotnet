// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An error code indicating the failure reason, when the deployment state is createFailed. Possible values: See zebraFotaErrorCode enum.</summary>
    public enum ZebraFotaErrorCode {
        /// <summary>Default error code indicating success (no error).</summary>
        [EnumMember(Value = "success")]
        Success,
        /// <summary>This error indicates that no devices were found in the selected Azure Active Directory (AAD) security group(s) when creating a deployment. E.g.: a user selects one or more security groups that doesn&apos;t include any devices</summary>
        [EnumMember(Value = "noDevicesFoundInSelectedAadGroups")]
        NoDevicesFoundInSelectedAadGroups,
        /// <summary>This error indicates that no Intune managed devices were found in the selected Azure Active Directory (AAD) security groups when creating a deployment. E.g.: a user selects a group that includes devices that are no longer managed in Intune.</summary>
        [EnumMember(Value = "noIntuneDevicesFoundInSelectedAadGroups")]
        NoIntuneDevicesFoundInSelectedAadGroups,
        /// <summary>This error indicates that no Zebra FOTA enrolled devices were found for the current tenant when creating a deployment. E.g.: a user has not enrolled any devices in Zebra FOTA and attempts to create a deployment targeting only non-Zebra devices.</summary>
        [EnumMember(Value = "noZebraFotaEnrolledDevicesFoundForCurrentTenant")]
        NoZebraFotaEnrolledDevicesFoundForCurrentTenant,
        /// <summary>This error indicates that no Zebra FOTA enrolled devices were found in the selected Azure Active Directory (AAD) Groups when creating a deployment. E.g.: a user has enrolled one or more devices in Zebra FOTA, but attempts to create a deployment targeting security groups that don&apos;t include any Zebra Devices.</summary>
        [EnumMember(Value = "noZebraFotaEnrolledDevicesFoundInSelectedAadGroups")]
        NoZebraFotaEnrolledDevicesFoundInSelectedAadGroups,
        /// <summary>This error indicates that no Zebra FOTA devices were found that match the selected device model when creating a deployment. E.g.: a user selects `TC8300` device model, but no Zebra devices with the same device model were found in the targeted Azure Active Directory (AAD) security groups.</summary>
        [EnumMember(Value = "noZebraFotaDevicesFoundForSelectedDeviceModel")]
        NoZebraFotaDevicesFoundForSelectedDeviceModel,
        /// <summary>This error indicates that an external request to Zebra APIs failed when creating a deployment. The failure can be caused by a transient issue (e.g.: Network is down) or caused by a permanent server error.</summary>
        [EnumMember(Value = "zebraFotaCreateDeploymentRequestFailure")]
        ZebraFotaCreateDeploymentRequestFailure,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
