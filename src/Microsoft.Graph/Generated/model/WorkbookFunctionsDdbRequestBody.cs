// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsDdbRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsDdbRequestBody
    {
    
        /// <summary>
        /// Gets or sets Cost.
        /// </summary>
        [JsonPropertyName("cost")]
        public System.Text.Json.JsonDocument Cost { get; set; }
    
        /// <summary>
        /// Gets or sets Salvage.
        /// </summary>
        [JsonPropertyName("salvage")]
        public System.Text.Json.JsonDocument Salvage { get; set; }
    
        /// <summary>
        /// Gets or sets Life.
        /// </summary>
        [JsonPropertyName("life")]
        public System.Text.Json.JsonDocument Life { get; set; }
    
        /// <summary>
        /// Gets or sets Period.
        /// </summary>
        [JsonPropertyName("period")]
        public System.Text.Json.JsonDocument Period { get; set; }
    
        /// <summary>
        /// Gets or sets Factor.
        /// </summary>
        [JsonPropertyName("factor")]
        public System.Text.Json.JsonDocument Factor { get; set; }
    
    }
}
