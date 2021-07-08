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
    /// The type User Experience Analytics Metric History.
    /// </summary>
    public partial class UserExperienceAnalyticsMetricHistory : Entity
    {
    
        /// <summary>
        /// Gets or sets device id.
        /// The user experience analytics device id.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets metric date time.
        /// The user experience analytics metric date time.
        /// </summary>
        [JsonPropertyName("metricDateTime")]
        public DateTimeOffset? MetricDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets metric type.
        /// The user experience analytics metric type.
        /// </summary>
        [JsonPropertyName("metricType")]
        public string MetricType { get; set; }
    
        /// <summary>
        /// Gets or sets user experience analytics metric.
        /// User experience analytics metric.
        /// </summary>
        [JsonPropertyName("userExperienceAnalyticsMetric")]
        public UserExperienceAnalyticsMetric UserExperienceAnalyticsMetric { get; set; }
    
    }
}

