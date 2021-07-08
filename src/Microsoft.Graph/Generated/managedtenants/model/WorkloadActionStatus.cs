// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.ManagedTenants
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum WorkloadActionStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkloadActionStatus
    {
    
        /// <summary>
        /// To Address
        /// </summary>
        ToAddress = 0,
	
        /// <summary>
        /// Completed
        /// </summary>
        Completed = 5,
	
        /// <summary>
        /// Error
        /// </summary>
        Error = 10,
	
        /// <summary>
        /// Time Out
        /// </summary>
        TimeOut = 15,
	
        /// <summary>
        /// In Progress
        /// </summary>
        InProgress = 20,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 25,
	
    }
}
