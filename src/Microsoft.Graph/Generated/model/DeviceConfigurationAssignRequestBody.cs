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
    /// The type DeviceConfigurationAssignRequestBody.
    /// </summary>
    public partial class DeviceConfigurationAssignRequestBody
    {
    
        /// <summary>
        /// Gets or sets DeviceConfigurationGroupAssignments.
        /// </summary>
        [JsonPropertyName("deviceConfigurationGroupAssignments")]
        public IEnumerable<DeviceConfigurationGroupAssignment> DeviceConfigurationGroupAssignments { get; set; }
    
        /// <summary>
        /// Gets or sets Assignments.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IEnumerable<DeviceConfigurationAssignment> Assignments { get; set; }
    
    }
}
