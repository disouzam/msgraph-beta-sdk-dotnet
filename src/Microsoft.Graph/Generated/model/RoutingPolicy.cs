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
    /// The enum RoutingPolicy.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RoutingPolicy
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// No Missed Call
        /// </summary>
        NoMissedCall = 1,
	
        /// <summary>
        /// Disable Forwarding Except Phone
        /// </summary>
        DisableForwardingExceptPhone = 2,
	
        /// <summary>
        /// Disable Forwarding
        /// </summary>
        DisableForwarding = 3,
	
        /// <summary>
        /// Prefer Skype For Business
        /// </summary>
        PreferSkypeForBusiness = 5,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 6,
	
    }
}
