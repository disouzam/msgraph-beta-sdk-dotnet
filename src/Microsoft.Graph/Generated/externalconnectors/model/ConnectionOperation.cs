// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Connection Operation.
    /// </summary>
    public partial class ConnectionOperation : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The ConnectionOperation constructor
		///</summary>
        public ConnectionOperation()
        {
            this.ODataType = "microsoft.graph.externalConnectors.connectionOperation";
        }
	
        /// <summary>
        /// Gets or sets error.
        /// </summary>
        [JsonPropertyName("error")]
        public Microsoft.Graph.PublicError Error { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public ConnectionOperationStatus? Status { get; set; }
    
    }
}

