// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Android Work Profile Nine Work Eas Configuration.
    /// </summary>
    public partial class AndroidWorkProfileNineWorkEasConfiguration : AndroidWorkProfileEasEmailProfileBase
    {
    
        ///<summary>
        /// The AndroidWorkProfileNineWorkEasConfiguration constructor
        ///</summary>
        public AndroidWorkProfileNineWorkEasConfiguration()
        {
            this.ODataType = "microsoft.graph.androidWorkProfileNineWorkEasConfiguration";
        }

        /// <summary>
        /// Gets or sets sync calendar.
        /// Toggles syncing the calendar. If set to false the calendar is turned off on the device.
        /// </summary>
        [JsonPropertyName("syncCalendar")]
        public bool? SyncCalendar { get; set; }
    
        /// <summary>
        /// Gets or sets sync contacts.
        /// Toggles syncing contacts. If set to false contacts are turned off on the device.
        /// </summary>
        [JsonPropertyName("syncContacts")]
        public bool? SyncContacts { get; set; }
    
        /// <summary>
        /// Gets or sets sync tasks.
        /// Toggles syncing tasks. If set to false tasks are turned off on the device.
        /// </summary>
        [JsonPropertyName("syncTasks")]
        public bool? SyncTasks { get; set; }
    
    }
}

