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
    /// The type Admin.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Admin>))]
    public partial class Admin
    {
    
        /// <summary>
        /// Gets or sets sharepoint.
        /// A container for administrative resources to manage tenant-level settings for SharePoint and OneDrive.
        /// </summary>
        [JsonPropertyName("sharepoint")]
        public Microsoft.Graph.TenantAdmin.Sharepoint Sharepoint { get; set; }
    
        /// <summary>
        /// Gets or sets service announcement.
        /// A container for service communications resources. Read-only.
        /// </summary>
        [JsonPropertyName("serviceAnnouncement")]
        public ServiceAnnouncement ServiceAnnouncement { get; set; }
    
        /// <summary>
        /// Gets or sets windows.
        /// A container for all Windows Update for Business deployment service functionality. Read-only.
        /// </summary>
        [JsonPropertyName("windows")]
        public Microsoft.Graph.WindowsUpdates.Windows Windows { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

