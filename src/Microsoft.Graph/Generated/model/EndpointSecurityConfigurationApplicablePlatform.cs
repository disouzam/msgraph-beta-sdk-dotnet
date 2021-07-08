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
    /// The enum EndpointSecurityConfigurationApplicablePlatform.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EndpointSecurityConfigurationApplicablePlatform
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Mac OS
        /// </summary>
        MacOS = 1,
	
        /// <summary>
        /// Windows10And Later
        /// </summary>
        Windows10AndLater = 2,
	
        /// <summary>
        /// Windows10And Windows Server
        /// </summary>
        Windows10AndWindowsServer = 3,
	
    }
}
