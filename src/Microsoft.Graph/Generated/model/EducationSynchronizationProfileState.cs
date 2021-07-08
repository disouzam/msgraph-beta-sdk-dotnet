// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum EducationSynchronizationProfileState.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EducationSynchronizationProfileState
    {
    
        /// <summary>
        /// Deleting
        /// </summary>
        Deleting = 2,
	
        /// <summary>
        /// Deletion Failed
        /// </summary>
        DeletionFailed = 3,
	
        /// <summary>
        /// Provisioning Failed
        /// </summary>
        ProvisioningFailed = 5,
	
        /// <summary>
        /// Provisioned
        /// </summary>
        Provisioned = 6,
	
        /// <summary>
        /// Provisioning
        /// </summary>
        Provisioning = 7,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 8,
	
    }
}
