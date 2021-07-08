// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AdminConsent.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AdminConsent>))]
    public partial class AdminConsent
    {

        /// <summary>
        /// Gets or sets shareAPNSData.
        /// The admin consent state of sharing user and device data to Apple. Possible values are: notConfigured, granted, notGranted.
        /// </summary>
        [JsonPropertyName("shareAPNSData")]
        public AdminConsentState? ShareAPNSData { get; set; }
    
        /// <summary>
        /// Gets or sets shareUserExperienceAnalyticsData.
        /// Gets or sets the admin consent for sharing User experience analytics data. Possible values are: notConfigured, granted, notGranted.
        /// </summary>
        [JsonPropertyName("shareUserExperienceAnalyticsData")]
        public AdminConsentState? ShareUserExperienceAnalyticsData { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
