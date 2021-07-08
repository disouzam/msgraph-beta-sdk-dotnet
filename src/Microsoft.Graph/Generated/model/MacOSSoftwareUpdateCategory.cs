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
    /// The enum MacOSSoftwareUpdateCategory.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MacOSSoftwareUpdateCategory
    {
    
        /// <summary>
        /// Critical
        /// </summary>
        Critical = 0,
	
        /// <summary>
        /// Configuration Data File
        /// </summary>
        ConfigurationDataFile = 1,
	
        /// <summary>
        /// Firmware
        /// </summary>
        Firmware = 2,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 3,
	
    }
}
