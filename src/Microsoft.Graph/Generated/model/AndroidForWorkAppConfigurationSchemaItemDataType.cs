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
    /// The enum AndroidForWorkAppConfigurationSchemaItemDataType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AndroidForWorkAppConfigurationSchemaItemDataType
    {
    
        /// <summary>
        /// Bool
        /// </summary>
        Bool = 0,
	
        /// <summary>
        /// Integer
        /// </summary>
        Integer = 1,
	
        /// <summary>
        /// String
        /// </summary>
        @String = 2,
	
        /// <summary>
        /// Choice
        /// </summary>
        Choice = 3,
	
        /// <summary>
        /// Multiselect
        /// </summary>
        Multiselect = 4,
	
        /// <summary>
        /// Bundle
        /// </summary>
        Bundle = 5,
	
        /// <summary>
        /// Bundle Array
        /// </summary>
        BundleArray = 6,
	
        /// <summary>
        /// Hidden
        /// </summary>
        Hidden = 7,
	
    }
}
