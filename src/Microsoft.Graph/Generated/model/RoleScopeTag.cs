// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Role Scope Tag.
    /// </summary>
    public partial class RoleScopeTag : Entity
    {
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the Role Scope Tag.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display or friendly name of the Role Scope Tag.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is built in.
        /// Description of the Role Scope Tag. This property is read-only.
        /// </summary>
        [JsonPropertyName("isBuiltIn")]
        public bool? IsBuiltIn { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of assignments for this Role Scope Tag.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IRoleScopeTagAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
    }
}

