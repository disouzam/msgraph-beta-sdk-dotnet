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
    /// The enum AttributeMappingSourceType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AttributeMappingSourceType
    {
    
        /// <summary>
        /// Attribute
        /// </summary>
        Attribute = 0,
	
        /// <summary>
        /// Constant
        /// </summary>
        Constant = 1,
	
        /// <summary>
        /// Function
        /// </summary>
        Function = 2,
	
    }
}
