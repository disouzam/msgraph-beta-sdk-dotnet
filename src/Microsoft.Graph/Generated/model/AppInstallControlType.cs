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
    /// The enum AppInstallControlType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AppInstallControlType
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Anywhere
        /// </summary>
        Anywhere = 1,
	
        /// <summary>
        /// Store Only
        /// </summary>
        StoreOnly = 2,
	
        /// <summary>
        /// Recommendations
        /// </summary>
        Recommendations = 3,
	
        /// <summary>
        /// Prefer Store
        /// </summary>
        PreferStore = 4,
	
    }
}
