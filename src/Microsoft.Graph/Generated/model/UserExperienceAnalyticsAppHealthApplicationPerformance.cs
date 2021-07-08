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
    /// The type User Experience Analytics App Health Application Performance.
    /// </summary>
    public partial class UserExperienceAnalyticsAppHealthApplicationPerformance : Entity
    {
    
        /// <summary>
        /// Gets or sets active device count.
        /// The number of devices where the app has been active. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("activeDeviceCount")]
        public Int32? ActiveDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets app crash count.
        /// The number of crashes for the app. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("appCrashCount")]
        public Int32? AppCrashCount { get; set; }
    
        /// <summary>
        /// Gets or sets app display name.
        /// The friendly name of the application.
        /// </summary>
        [JsonPropertyName("appDisplayName")]
        public string AppDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets app hang count.
        /// The number of hangs for the app. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("appHangCount")]
        public Int32? AppHangCount { get; set; }
    
        /// <summary>
        /// Gets or sets app health score.
        /// The health score of the app. Valid values -1.79769313486232E+308 to 1.79769313486232E+308
        /// </summary>
        [JsonPropertyName("appHealthScore")]
        public double? AppHealthScore { get; set; }
    
        /// <summary>
        /// Gets or sets app health status.
        /// The overall health status of the app.
        /// </summary>
        [JsonPropertyName("appHealthStatus")]
        public string AppHealthStatus { get; set; }
    
        /// <summary>
        /// Gets or sets app name.
        /// The name of the application.
        /// </summary>
        [JsonPropertyName("appName")]
        public string AppName { get; set; }
    
        /// <summary>
        /// Gets or sets app publisher.
        /// The publisher of the application.
        /// </summary>
        [JsonPropertyName("appPublisher")]
        public string AppPublisher { get; set; }
    
        /// <summary>
        /// Gets or sets app usage duration.
        /// The total usage time of the application in minutes. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("appUsageDuration")]
        public Int32? AppUsageDuration { get; set; }
    
        /// <summary>
        /// Gets or sets mean time to failure in minutes.
        /// The mean time to failure for the app in minutes. Valid values -2147483648 to 2147483647
        /// </summary>
        [JsonPropertyName("meanTimeToFailureInMinutes")]
        public Int32? MeanTimeToFailureInMinutes { get; set; }
    
    }
}

