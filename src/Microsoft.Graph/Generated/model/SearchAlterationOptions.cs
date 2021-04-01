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
    /// The type SearchAlterationOptions.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SearchAlterationOptions>))]
    public partial class SearchAlterationOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAlterationOptions"/> class.
        /// </summary>
        public SearchAlterationOptions()
        {
            this.ODataType = "microsoft.graph.searchAlterationOptions";
        }

        /// <summary>
        /// Gets or sets enableModification.
        /// </summary>
        [JsonPropertyName("enableModification")]
        public bool? EnableModification { get; set; }
    
        /// <summary>
        /// Gets or sets enableSuggestion.
        /// </summary>
        [JsonPropertyName("enableSuggestion")]
        public bool? EnableSuggestion { get; set; }
    
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
