// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public enum CloudPcOnPremisesConnectionHealthCheckErrorType
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "dnsCheckFqdnNotFound")]
        #pragma warning disable CS1591
        DnsCheckFqdnNotFound,
        #pragma warning restore CS1591
        [EnumMember(Value = "dnsCheckNameWithInvalidCharacter")]
        #pragma warning disable CS1591
        DnsCheckNameWithInvalidCharacter,
        #pragma warning restore CS1591
        [EnumMember(Value = "dnsCheckUnknownError")]
        #pragma warning disable CS1591
        DnsCheckUnknownError,
        #pragma warning restore CS1591
        [EnumMember(Value = "adJoinCheckFqdnNotFound")]
        #pragma warning disable CS1591
        AdJoinCheckFqdnNotFound,
        #pragma warning restore CS1591
        [EnumMember(Value = "adJoinCheckIncorrectCredentials")]
        #pragma warning disable CS1591
        AdJoinCheckIncorrectCredentials,
        #pragma warning restore CS1591
        [EnumMember(Value = "adJoinCheckOrganizationalUnitNotFound")]
        #pragma warning disable CS1591
        AdJoinCheckOrganizationalUnitNotFound,
        #pragma warning restore CS1591
        [EnumMember(Value = "adJoinCheckOrganizationalUnitIncorrectFormat")]
        #pragma warning disable CS1591
        AdJoinCheckOrganizationalUnitIncorrectFormat,
        #pragma warning restore CS1591
        [EnumMember(Value = "adJoinCheckComputerObjectAlreadyExists")]
        #pragma warning disable CS1591
        AdJoinCheckComputerObjectAlreadyExists,
        #pragma warning restore CS1591
        [EnumMember(Value = "adJoinCheckAccessDenied")]
        #pragma warning disable CS1591
        AdJoinCheckAccessDenied,
        #pragma warning restore CS1591
        [EnumMember(Value = "adJoinCheckCredentialsExpired")]
        #pragma warning disable CS1591
        AdJoinCheckCredentialsExpired,
        #pragma warning restore CS1591
        [EnumMember(Value = "adJoinCheckAccountLockedOrDisabled")]
        #pragma warning disable CS1591
        AdJoinCheckAccountLockedOrDisabled,
        #pragma warning restore CS1591
        [EnumMember(Value = "adJoinCheckAccountQuotaExceeded")]
        #pragma warning disable CS1591
        AdJoinCheckAccountQuotaExceeded,
        #pragma warning restore CS1591
        [EnumMember(Value = "adJoinCheckServerNotOperational")]
        #pragma warning disable CS1591
        AdJoinCheckServerNotOperational,
        #pragma warning restore CS1591
        [EnumMember(Value = "adJoinCheckUnknownError")]
        #pragma warning disable CS1591
        AdJoinCheckUnknownError,
        #pragma warning restore CS1591
        [EnumMember(Value = "endpointConnectivityCheckCloudPcUrlNotAllowListed")]
        #pragma warning disable CS1591
        EndpointConnectivityCheckCloudPcUrlNotAllowListed,
        #pragma warning restore CS1591
        [EnumMember(Value = "endpointConnectivityCheckWVDUrlNotAllowListed")]
        #pragma warning disable CS1591
        EndpointConnectivityCheckWVDUrlNotAllowListed,
        #pragma warning restore CS1591
        [EnumMember(Value = "endpointConnectivityCheckIntuneUrlNotAllowListed")]
        #pragma warning disable CS1591
        EndpointConnectivityCheckIntuneUrlNotAllowListed,
        #pragma warning restore CS1591
        [EnumMember(Value = "endpointConnectivityCheckAzureADUrlNotAllowListed")]
        #pragma warning disable CS1591
        EndpointConnectivityCheckAzureADUrlNotAllowListed,
        #pragma warning restore CS1591
        [EnumMember(Value = "endpointConnectivityCheckLocaleUrlNotAllowListed")]
        #pragma warning disable CS1591
        EndpointConnectivityCheckLocaleUrlNotAllowListed,
        #pragma warning restore CS1591
        [EnumMember(Value = "endpointConnectivityCheckUnknownError")]
        #pragma warning disable CS1591
        EndpointConnectivityCheckUnknownError,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureAdDeviceSyncCheckDeviceNotFound")]
        #pragma warning disable CS1591
        AzureAdDeviceSyncCheckDeviceNotFound,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureAdDeviceSyncCheckLongSyncCircle")]
        #pragma warning disable CS1591
        AzureAdDeviceSyncCheckLongSyncCircle,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureAdDeviceSyncCheckConnectDisabled")]
        #pragma warning disable CS1591
        AzureAdDeviceSyncCheckConnectDisabled,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureAdDeviceSyncCheckDurationExceeded")]
        #pragma warning disable CS1591
        AzureAdDeviceSyncCheckDurationExceeded,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureAdDeviceSyncCheckScpNotConfigured")]
        #pragma warning disable CS1591
        AzureAdDeviceSyncCheckScpNotConfigured,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureAdDeviceSyncCheckTransientServiceError")]
        #pragma warning disable CS1591
        AzureAdDeviceSyncCheckTransientServiceError,
        #pragma warning restore CS1591
        [EnumMember(Value = "azureAdDeviceSyncCheckUnknownError")]
        #pragma warning disable CS1591
        AzureAdDeviceSyncCheckUnknownError,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckNoSubnetIP")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckNoSubnetIP,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckSubscriptionDisabled")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckSubscriptionDisabled,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckAzurePolicyViolation")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckAzurePolicyViolation,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckSubscriptionNotFound")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckSubscriptionNotFound,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckSubscriptionTransferred")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckSubscriptionTransferred,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckGeneralSubscriptionError")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckGeneralSubscriptionError,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckUnsupportedVNetRegion")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckUnsupportedVNetRegion,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckResourceGroupInvalid")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckResourceGroupInvalid,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckVNetInvalid")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckVNetInvalid,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckSubnetInvalid")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckSubnetInvalid,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckResourceGroupBeingDeleted")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckResourceGroupBeingDeleted,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckVNetBeingMoved")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckVNetBeingMoved,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckSubnetDelegationFailed")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckSubnetDelegationFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckSubnetWithExternalResources")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckSubnetWithExternalResources,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckResourceGroupLockedForReadonly")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckResourceGroupLockedForReadonly,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckResourceGroupLockedForDelete")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckResourceGroupLockedForDelete,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckNoIntuneReaderRoleError")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckNoIntuneReaderRoleError,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckIntuneDefaultWindowsRestrictionViolation")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckIntuneDefaultWindowsRestrictionViolation,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckIntuneCustomWindowsRestrictionViolation")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckIntuneCustomWindowsRestrictionViolation,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckDeploymentQuotaLimitReached")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckDeploymentQuotaLimitReached,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckTransientServiceError")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckTransientServiceError,
        #pragma warning restore CS1591
        [EnumMember(Value = "resourceAvailabilityCheckUnknownError")]
        #pragma warning disable CS1591
        ResourceAvailabilityCheckUnknownError,
        #pragma warning restore CS1591
        [EnumMember(Value = "permissionCheckNoSubscriptionReaderRole")]
        #pragma warning disable CS1591
        PermissionCheckNoSubscriptionReaderRole,
        #pragma warning restore CS1591
        [EnumMember(Value = "permissionCheckNoResourceGroupOwnerRole")]
        #pragma warning disable CS1591
        PermissionCheckNoResourceGroupOwnerRole,
        #pragma warning restore CS1591
        [EnumMember(Value = "permissionCheckNoVNetContributorRole")]
        #pragma warning disable CS1591
        PermissionCheckNoVNetContributorRole,
        #pragma warning restore CS1591
        [EnumMember(Value = "permissionCheckNoResourceGroupNetworkContributorRole")]
        #pragma warning disable CS1591
        PermissionCheckNoResourceGroupNetworkContributorRole,
        #pragma warning restore CS1591
        [EnumMember(Value = "permissionCheckNoWindows365NetworkUserRole")]
        #pragma warning disable CS1591
        PermissionCheckNoWindows365NetworkUserRole,
        #pragma warning restore CS1591
        [EnumMember(Value = "permissionCheckNoWindows365NetworkInterfaceContributorRole")]
        #pragma warning disable CS1591
        PermissionCheckNoWindows365NetworkInterfaceContributorRole,
        #pragma warning restore CS1591
        [EnumMember(Value = "permissionCheckTransientServiceError")]
        #pragma warning disable CS1591
        PermissionCheckTransientServiceError,
        #pragma warning restore CS1591
        [EnumMember(Value = "permissionCheckUnknownError")]
        #pragma warning disable CS1591
        PermissionCheckUnknownError,
        #pragma warning restore CS1591
        [EnumMember(Value = "udpConnectivityCheckStunUrlNotAllowListed")]
        #pragma warning disable CS1591
        UdpConnectivityCheckStunUrlNotAllowListed,
        #pragma warning restore CS1591
        [EnumMember(Value = "udpConnectivityCheckTurnUrlNotAllowListed")]
        #pragma warning disable CS1591
        UdpConnectivityCheckTurnUrlNotAllowListed,
        #pragma warning restore CS1591
        [EnumMember(Value = "udpConnectivityCheckUrlsNotAllowListed")]
        #pragma warning disable CS1591
        UdpConnectivityCheckUrlsNotAllowListed,
        #pragma warning restore CS1591
        [EnumMember(Value = "udpConnectivityCheckUnknownError")]
        #pragma warning disable CS1591
        UdpConnectivityCheckUnknownError,
        #pragma warning restore CS1591
        [EnumMember(Value = "internalServerErrorDeploymentCanceled")]
        #pragma warning disable CS1591
        InternalServerErrorDeploymentCanceled,
        #pragma warning restore CS1591
        [EnumMember(Value = "internalServerErrorAllocateResourceFailed")]
        #pragma warning disable CS1591
        InternalServerErrorAllocateResourceFailed,
        #pragma warning restore CS1591
        [EnumMember(Value = "internalServerErrorVMDeploymentTimeout")]
        #pragma warning disable CS1591
        InternalServerErrorVMDeploymentTimeout,
        #pragma warning restore CS1591
        [EnumMember(Value = "internalServerErrorUnableToRunDscScript")]
        #pragma warning disable CS1591
        InternalServerErrorUnableToRunDscScript,
        #pragma warning restore CS1591
        [EnumMember(Value = "ssoCheckKerberosConfigurationError")]
        #pragma warning disable CS1591
        SsoCheckKerberosConfigurationError,
        #pragma warning restore CS1591
        [EnumMember(Value = "internalServerUnknownError")]
        #pragma warning disable CS1591
        InternalServerUnknownError,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue,
        #pragma warning restore CS1591
    }
}
