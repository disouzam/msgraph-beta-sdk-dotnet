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
    /// The type AssignedPlan.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AssignedPlan>))]
    public partial class AssignedPlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedPlan"/> class.
        /// </summary>
        public AssignedPlan()
        {
            this.ODataType = "microsoft.graph.assignedPlan";
        }

        /// <summary>
        /// Gets or sets assignedDateTime.
        /// The date and time at which the plan was assigned. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.
        /// </summary>
        [JsonPropertyName("assignedDateTime")]
        public DateTimeOffset? AssignedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets capabilityStatus.
        /// Condition of the capability assignment. The possible values are Enabled, Warning, Suspended, Deleted, LockedOut. See a detailed description of each value.
        /// </summary>
        [JsonPropertyName("capabilityStatus")]
        public string CapabilityStatus { get; set; }
    
        /// <summary>
        /// Gets or sets service.
        /// The name of the service; for example, 'Exchange'.
        /// </summary>
        [JsonPropertyName("service")]
        public string Service { get; set; }
    
        /// <summary>
        /// Gets or sets servicePlanId.
        /// A GUID that identifies the service plan.
        /// </summary>
        [JsonPropertyName("servicePlanId")]
        public Guid? ServicePlanId { get; set; }
    
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
