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
    /// The type PrivilegedRoleAssignmentMakePermanentRequestBody.
    /// </summary>
    public partial class PrivilegedRoleAssignmentMakePermanentRequestBody
    {
    
        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    
        /// <summary>
        /// Gets or sets TicketNumber.
        /// </summary>
        [JsonPropertyName("ticketNumber")]
        public string TicketNumber { get; set; }
    
        /// <summary>
        /// Gets or sets TicketSystem.
        /// </summary>
        [JsonPropertyName("ticketSystem")]
        public string TicketSystem { get; set; }
    
    }
}
