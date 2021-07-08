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
    /// The enum PrintMultipageLayout.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PrintMultipageLayout
    {
    
        /// <summary>
        /// Clockwise From Top Left
        /// </summary>
        ClockwiseFromTopLeft = 0,
	
        /// <summary>
        /// Counterclockwise From Top Left
        /// </summary>
        CounterclockwiseFromTopLeft = 1,
	
        /// <summary>
        /// Counterclockwise From Top Right
        /// </summary>
        CounterclockwiseFromTopRight = 2,
	
        /// <summary>
        /// Clockwise From Top Right
        /// </summary>
        ClockwiseFromTopRight = 3,
	
        /// <summary>
        /// Counterclockwise From Bottom Left
        /// </summary>
        CounterclockwiseFromBottomLeft = 4,
	
        /// <summary>
        /// Clockwise From Bottom Left
        /// </summary>
        ClockwiseFromBottomLeft = 5,
	
        /// <summary>
        /// Counterclockwise From Bottom Right
        /// </summary>
        CounterclockwiseFromBottomRight = 6,
	
        /// <summary>
        /// Clockwise From Bottom Right
        /// </summary>
        ClockwiseFromBottomRight = 7,
	
    }
}
