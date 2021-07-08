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
    /// The enum RuleMode.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RuleMode
    {
    
        /// <summary>
        /// Audit
        /// </summary>
        Audit = 1,
	
        /// <summary>
        /// Audit And Notify
        /// </summary>
        AuditAndNotify = 2,
	
        /// <summary>
        /// Enforce
        /// </summary>
        Enforce = 3,
	
        /// <summary>
        /// Pending Deletion
        /// </summary>
        PendingDeletion = 4,
	
        /// <summary>
        /// Test
        /// </summary>
        Test = 5,
	
    }
}
