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
    /// The enum DeviceGuardVirtualizationBasedSecurityState.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeviceGuardVirtualizationBasedSecurityState
    {
    
        /// <summary>
        /// Running
        /// </summary>
        Running = 0,
	
        /// <summary>
        /// Reboot Required
        /// </summary>
        RebootRequired = 1,
	
        /// <summary>
        /// Require64Bit Architecture
        /// </summary>
        Require64BitArchitecture = 2,
	
        /// <summary>
        /// Not Licensed
        /// </summary>
        NotLicensed = 3,
	
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 4,
	
        /// <summary>
        /// Does Not Meet Hardware Requirements
        /// </summary>
        DoesNotMeetHardwareRequirements = 5,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 42,
	
    }
}
