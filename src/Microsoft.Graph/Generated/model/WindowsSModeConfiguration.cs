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
    /// The enum WindowsSModeConfiguration.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WindowsSModeConfiguration
    {
    
        /// <summary>
        /// No Restriction
        /// </summary>
        NoRestriction = 0,
	
        /// <summary>
        /// Block
        /// </summary>
        Block = 1,
	
        /// <summary>
        /// Unlock
        /// </summary>
        Unlock = 2,
	
    }
}
