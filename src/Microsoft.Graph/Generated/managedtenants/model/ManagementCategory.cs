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
    /// The enum ManagementCategory.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ManagementCategory
    {
    
        /// <summary>
        /// Custom
        /// </summary>
        Custom = 0,
	
        /// <summary>
        /// Devices
        /// </summary>
        Devices = 1,
	
        /// <summary>
        /// Identity
        /// </summary>
        Identity = 2,
	
        /// <summary>
        /// Data
        /// </summary>
        Data = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
