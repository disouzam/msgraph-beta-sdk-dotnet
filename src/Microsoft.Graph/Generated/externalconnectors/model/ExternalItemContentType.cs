// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.ExternalConnectors
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum ExternalItemContentType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExternalItemContentType
    {
    
        /// <summary>
        /// Text
        /// </summary>
        Text = 1,
	
        /// <summary>
        /// Html
        /// </summary>
        Html = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 3,
	
    }
}
