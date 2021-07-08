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
    /// The enum InkAccessSetting.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InkAccessSetting
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Enabled
        /// </summary>
        Enabled = 1,
	
        /// <summary>
        /// Disabled
        /// </summary>
        Disabled = 2,
	
    }
}
