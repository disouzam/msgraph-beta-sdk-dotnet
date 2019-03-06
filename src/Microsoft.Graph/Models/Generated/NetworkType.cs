// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum NetworkType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum NetworkType
    {
    
        /// <summary>
        /// intranet
        /// </summary>
        Intranet = 0,
	
        /// <summary>
        /// extranet
        /// </summary>
        Extranet = 1,
	
        /// <summary>
        /// named Network
        /// </summary>
        NamedNetwork = 2,
	
        /// <summary>
        /// trusted
        /// </summary>
        Trusted = 3,
	
        /// <summary>
        /// unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}