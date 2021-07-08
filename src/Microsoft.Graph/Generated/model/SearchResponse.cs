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
    /// The type SearchResponse.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SearchResponse>))]
    public partial class SearchResponse
    {

        /// <summary>
        /// Gets or sets queryAlterationResponse.
        /// Provides details of query alteration response for spelling correction.
        /// </summary>
        [JsonPropertyName("queryAlterationResponse")]
        public AlterationResponse QueryAlterationResponse { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// Represents results from a search query, and the terms used for the query.
        /// </summary>
        [JsonPropertyName("value")]
        public IEnumerable<SearchResultSet> Value { get; set; }
    
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
