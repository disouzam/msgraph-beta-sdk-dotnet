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
    /// The type Approval Workflow Provider.
    /// </summary>
    public partial class ApprovalWorkflowProvider : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets business flows.
        /// </summary>
        [JsonPropertyName("businessFlows")]
        public IApprovalWorkflowProviderBusinessFlowsCollectionPage BusinessFlows { get; set; }

        /// <summary>
        /// Gets or sets businessFlowsNextLink.
        /// </summary>
        [JsonPropertyName("businessFlows@odata.nextLink")]
        public string BusinessFlowsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets business flows with requests awaiting my decision.
        /// </summary>
        [JsonPropertyName("businessFlowsWithRequestsAwaitingMyDecision")]
        public IApprovalWorkflowProviderBusinessFlowsWithRequestsAwaitingMyDecisionCollectionPage BusinessFlowsWithRequestsAwaitingMyDecision { get; set; }

        /// <summary>
        /// Gets or sets businessFlowsWithRequestsAwaitingMyDecisionNextLink.
        /// </summary>
        [JsonPropertyName("businessFlowsWithRequestsAwaitingMyDecision@odata.nextLink")]
        public string BusinessFlowsWithRequestsAwaitingMyDecisionNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets policy templates.
        /// </summary>
        [JsonPropertyName("policyTemplates")]
        public IApprovalWorkflowProviderPolicyTemplatesCollectionPage PolicyTemplates { get; set; }

        /// <summary>
        /// Gets or sets policyTemplatesNextLink.
        /// </summary>
        [JsonPropertyName("policyTemplates@odata.nextLink")]
        public string PolicyTemplatesNextLink { get; set; }
    
    }
}

