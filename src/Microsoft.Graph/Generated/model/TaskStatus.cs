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
    /// The enum TaskStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TaskStatus
    {
    
        /// <summary>
        /// Not Started
        /// </summary>
        NotStarted = 0,
	
        /// <summary>
        /// In Progress
        /// </summary>
        InProgress = 1,
	
        /// <summary>
        /// Completed
        /// </summary>
        Completed = 2,
	
        /// <summary>
        /// Waiting On Others
        /// </summary>
        WaitingOnOthers = 3,
	
        /// <summary>
        /// Deferred
        /// </summary>
        Deferred = 4,
	
    }
}
