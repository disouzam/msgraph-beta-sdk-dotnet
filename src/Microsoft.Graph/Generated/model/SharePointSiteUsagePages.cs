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
    /// The type Share Point Site Usage Pages.
    /// </summary>
    public partial class SharePointSiteUsagePages : Entity
    {
    
        /// <summary>
        /// Gets or sets page view count.
        /// </summary>
        [JsonPropertyName("pageViewCount")]
        public Int64? PageViewCount { get; set; }
    
        /// <summary>
        /// Gets or sets report date.
        /// </summary>
        [JsonPropertyName("reportDate")]
        public Date ReportDate { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// </summary>
        [JsonPropertyName("reportPeriod")]
        public string ReportPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonPropertyName("reportRefreshDate")]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets site type.
        /// </summary>
        [JsonPropertyName("siteType")]
        public string SiteType { get; set; }
    
    }
}

