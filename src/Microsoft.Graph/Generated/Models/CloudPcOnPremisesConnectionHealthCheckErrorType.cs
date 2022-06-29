namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public enum CloudPcOnPremisesConnectionHealthCheckErrorType {
        DnsCheckFqdnNotFound,
        DnsCheckNameWithInvalidCharacter,
        DnsCheckUnknownError,
        AdJoinCheckFqdnNotFound,
        AdJoinCheckIncorrectCredentials,
        AdJoinCheckOrganizationalUnitNotFound,
        AdJoinCheckOrganizationalUnitIncorrectFormat,
        AdJoinCheckComputerObjectAlreadyExists,
        AdJoinCheckAccessDenied,
        AdJoinCheckCredentialsExpired,
        AdJoinCheckAccountLockedOrDisabled,
        AdJoinCheckAccountQuotaExceeded,
        AdJoinCheckUnknownError,
        EndpointConnectivityCheckCloudPcUrlNotAllowListed,
        EndpointConnectivityCheckWVDUrlNotAllowListed,
        EndpointConnectivityCheckIntuneUrlNotAllowListed,
        EndpointConnectivityCheckUnknownError,
        AzureAdDeviceSyncCheckDeviceNotFound,
        AzureAdDeviceSyncCheckLongSyncCircle,
        AzureAdDeviceSyncCheckConnectDisabled,
        AzureAdDeviceSyncCheckDurationExceeded,
        AzureAdDeviceSyncCheckScpNotConfigured,
        AzureAdDeviceSyncCheckTransientServiceError,
        AzureAdDeviceSyncCheckUnknownError,
        ResourceAvailabilityCheckNoSubnetIP,
        ResourceAvailabilityCheckSubscriptionDisabled,
        ResourceAvailabilityCheckAzurePolicyViolation,
        ResourceAvailabilityCheckSubscriptionNotFound,
        ResourceAvailabilityCheckSubscriptionTransferred,
        ResourceAvailabilityCheckGeneralSubscriptionError,
        ResourceAvailabilityCheckUnsupportedVNetRegion,
        ResourceAvailabilityCheckResourceGroupInvalid,
        ResourceAvailabilityCheckVNetInvalid,
        ResourceAvailabilityCheckSubnetInvalid,
        ResourceAvailabilityCheckResourceGroupBeingDeleted,
        ResourceAvailabilityCheckVNetBeingMoved,
        ResourceAvailabilityCheckSubnetDelegationFailed,
        ResourceAvailabilityCheckSubnetWithExternalResources,
        ResourceAvailabilityCheckResourceGroupLockedForReadonly,
        ResourceAvailabilityCheckResourceGroupLockedForDelete,
        ResourceAvailabilityCheckTransientServiceError,
        ResourceAvailabilityCheckUnknownError,
        PermissionCheckNoSubscriptionReaderRole,
        PermissionCheckNoResourceGroupOwnerRole,
        PermissionCheckNoVNetContributorRole,
        PermissionCheckNoResourceGroupNetworkContributorRole,
        PermissionCheckTransientServiceError,
        PermissionCheckUnknownError,
        InternalServerErrorDeploymentCanceled,
        InternalServerErrorAllocateResourceFailed,
        InternalServerErrorVMDeploymentTimeout,
        InternalServerErrorUnableToRunDscScript,
        InternalServerUnknownError,
        UnknownFutureValue,
    }
}
