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
    /// The type Enrollment Configuration Assignment.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EnrollmentConfigurationAssignment>))]
    public partial class EnrollmentConfigurationAssignment : Entity
    {
    
		///<summary>
		/// The EnrollmentConfigurationAssignment constructor
		///</summary>
        public EnrollmentConfigurationAssignment()
        {
            this.ODataType = "microsoft.graph.enrollmentConfigurationAssignment";
        }
	
        /// <summary>
        /// Gets or sets source.
        /// Type of resource used for deployment to a group, direct or policySet. Possible values are: direct, policySets.
        /// </summary>
        [JsonPropertyName("source")]
        public DeviceAndAppManagementAssignmentSource? Source { get; set; }
    
        /// <summary>
        /// Gets or sets source id.
        /// Identifier for resource used for deployment to a group
        /// </summary>
        [JsonPropertyName("sourceId")]
        public string SourceId { get; set; }
    
        /// <summary>
        /// Gets or sets target.
        /// Represents an assignment to managed devices in the tenant
        /// </summary>
        [JsonPropertyName("target")]
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
    
    }
}

