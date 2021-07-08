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
    /// The type PlannerPlanContainer.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PlannerPlanContainer>))]
    public partial class PlannerPlanContainer
    {

        /// <summary>
        /// Gets or sets containerId.
        /// The identifier of the resource that contains the plan.
        /// </summary>
        [JsonPropertyName("containerId")]
        public string ContainerId { get; set; }
    
        /// <summary>
        /// Gets or sets type.
        /// The type of the resource that contains the plan. See the previous table for supported types. Possible values are: group, roster, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("type")]
        public PlannerContainerType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets url.
        /// The full canonical URL of the container.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    
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
