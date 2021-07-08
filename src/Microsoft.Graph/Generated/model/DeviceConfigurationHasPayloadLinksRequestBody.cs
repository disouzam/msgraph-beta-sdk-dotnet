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
    /// The type DeviceConfigurationHasPayloadLinksRequestBody.
    /// </summary>
    public partial class DeviceConfigurationHasPayloadLinksRequestBody
    {
    
        /// <summary>
        /// Gets or sets PayloadIds.
        /// </summary>
        [JsonPropertyName("payloadIds")]
        public IEnumerable<string> PayloadIds { get; set; }
    
    }
}
