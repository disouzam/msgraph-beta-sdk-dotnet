// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.WindowsUpdates
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum DeploymentStateValue.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeploymentStateValue
    {
    
        /// <summary>
        /// Scheduled
        /// </summary>
        Scheduled = 0,
	
        /// <summary>
        /// Offering
        /// </summary>
        Offering = 1,
	
        /// <summary>
        /// Paused
        /// </summary>
        Paused = 2,
	
        /// <summary>
        /// Faulted
        /// </summary>
        Faulted = 3,
	
        /// <summary>
        /// Archived
        /// </summary>
        Archived = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
