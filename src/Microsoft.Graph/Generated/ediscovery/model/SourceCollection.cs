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
    /// The type Source Collection.
    /// </summary>
    public partial class SourceCollection : Microsoft.Graph.Entity
    {
    
		///<summary>
		/// The SourceCollection constructor
		///</summary>
        public SourceCollection()
        {
            this.ODataType = "microsoft.graph.ediscovery.sourceCollection";
        }
	
        /// <summary>
        /// Gets or sets content query.
        /// The query string in KQL (Keyword Query Language) query. For details, see Keyword queries and search conditions for Content Search and eDiscovery.  You can refine searches by using fields paired with values; for example, subject:'Quarterly Financials' AND Date&amp;gt;=06/01/2016 AND Date&amp;lt;=07/01/2016
        /// </summary>
        [JsonPropertyName("contentQuery")]
        public string ContentQuery { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// The user who created the sourceCollection.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public Microsoft.Graph.IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date and time the sourceCollection was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets data source scopes.
        /// </summary>
        [JsonPropertyName("dataSourceScopes")]
        public DataSourceScopes? DataSourceScopes { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the sourceCollection
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the sourceCollection
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets last modified by.
        /// The last user who modified the sourceCollection.
        /// </summary>
        [JsonPropertyName("lastModifiedBy")]
        public Microsoft.Graph.IdentitySet LastModifiedBy { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// The last date and time the sourceCollection was modified.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets tenant sources.
        /// When specified, the collection will span across a service for an entire workload. Possible values are: allMailboxes, allSites.
        /// </summary>
        [JsonPropertyName("tenantSources")]
        public TenantSources? TenantSources { get; set; }
    
        /// <summary>
        /// Gets or sets additional sources.
        /// Adds an additional source to the sourceCollection.
        /// </summary>
        [JsonPropertyName("additionalSources")]
        public ISourceCollectionAdditionalSourcesCollectionPage AdditionalSources { get; set; }
    
        /// <summary>
        /// Gets or sets add to review set operation.
        /// Adds the results of the sourceCollection to the specified reviewSet.
        /// </summary>
        [JsonPropertyName("addToReviewSetOperation")]
        public AddToReviewSetOperation AddToReviewSetOperation { get; set; }
    
        /// <summary>
        /// Gets or sets custodian sources.
        /// Custodian sources that are included in the sourceCollection.
        /// </summary>
        [JsonPropertyName("custodianSources")]
        public ISourceCollectionCustodianSourcesCollectionWithReferencesPage CustodianSources { get; set; }
    
        /// <summary>
        /// Gets or sets last estimate statistics operation.
        /// The last estimate operation associated with the sourceCollection.
        /// </summary>
        [JsonPropertyName("lastEstimateStatisticsOperation")]
        public EstimateStatisticsOperation LastEstimateStatisticsOperation { get; set; }
    
        /// <summary>
        /// Gets or sets noncustodial sources.
        /// </summary>
        [JsonPropertyName("noncustodialSources")]
        public ISourceCollectionNoncustodialSourcesCollectionWithReferencesPage NoncustodialSources { get; set; }
    
    }
}

