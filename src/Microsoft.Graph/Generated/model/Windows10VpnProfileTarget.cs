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
    /// The enum Windows10VpnProfileTarget.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Windows10VpnProfileTarget
    {
    
        /// <summary>
        /// User
        /// </summary>
        User = 0,
	
        /// <summary>
        /// Device
        /// </summary>
        Device = 1,
	
        /// <summary>
        /// Auto Pilot Device
        /// </summary>
        AutoPilotDevice = 2,
	
    }
}
