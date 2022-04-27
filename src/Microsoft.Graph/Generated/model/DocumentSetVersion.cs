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
    /// The type Document Set Version.
    /// </summary>
    public partial class DocumentSetVersion : ListItemVersion
    {
    
        ///<summary>
        /// The DocumentSetVersion constructor
        ///</summary>
        public DocumentSetVersion()
        {
            this.ODataType = "microsoft.graph.documentSetVersion";
        }

        /// <summary>
        /// Gets or sets comment.
        /// Comment about the captured version.
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// User who captured the version.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Date and time when this version was created.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// Items within the document set that are captured as part of this version.
        /// </summary>
        [JsonPropertyName("items")]
        public IEnumerable<DocumentSetVersionItem> Items { get; set; }
    
        /// <summary>
        /// Gets or sets should capture minor version.
        /// If true, minor versions of items are also captured; otherwise, only major versions will be captured. Default value is false.
        /// </summary>
        [JsonPropertyName("shouldCaptureMinorVersion")]
        public bool? ShouldCaptureMinorVersion { get; set; }
    
    }
}

