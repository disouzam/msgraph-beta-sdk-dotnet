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
    /// The type Office Graph Insights.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OfficeGraphInsights>))]
    public partial class OfficeGraphInsights : Entity
    {
    
		///<summary>
		/// The OfficeGraphInsights constructor
		///</summary>
        public OfficeGraphInsights()
        {
            this.ODataType = "microsoft.graph.officeGraphInsights";
        }
	
        /// <summary>
        /// Gets or sets shared.
        /// Access this property from the derived type itemInsights.
        /// </summary>
        [JsonPropertyName("shared")]
        public IOfficeGraphInsightsSharedCollectionPage Shared { get; set; }

        /// <summary>
        /// Gets or sets sharedNextLink.
        /// </summary>
        [JsonPropertyName("shared@odata.nextLink")]
        public string SharedNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets trending.
        /// Access this property from the derived type itemInsights.
        /// </summary>
        [JsonPropertyName("trending")]
        public IOfficeGraphInsightsTrendingCollectionPage Trending { get; set; }

        /// <summary>
        /// Gets or sets trendingNextLink.
        /// </summary>
        [JsonPropertyName("trending@odata.nextLink")]
        public string TrendingNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets used.
        /// Access this property from the derived type itemInsights.
        /// </summary>
        [JsonPropertyName("used")]
        public IOfficeGraphInsightsUsedCollectionPage Used { get; set; }

        /// <summary>
        /// Gets or sets usedNextLink.
        /// </summary>
        [JsonPropertyName("used@odata.nextLink")]
        public string UsedNextLink { get; set; }
    
    }
}

