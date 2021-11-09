// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ManagementActionInfo.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ManagementActionInfo>))]
    public partial class ManagementActionInfo
    {

        /// <summary>
        /// Gets or sets managementActionId.
        /// The identifier for the management action. Required. Read-only.
        /// </summary>
        [JsonPropertyName("managementActionId")]
        public string ManagementActionId { get; set; }
    
        /// <summary>
        /// Gets or sets managementTemplateId.
        /// The identifier for the management template. Required. Read-only.
        /// </summary>
        [JsonPropertyName("managementTemplateId")]
        public string ManagementTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets managementTemplateVersion.
        /// </summary>
        [JsonPropertyName("managementTemplateVersion")]
        public Int32? ManagementTemplateVersion { get; set; }
    
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
