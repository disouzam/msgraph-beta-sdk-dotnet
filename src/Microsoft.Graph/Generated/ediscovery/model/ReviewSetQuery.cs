// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Review Set Query.
    /// </summary>
    public partial class ReviewSetQuery : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The ReviewSetQuery constructor
		///</summary>
        public ReviewSetQuery()
        {
            this.ODataType = "microsoft.graph.ediscovery.reviewSetQuery";
        }
	
        /// <summary>
        /// Gets or sets created by.
        /// The user who created the query.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public Microsoft.Graph.IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The time and date when the query was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the query.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// The user who last modified the query.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public Microsoft.Graph.IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The date and time the query was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets query.
        /// The query string in KQL (Keyword Query Language) query. For details, see Document metadata fields in Advanced eDiscovery.  This field maps directly to the keywords condition.  You can refine searches by using fields listed in the searchable field name paired with values; for example, subject:'Quarterly Financials' AND Date&amp;gt;=06/01/2016 AND Date&amp;lt;=07/01/2016.
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }
    
    }
}

