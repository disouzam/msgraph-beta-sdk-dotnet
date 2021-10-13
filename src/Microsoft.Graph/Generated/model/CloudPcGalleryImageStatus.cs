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
    /// The enum CloudPcGalleryImageStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CloudPcGalleryImageStatus
    {
    
        /// <summary>
        /// Supported
        /// </summary>
        Supported = 0,
	
        /// <summary>
        /// Supported With Warning
        /// </summary>
        SupportedWithWarning = 1,
	
        /// <summary>
        /// Not Supported
        /// </summary>
        NotSupported = 2,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 999,
	
    }
}
