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
    /// The enum DeviceManagementDomainJoinConnectorState.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeviceManagementDomainJoinConnectorState
    {
    
        /// <summary>
        /// Active
        /// </summary>
        Active = 0,
	
        /// <summary>
        /// Error
        /// </summary>
        Error = 1,
	
        /// <summary>
        /// Inactive
        /// </summary>
        Inactive = 2,
	
    }
}
