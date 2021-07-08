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
    /// The enum Windows10VpnConnectionType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Windows10VpnConnectionType
    {
    
        /// <summary>
        /// Pulse Secure
        /// </summary>
        PulseSecure = 0,
	
        /// <summary>
        /// F5Edge Client
        /// </summary>
        F5EdgeClient = 1,
	
        /// <summary>
        /// Dell Sonic Wall Mobile Connect
        /// </summary>
        DellSonicWallMobileConnect = 2,
	
        /// <summary>
        /// Check Point Capsule Vpn
        /// </summary>
        CheckPointCapsuleVpn = 3,
	
        /// <summary>
        /// Automatic
        /// </summary>
        Automatic = 4,
	
        /// <summary>
        /// Ik Ev2
        /// </summary>
        IkEv2 = 5,
	
        /// <summary>
        /// L2tp
        /// </summary>
        L2tp = 6,
	
        /// <summary>
        /// Pptp
        /// </summary>
        Pptp = 7,
	
        /// <summary>
        /// Citrix
        /// </summary>
        Citrix = 8,
	
        /// <summary>
        /// Palo Alto Global Protect
        /// </summary>
        PaloAltoGlobalProtect = 9,
	
        /// <summary>
        /// Cisco Any Connect
        /// </summary>
        CiscoAnyConnect = 10,
	
    }
}
