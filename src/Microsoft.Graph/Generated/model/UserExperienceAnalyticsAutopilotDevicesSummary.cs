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
    /// The type UserExperienceAnalyticsAutopilotDevicesSummary.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<UserExperienceAnalyticsAutopilotDevicesSummary>))]
    public partial class UserExperienceAnalyticsAutopilotDevicesSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserExperienceAnalyticsAutopilotDevicesSummary"/> class.
        /// </summary>
        public UserExperienceAnalyticsAutopilotDevicesSummary()
        {
            this.ODataType = "microsoft.graph.userExperienceAnalyticsAutopilotDevicesSummary";
        }

        /// <summary>
        /// Gets or sets devicesNotAutopilotRegistered.
        /// The count of intune devices that are not autopilot registerd.
        /// </summary>
        [JsonPropertyName("devicesNotAutopilotRegistered")]
        public Int32? DevicesNotAutopilotRegistered { get; set; }
    
        /// <summary>
        /// Gets or sets devicesWithoutAutopilotProfileAssigned.
        /// The count of intune devices not autopilot profile assigned.
        /// </summary>
        [JsonPropertyName("devicesWithoutAutopilotProfileAssigned")]
        public Int32? DevicesWithoutAutopilotProfileAssigned { get; set; }
    
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
