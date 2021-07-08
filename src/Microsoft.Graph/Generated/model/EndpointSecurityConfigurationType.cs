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
    /// The enum EndpointSecurityConfigurationType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EndpointSecurityConfigurationType
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Antivirus
        /// </summary>
        Antivirus = 1,
	
        /// <summary>
        /// Disk Encryption
        /// </summary>
        DiskEncryption = 2,
	
        /// <summary>
        /// Firewall
        /// </summary>
        Firewall = 3,
	
        /// <summary>
        /// Endpoint Detection And Response
        /// </summary>
        EndpointDetectionAndResponse = 4,
	
        /// <summary>
        /// Attack Surface Reduction
        /// </summary>
        AttackSurfaceReduction = 5,
	
        /// <summary>
        /// Account Protection
        /// </summary>
        AccountProtection = 6,
	
    }
}
