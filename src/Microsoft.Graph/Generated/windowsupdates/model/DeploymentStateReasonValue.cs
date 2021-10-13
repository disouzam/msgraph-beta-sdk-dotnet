// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.WindowsUpdates
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum DeploymentStateReasonValue.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeploymentStateReasonValue
    {
    
        /// <summary>
        /// Scheduled By Offer Window
        /// </summary>
        ScheduledByOfferWindow = 0,
	
        /// <summary>
        /// Offering By Request
        /// </summary>
        OfferingByRequest = 2,
	
        /// <summary>
        /// Paused By Request
        /// </summary>
        PausedByRequest = 3,
	
        /// <summary>
        /// Paused By Monitoring
        /// </summary>
        PausedByMonitoring = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
        /// <summary>
        /// Faulted By Content Outdated
        /// </summary>
        FaultedByContentOutdated = 6,
	
    }
}
