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
    /// The enum ManagedAppFlaggedReason.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ManagedAppFlaggedReason
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Rooted Device
        /// </summary>
        RootedDevice = 1,
	
        /// <summary>
        /// Android Bootloader Unlocked
        /// </summary>
        AndroidBootloaderUnlocked = 2,
	
        /// <summary>
        /// Android Factory Rom Modified
        /// </summary>
        AndroidFactoryRomModified = 3,
	
    }
}
