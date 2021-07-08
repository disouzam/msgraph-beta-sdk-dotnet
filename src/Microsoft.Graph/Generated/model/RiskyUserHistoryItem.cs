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
    /// The type Risky User History Item.
    /// </summary>
    public partial class RiskyUserHistoryItem : RiskyUser
    {
    
        ///<summary>
        /// The RiskyUserHistoryItem constructor
        ///</summary>
        public RiskyUserHistoryItem()
        {
            this.ODataType = "microsoft.graph.riskyUserHistoryItem";
        }

        /// <summary>
        /// Gets or sets activity.
        /// The activity related to user risk level change.
        /// </summary>
        [JsonPropertyName("activity")]
        public RiskUserActivity Activity { get; set; }
    
        /// <summary>
        /// Gets or sets initiated by.
        /// The id of actor that does the operation.
        /// </summary>
        [JsonPropertyName("initiatedBy")]
        public string InitiatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The id of the user.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
    }
}

