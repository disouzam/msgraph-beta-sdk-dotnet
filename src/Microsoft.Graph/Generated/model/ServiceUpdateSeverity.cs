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
    /// The enum ServiceUpdateSeverity.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ServiceUpdateSeverity
    {
    
        /// <summary>
        /// Normal
        /// </summary>
        Normal = 1,
	
        /// <summary>
        /// High
        /// </summary>
        High = 2,
	
        /// <summary>
        /// Critical
        /// </summary>
        Critical = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
