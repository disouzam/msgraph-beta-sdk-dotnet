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
    /// The type Web Account.
    /// </summary>
    public partial class WebAccount : ItemFacet
    {
    
        ///<summary>
        /// The WebAccount constructor
        ///</summary>
        public WebAccount()
        {
            this.ODataType = "microsoft.graph.webAccount";
        }

        /// <summary>
        /// Gets or sets description.
        /// Contains the description the user has provided for the account on the service being referenced.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets service.
        /// Contains basic detail about the service that is being associated.
        /// </summary>
        [JsonPropertyName("service")]
        public ServiceInformation Service { get; set; }
    
        /// <summary>
        /// Gets or sets status message.
        /// Contains a status message from the cloud service if provided or synchronized.
        /// </summary>
        [JsonPropertyName("statusMessage")]
        public string StatusMessage { get; set; }
    
        /// <summary>
        /// Gets or sets thumbnail url.
        /// </summary>
        [JsonPropertyName("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The user name  displayed for the webaccount.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets web url.
        /// Contains a link to the user's profile on the cloud service if one exists.
        /// </summary>
        [JsonPropertyName("webUrl")]
        public string WebUrl { get; set; }
    
    }
}

