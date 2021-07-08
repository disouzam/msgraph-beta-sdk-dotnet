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
    /// The type Dep Onboarding Setting.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DepOnboardingSetting>))]
    public partial class DepOnboardingSetting : Entity
    {
    
        /// <summary>
        /// Gets or sets apple identifier.
        /// The Apple ID used to obtain the current token.
        /// </summary>
        [JsonPropertyName("appleIdentifier")]
        public string AppleIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets data sharing consent granted.
        /// Consent granted for data sharing with Apple Dep Service
        /// </summary>
        [JsonPropertyName("dataSharingConsentGranted")]
        public bool? DataSharingConsentGranted { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// When the service was onboarded.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last successful sync date time.
        /// When the service last syned with Intune
        /// </summary>
        [JsonPropertyName("lastSuccessfulSyncDateTime")]
        public DateTimeOffset? LastSuccessfulSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last sync error code.
        /// Error code reported by Apple during last dep sync.
        /// </summary>
        [JsonPropertyName("lastSyncErrorCode")]
        public Int32? LastSyncErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets last sync triggered date time.
        /// When Intune last requested a sync.
        /// </summary>
        [JsonPropertyName("lastSyncTriggeredDateTime")]
        public DateTimeOffset? LastSyncTriggeredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonPropertyName("roleScopeTagIds")]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
        /// <summary>
        /// Gets or sets share token with school data sync service.
        /// Whether or not the Dep token sharing is enabled with the School Data Sync service.
        /// </summary>
        [JsonPropertyName("shareTokenWithSchoolDataSyncService")]
        public bool? ShareTokenWithSchoolDataSyncService { get; set; }
    
        /// <summary>
        /// Gets or sets synced device count.
        /// Gets synced device count
        /// </summary>
        [JsonPropertyName("syncedDeviceCount")]
        public Int32? SyncedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets token expiration date time.
        /// When the token will expire.
        /// </summary>
        [JsonPropertyName("tokenExpirationDateTime")]
        public DateTimeOffset? TokenExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets token name.
        /// Friendly Name for Dep Token
        /// </summary>
        [JsonPropertyName("tokenName")]
        public string TokenName { get; set; }
    
        /// <summary>
        /// Gets or sets token type.
        /// Gets or sets the Dep Token Type. Possible values are: none, dep, appleSchoolManager.
        /// </summary>
        [JsonPropertyName("tokenType")]
        public DepTokenType? TokenType { get; set; }
    
        /// <summary>
        /// Gets or sets default ios enrollment profile.
        /// Default iOS Enrollment Profile
        /// </summary>
        [JsonPropertyName("defaultIosEnrollmentProfile")]
        public DepIOSEnrollmentProfile DefaultIosEnrollmentProfile { get; set; }
    
        /// <summary>
        /// Gets or sets default mac os enrollment profile.
        /// Default MacOs Enrollment Profile
        /// </summary>
        [JsonPropertyName("defaultMacOsEnrollmentProfile")]
        public DepMacOSEnrollmentProfile DefaultMacOsEnrollmentProfile { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment profiles.
        /// The enrollment profiles.
        /// </summary>
        [JsonPropertyName("enrollmentProfiles")]
        public IDepOnboardingSettingEnrollmentProfilesCollectionPage EnrollmentProfiles { get; set; }

        /// <summary>
        /// Gets or sets enrollmentProfilesNextLink.
        /// </summary>
        [JsonPropertyName("enrollmentProfiles@odata.nextLink")]
        public string EnrollmentProfilesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets imported apple device identities.
        /// The imported Apple device identities.
        /// </summary>
        [JsonPropertyName("importedAppleDeviceIdentities")]
        public IDepOnboardingSettingImportedAppleDeviceIdentitiesCollectionPage ImportedAppleDeviceIdentities { get; set; }

        /// <summary>
        /// Gets or sets importedAppleDeviceIdentitiesNextLink.
        /// </summary>
        [JsonPropertyName("importedAppleDeviceIdentities@odata.nextLink")]
        public string ImportedAppleDeviceIdentitiesNextLink { get; set; }
    
    }
}

