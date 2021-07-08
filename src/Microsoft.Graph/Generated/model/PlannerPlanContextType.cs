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
    /// The enum PlannerPlanContextType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PlannerPlanContextType
    {
    
        /// <summary>
        /// Teams Tab
        /// </summary>
        TeamsTab = 1,
	
        /// <summary>
        /// Share Point Page
        /// </summary>
        SharePointPage = 2,
	
        /// <summary>
        /// Meeting Notes
        /// </summary>
        MeetingNotes = 3,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 4,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 5,
	
    }
}
