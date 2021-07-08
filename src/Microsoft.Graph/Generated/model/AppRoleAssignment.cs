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
    /// The type App Role Assignment.
    /// </summary>
    public partial class AppRoleAssignment : Entity
    {
    
        /// <summary>
        /// Gets or sets app role id.
        /// The identifier (id) for the app role which is assigned to the principal. This app role must be exposed in the appRoles property on the resource application's service principal (resourceId). If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles. Required on create.
        /// </summary>
        [JsonPropertyName("appRoleId")]
        public Guid? AppRoleId { get; set; }
    
        /// <summary>
        /// Gets or sets creation timestamp.
        /// The time when the app role assignment was created.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonPropertyName("creationTimestamp")]
        public DateTimeOffset? CreationTimestamp { get; set; }
    
        /// <summary>
        /// Gets or sets principal display name.
        /// The display name of the user, group, or service principal that was granted the app role assignment. Read-only. Supports $filter (eq and startswith).
        /// </summary>
        [JsonPropertyName("principalDisplayName")]
        public string PrincipalDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets principal id.
        /// The unique identifier (id) for the user, group or service principal being granted the app role. Required on create.
        /// </summary>
        [JsonPropertyName("principalId")]
        public Guid? PrincipalId { get; set; }
    
        /// <summary>
        /// Gets or sets principal type.
        /// The type of the assigned principal. This can either be User, Group or ServicePrincipal. Read-only.
        /// </summary>
        [JsonPropertyName("principalType")]
        public string PrincipalType { get; set; }
    
        /// <summary>
        /// Gets or sets resource display name.
        /// The display name of the resource app's service principal to which the assignment is made.
        /// </summary>
        [JsonPropertyName("resourceDisplayName")]
        public string ResourceDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets resource id.
        /// The unique identifier (id) for the resource service principal for which the assignment is made. Required on create. Supports $filter (eq only).
        /// </summary>
        [JsonPropertyName("resourceId")]
        public Guid? ResourceId { get; set; }
    
    }
}

