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
    /// The type WindowsDriverUpdateProfileExecuteActionRequestBody.
    /// </summary>
    public partial class WindowsDriverUpdateProfileExecuteActionRequestBody
    {
    
        /// <summary>
        /// Gets or sets ActionName.
        /// </summary>
        [JsonPropertyName("actionName")]
        public DriverApprovalAction ActionName { get; set; }
    
        /// <summary>
        /// Gets or sets DriverIds.
        /// </summary>
        [JsonPropertyName("driverIds")]
        public IEnumerable<string> DriverIds { get; set; }
    
        /// <summary>
        /// Gets or sets DeploymentDate.
        /// </summary>
        [JsonPropertyName("deploymentDate")]
        public DateTimeOffset? DeploymentDate { get; set; }
    
    }
}
