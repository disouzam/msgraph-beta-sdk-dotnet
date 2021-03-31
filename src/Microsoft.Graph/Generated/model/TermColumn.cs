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
    /// The type TermColumn.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TermColumn>))]
    public partial class TermColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TermColumn"/> class.
        /// </summary>
        public TermColumn()
        {
            this.ODataType = "microsoft.graph.termColumn";
        }

        /// <summary>
        /// Gets or sets allowMultipleValues.
        /// Specifies whether the column will allow more than one value
        /// </summary>
        [JsonPropertyName("allowMultipleValues")]
        public bool? AllowMultipleValues { get; set; }
    
        /// <summary>
        /// Gets or sets showFullyQualifiedName.
        /// Specifies whether to display the entire term path or only the term label.
        /// </summary>
        [JsonPropertyName("showFullyQualifiedName")]
        public bool? ShowFullyQualifiedName { get; set; }
    
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
