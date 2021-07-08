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
    /// The type SynchronizationSchedule.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SynchronizationSchedule>))]
    public partial class SynchronizationSchedule
    {

        /// <summary>
        /// Gets or sets expiration.
        /// Date and time when this job will expire. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("expiration")]
        public DateTimeOffset? Expiration { get; set; }
    
        /// <summary>
        /// Gets or sets interval.
        /// The interval between synchronization iterations.
        /// </summary>
        [JsonPropertyName("interval")]
        public Duration Interval { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Possible values are: Active, Disabled.
        /// </summary>
        [JsonPropertyName("state")]
        public SynchronizationScheduleState? State { get; set; }
    
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
