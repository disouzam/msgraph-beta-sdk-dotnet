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
    /// The enum PrinterFeedOrientation.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PrinterFeedOrientation
    {
    
        /// <summary>
        /// Long Edge First
        /// </summary>
        LongEdgeFirst = 0,
	
        /// <summary>
        /// Short Edge First
        /// </summary>
        ShortEdgeFirst = 1,
	
    }
}
