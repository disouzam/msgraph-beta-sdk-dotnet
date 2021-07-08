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
    /// The enum TlpLevel.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TlpLevel
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// White
        /// </summary>
        White = 1,
	
        /// <summary>
        /// Green
        /// </summary>
        Green = 2,
	
        /// <summary>
        /// Amber
        /// </summary>
        Amber = 3,
	
        /// <summary>
        /// Red
        /// </summary>
        Red = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 127,
	
    }
}
