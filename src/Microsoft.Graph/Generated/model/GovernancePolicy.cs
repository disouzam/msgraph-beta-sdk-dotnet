// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type GovernancePolicy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<GovernancePolicy>))]
    public partial class GovernancePolicy
    {

        /// <summary>
        /// Gets or sets decisionMakerCriteria.
        /// </summary>
        [JsonPropertyName("decisionMakerCriteria")]
        public IEnumerable<GovernanceCriteria> DecisionMakerCriteria { get; set; }
    
        /// <summary>
        /// Gets or sets notificationPolicy.
        /// </summary>
        [JsonPropertyName("notificationPolicy")]
        public GovernanceNotificationPolicy NotificationPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
