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
    /// The type Aad User Conversation Member.
    /// </summary>
    public partial class AadUserConversationMember : ConversationMember
    {
    
		///<summary>
		/// The AadUserConversationMember constructor
		///</summary>
        public AadUserConversationMember()
        {
            this.ODataType = "microsoft.graph.aadUserConversationMember";
        }
	
        /// <summary>
        /// Gets or sets email.
        /// The email address of the user.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// TenantId which the Azure AD user belongs to.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// The guid of the user.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or sets user.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; }
    
    }
}

