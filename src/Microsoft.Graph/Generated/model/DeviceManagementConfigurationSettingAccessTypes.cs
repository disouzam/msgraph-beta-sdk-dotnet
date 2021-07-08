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
    /// The enum DeviceManagementConfigurationSettingAccessTypes.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
	[System.Flags]
    public enum DeviceManagementConfigurationSettingAccessTypes
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Add
        /// </summary>
        Add = 1,
	
        /// <summary>
        /// Copy
        /// </summary>
        Copy = 2,
	
        /// <summary>
        /// Delete
        /// </summary>
        Delete = 4,
	
        /// <summary>
        /// Get
        /// </summary>
        Get = 8,
	
        /// <summary>
        /// Replace
        /// </summary>
        Replace = 16,
	
        /// <summary>
        /// Execute
        /// </summary>
        Execute = 32,
	
    }
}
