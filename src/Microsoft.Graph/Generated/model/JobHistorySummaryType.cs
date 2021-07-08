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
    /// The enum JobHistorySummaryType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum JobHistorySummaryType
    {
    
        /// <summary>
        /// Printer
        /// </summary>
        Printer = 0,
	
        /// <summary>
        /// User
        /// </summary>
        User = 1,
	
        /// <summary>
        /// Group
        /// </summary>
        Group = 2,
	
    }
}
