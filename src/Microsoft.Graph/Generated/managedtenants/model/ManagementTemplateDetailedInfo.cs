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
    /// The type ManagementTemplateDetailedInfo.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ManagementTemplateDetailedInfo>))]
    public partial class ManagementTemplateDetailedInfo
    {

        /// <summary>
        /// Gets or sets category.
        /// The management category for the management template. Possible values are: custom, devices, identity, unknownFutureValue. Required. Read-only.
        /// </summary>
        [JsonPropertyName("category")]
        public ManagementCategory? Category { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The display name for the management template. Required. Read-only.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets managementTemplateId.
        /// The unique identifier for the management template. Required. Read-only.
        /// </summary>
        [JsonPropertyName("managementTemplateId")]
        public string ManagementTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// </summary>
        [JsonPropertyName("version")]
        public Int32? Version { get; set; }
    
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
