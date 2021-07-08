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
    /// The type On Premises Agent Group.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OnPremisesAgentGroup>))]
    public partial class OnPremisesAgentGroup : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// Display name of the onPremisesAgentGroup.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is default.
        /// Indicates if the onPremisesAgentGroup is the default agent group. Only a single agent group can be the default onPremisesAgentGroup and is set by the system.
        /// </summary>
        [JsonPropertyName("isDefault")]
        public bool? IsDefault { get; set; }
    
        /// <summary>
        /// Gets or sets publishing type.
        /// Possible values are: applicationProxy, exchangeOnline, authentication, provisioning, adAdministration.
        /// </summary>
        [JsonPropertyName("publishingType")]
        public OnPremisesPublishingType? PublishingType { get; set; }
    
        /// <summary>
        /// Gets or sets agents.
        /// List of onPremisesAgent that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("agents")]
        public IOnPremisesAgentGroupAgentsCollectionPage Agents { get; set; }

        /// <summary>
        /// Gets or sets agentsNextLink.
        /// </summary>
        [JsonPropertyName("agents@odata.nextLink")]
        public string AgentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets published resources.
        /// List of publishedResource that are assigned to an onPremisesAgentGroup. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("publishedResources")]
        public IOnPremisesAgentGroupPublishedResourcesCollectionPage PublishedResources { get; set; }

        /// <summary>
        /// Gets or sets publishedResourcesNextLink.
        /// </summary>
        [JsonPropertyName("publishedResources@odata.nextLink")]
        public string PublishedResourcesNextLink { get; set; }
    
    }
}

