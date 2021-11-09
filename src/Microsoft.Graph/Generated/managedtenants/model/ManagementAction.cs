// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ManagedTenants
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Management Action.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ManagementAction>))]
    public partial class ManagementAction : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets category.
        /// The category for the management action. Possible values are: custom, devices, identity, unknownFutureValue. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("category")]
        public ManagementCategory? Category { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description for the management action. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for the management action. Optional. Read-only.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets reference template id.
        /// The reference for the management template used to generate the management action. Required. Read-only.
        /// </summary>
        [JsonPropertyName("referenceTemplateId")]
        public string ReferenceTemplateId { get; set; }
    
        /// <summary>
        /// Gets or sets reference template version.
        /// </summary>
        [JsonPropertyName("referenceTemplateVersion")]
        public Int32? ReferenceTemplateVersion { get; set; }
    
        /// <summary>
        /// Gets or sets workload actions.
        /// The collection of workload actions associated with the management action. Required. Read-only.
        /// </summary>
        [JsonPropertyName("workloadActions")]
        public IEnumerable<WorkloadAction> WorkloadActions { get; set; }
    
    }
}

