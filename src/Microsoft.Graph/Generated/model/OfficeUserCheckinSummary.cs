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
    /// The type OfficeUserCheckinSummary.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OfficeUserCheckinSummary>))]
    public partial class OfficeUserCheckinSummary
    {

        /// <summary>
        /// Gets or sets failedUserCount.
        /// Total failed user check ins for the last 3 months.
        /// </summary>
        [JsonPropertyName("failedUserCount")]
        public Int32? FailedUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets succeededUserCount.
        /// Total successful user check ins for the last 3 months.
        /// </summary>
        [JsonPropertyName("succeededUserCount")]
        public Int32? SucceededUserCount { get; set; }
    
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
