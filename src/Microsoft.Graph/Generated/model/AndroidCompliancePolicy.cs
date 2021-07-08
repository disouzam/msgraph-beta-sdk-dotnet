// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Android Compliance Policy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AndroidCompliancePolicy>))]
    public partial class AndroidCompliancePolicy : DeviceCompliancePolicy
    {
    
        ///<summary>
        /// The AndroidCompliancePolicy constructor
        ///</summary>
        public AndroidCompliancePolicy()
        {
            this.ODataType = "microsoft.graph.androidCompliancePolicy";
        }

        /// <summary>
        /// Gets or sets advanced threat protection required security level.
        /// MDATP Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.
        /// </summary>
        [JsonPropertyName("advancedThreatProtectionRequiredSecurityLevel")]
        public DeviceThreatProtectionLevel? AdvancedThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets condition statement id.
        /// Condition statement id.
        /// </summary>
        [JsonPropertyName("conditionStatementId")]
        public string ConditionStatementId { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection enabled.
        /// Require that devices have enabled device threat protection.
        /// </summary>
        [JsonPropertyName("deviceThreatProtectionEnabled")]
        public bool? DeviceThreatProtectionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets device threat protection required security level.
        /// Require Mobile Threat Protection minimum risk level to report noncompliance. Possible values are: unavailable, secured, low, medium, high, notSet.
        /// </summary>
        [JsonPropertyName("deviceThreatProtectionRequiredSecurityLevel")]
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets min android security patch level.
        /// Minimum Android security patch level.
        /// </summary>
        [JsonPropertyName("minAndroidSecurityPatchLevel")]
        public string MinAndroidSecurityPatchLevel { get; set; }
    
        /// <summary>
        /// Gets or sets os maximum version.
        /// Maximum Android version.
        /// </summary>
        [JsonPropertyName("osMaximumVersion")]
        public string OsMaximumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets os minimum version.
        /// Minimum Android version.
        /// </summary>
        [JsonPropertyName("osMinimumVersion")]
        public string OsMinimumVersion { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Number of days before the password expires. Valid values 1 to 365
        /// </summary>
        [JsonPropertyName("passwordExpirationDays")]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// Minimum password length. Valid values 4 to 16
        /// </summary>
        [JsonPropertyName("passwordMinimumLength")]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before lock.
        /// Minutes of inactivity before a password is required.
        /// </summary>
        [JsonPropertyName("passwordMinutesOfInactivityBeforeLock")]
        public Int32? PasswordMinutesOfInactivityBeforeLock { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// Number of previous passwords to block. Valid values 1 to 24
        /// </summary>
        [JsonPropertyName("passwordPreviousPasswordBlockCount")]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required.
        /// Require a password to unlock device.
        /// </summary>
        [JsonPropertyName("passwordRequired")]
        public bool? PasswordRequired { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// Type of characters in password. Possible values are: deviceDefault, alphabetic, alphanumeric, alphanumericWithSymbols, lowSecurityBiometric, numeric, numericComplex, any.
        /// </summary>
        [JsonPropertyName("passwordRequiredType")]
        public AndroidRequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password sign in failure count before factory reset.
        /// Number of sign-in failures allowed before factory reset. Valid values 1 to 16
        /// </summary>
        [JsonPropertyName("passwordSignInFailureCountBeforeFactoryReset")]
        public Int32? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
    
        /// <summary>
        /// Gets or sets required password complexity.
        /// Indicates the required password complexity on Android. One of: NONE, LOW, MEDIUM, HIGH. This is a new API targeted to Android 11+. Possible values are: none, low, medium, high.
        /// </summary>
        [JsonPropertyName("requiredPasswordComplexity")]
        public AndroidRequiredPasswordComplexity? RequiredPasswordComplexity { get; set; }
    
        /// <summary>
        /// Gets or sets restricted apps.
        /// Require the device to not have the specified apps installed. This collection can contain a maximum of 100 elements.
        /// </summary>
        [JsonPropertyName("restrictedApps")]
        public IEnumerable<AppListItem> RestrictedApps { get; set; }
    
        /// <summary>
        /// Gets or sets security block device administrator managed devices.
        /// Block device administrator managed devices.
        /// </summary>
        [JsonPropertyName("securityBlockDeviceAdministratorManagedDevices")]
        public bool? SecurityBlockDeviceAdministratorManagedDevices { get; set; }
    
        /// <summary>
        /// Gets or sets security block jailbroken devices.
        /// Devices must not be jailbroken or rooted.
        /// </summary>
        [JsonPropertyName("securityBlockJailbrokenDevices")]
        public bool? SecurityBlockJailbrokenDevices { get; set; }
    
        /// <summary>
        /// Gets or sets security disable usb debugging.
        /// Disable USB debugging on Android devices.
        /// </summary>
        [JsonPropertyName("securityDisableUsbDebugging")]
        public bool? SecurityDisableUsbDebugging { get; set; }
    
        /// <summary>
        /// Gets or sets security prevent install apps from unknown sources.
        /// Require that devices disallow installation of apps from unknown sources.
        /// </summary>
        [JsonPropertyName("securityPreventInstallAppsFromUnknownSources")]
        public bool? SecurityPreventInstallAppsFromUnknownSources { get; set; }
    
        /// <summary>
        /// Gets or sets security require company portal app integrity.
        /// Require the device to pass the Company Portal client app runtime integrity check.
        /// </summary>
        [JsonPropertyName("securityRequireCompanyPortalAppIntegrity")]
        public bool? SecurityRequireCompanyPortalAppIntegrity { get; set; }
    
        /// <summary>
        /// Gets or sets security require google play services.
        /// Require Google Play Services to be installed and enabled on the device.
        /// </summary>
        [JsonPropertyName("securityRequireGooglePlayServices")]
        public bool? SecurityRequireGooglePlayServices { get; set; }
    
        /// <summary>
        /// Gets or sets security require safety net attestation basic integrity.
        /// Require the device to pass the SafetyNet basic integrity check.
        /// </summary>
        [JsonPropertyName("securityRequireSafetyNetAttestationBasicIntegrity")]
        public bool? SecurityRequireSafetyNetAttestationBasicIntegrity { get; set; }
    
        /// <summary>
        /// Gets or sets security require safety net attestation certified device.
        /// Require the device to pass the SafetyNet certified device check.
        /// </summary>
        [JsonPropertyName("securityRequireSafetyNetAttestationCertifiedDevice")]
        public bool? SecurityRequireSafetyNetAttestationCertifiedDevice { get; set; }
    
        /// <summary>
        /// Gets or sets security require up to date security providers.
        /// Require the device to have up to date security providers. The device will require Google Play Services to be enabled and up to date.
        /// </summary>
        [JsonPropertyName("securityRequireUpToDateSecurityProviders")]
        public bool? SecurityRequireUpToDateSecurityProviders { get; set; }
    
        /// <summary>
        /// Gets or sets security require verify apps.
        /// Require the Android Verify apps feature is turned on.
        /// </summary>
        [JsonPropertyName("securityRequireVerifyApps")]
        public bool? SecurityRequireVerifyApps { get; set; }
    
        /// <summary>
        /// Gets or sets storage require encryption.
        /// Require encryption on Android devices.
        /// </summary>
        [JsonPropertyName("storageRequireEncryption")]
        public bool? StorageRequireEncryption { get; set; }
    
    }
}

