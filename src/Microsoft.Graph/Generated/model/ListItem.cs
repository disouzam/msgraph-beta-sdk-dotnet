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
    /// The type List Item.
    /// </summary>
    public partial class ListItem : BaseItem
    {
    
        ///<summary>
        /// The ListItem constructor
        ///</summary>
        public ListItem()
        {
            this.ODataType = "microsoft.graph.listItem";
        }

        /// <summary>
        /// Gets or sets content type.
        /// The content type of this list item
        /// </summary>
        [JsonPropertyName("contentType")]
        public ContentTypeInfo ContentType { get; set; }
    
        /// <summary>
        /// Gets or sets deleted.
        /// </summary>
        [JsonPropertyName("deleted")]
        public Deleted Deleted { get; set; }
    
        /// <summary>
        /// Gets or sets sharepoint ids.
        /// Returns identifiers useful for SharePoint REST compatibility. Read-only.
        /// </summary>
        [JsonPropertyName("sharepointIds")]
        public SharepointIds SharepointIds { get; set; }
    
        /// <summary>
        /// Gets or sets activities.
        /// The list of recent activities that took place on this item.
        /// </summary>
        [JsonPropertyName("activities")]
        public IListItemActivitiesCollectionPage Activities { get; set; }

        /// <summary>
        /// Gets or sets activitiesNextLink.
        /// </summary>
        [JsonPropertyName("activities@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ActivitiesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets analytics.
        /// Analytics about the view activities that took place on this item.
        /// </summary>
        [JsonPropertyName("analytics")]
        public ItemAnalytics Analytics { get; set; }
    
        /// <summary>
        /// Gets or sets document set versions.
        /// Version information for a document set version created by a user.
        /// </summary>
        [JsonPropertyName("documentSetVersions")]
        public IListItemDocumentSetVersionsCollectionPage DocumentSetVersions { get; set; }

        /// <summary>
        /// Gets or sets documentSetVersionsNextLink.
        /// </summary>
        [JsonPropertyName("documentSetVersions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string DocumentSetVersionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets drive item.
        /// For document libraries, the driveItem relationship exposes the listItem as a [driveItem][]
        /// </summary>
        [JsonPropertyName("driveItem")]
        public DriveItem DriveItem { get; set; }
    
        /// <summary>
        /// Gets or sets fields.
        /// The values of the columns set on this list item.
        /// </summary>
        [JsonPropertyName("fields")]
        public FieldValueSet Fields { get; set; }
    
        /// <summary>
        /// Gets or sets versions.
        /// The list of previous versions of the list item.
        /// </summary>
        [JsonPropertyName("versions")]
        public IListItemVersionsCollectionPage Versions { get; set; }

        /// <summary>
        /// Gets or sets versionsNextLink.
        /// </summary>
        [JsonPropertyName("versions@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string VersionsNextLink { get; set; }
    
    }
}

