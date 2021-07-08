// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.WindowsUpdates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ExpeditedQualityUpdateReference.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ExpeditedQualityUpdateReference>))]
    public partial class ExpeditedQualityUpdateReference : QualityUpdateReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpeditedQualityUpdateReference"/> class.
        /// </summary>
        public ExpeditedQualityUpdateReference()
        {
            this.ODataType = "microsoft.graph.windowsUpdates.expeditedQualityUpdateReference";
        }

        /// <summary>
        /// Gets or sets equivalentContent.
        /// Specifies other content to consider as equivalent. Supports a subset of the values for equivalentContentOption. Default value is latestSecurity. Possible values are: latestSecurity.
        /// </summary>
        [JsonPropertyName("equivalentContent")]
        public EquivalentContentOption? EquivalentContent { get; set; }
    
    }
}
