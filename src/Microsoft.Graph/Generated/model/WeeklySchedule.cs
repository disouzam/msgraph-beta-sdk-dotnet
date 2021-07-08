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
    /// The enum WeeklySchedule.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WeeklySchedule
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Everyday
        /// </summary>
        Everyday = 1,
	
        /// <summary>
        /// Sunday
        /// </summary>
        Sunday = 2,
	
        /// <summary>
        /// Monday
        /// </summary>
        Monday = 3,
	
        /// <summary>
        /// Tuesday
        /// </summary>
        Tuesday = 4,
	
        /// <summary>
        /// Wednesday
        /// </summary>
        Wednesday = 5,
	
        /// <summary>
        /// Thursday
        /// </summary>
        Thursday = 6,
	
        /// <summary>
        /// Friday
        /// </summary>
        Friday = 7,
	
        /// <summary>
        /// Saturday
        /// </summary>
        Saturday = 8,
	
        /// <summary>
        /// No Scheduled Scan
        /// </summary>
        NoScheduledScan = 9,
	
    }
}
