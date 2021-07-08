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
    /// The enum WindowsPrivacyDataAccessLevel.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WindowsPrivacyDataAccessLevel
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Force Allow
        /// </summary>
        ForceAllow = 1,
	
        /// <summary>
        /// Force Deny
        /// </summary>
        ForceDeny = 2,
	
        /// <summary>
        /// User In Control
        /// </summary>
        UserInControl = 3,
	
    }
}
