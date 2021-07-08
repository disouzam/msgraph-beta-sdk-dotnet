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
    /// The type OptionalClaim.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OptionalClaim>))]
    public partial class OptionalClaim
    {

        /// <summary>
        /// Gets or sets additionalProperties.
        /// Additional properties of the claim. If a property exists in this collection, it modifies the behavior of the optional claim specified in the name property.
        /// </summary>
        [JsonPropertyName("additionalProperties")]
        public IEnumerable<string> AdditionalProperties { get; set; }
    
        /// <summary>
        /// Gets or sets essential.
        /// If the value is true, the claim specified by the client is necessary to ensure a smooth authorization experience for the specific task requested by the end user. The default value is false.
        /// </summary>
        [JsonPropertyName("essential")]
        public bool? Essential { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The name of the optional claim.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// The source (directory object) of the claim. There are predefined claims and user-defined claims from extension properties. If the source value is null, the claim is a predefined optional claim. If the source value is user, the value in the name property is the extension property from the user object.
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
    
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
