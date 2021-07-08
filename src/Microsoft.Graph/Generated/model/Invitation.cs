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
    /// The type Invitation.
    /// </summary>
    public partial class Invitation : Entity
    {
    
        /// <summary>
        /// Gets or sets invited user display name.
        /// The display name of the user being invited.
        /// </summary>
        [JsonPropertyName("invitedUserDisplayName")]
        public string InvitedUserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets invited user email address.
        /// The email address of the user being invited. Required. The following special characters are not permitted in the email address:Tilde (~)Exclamation point (!)At sign (@)Number sign (#)Dollar sign ($)Percent (%)Circumflex (^)Ampersand (&amp;)Asterisk (*)Parentheses (( ))Hyphen (-)Plus sign (+)Equal sign (=)Brackets ([ ])Braces ({ })Backslash (/)Slash mark (/)Pipe (`
        /// </summary>
        [JsonPropertyName("invitedUserEmailAddress")]
        public string InvitedUserEmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets invited user message info.
        /// Additional configuration for the message being sent to the invited user, including customizing message text, language and cc recipient list.
        /// </summary>
        [JsonPropertyName("invitedUserMessageInfo")]
        public InvitedUserMessageInfo InvitedUserMessageInfo { get; set; }
    
        /// <summary>
        /// Gets or sets invited user type.
        /// The userType of the user being invited. By default, this is Guest. You can invite as Member if you're are company administrator.
        /// </summary>
        [JsonPropertyName("invitedUserType")]
        public string InvitedUserType { get; set; }
    
        /// <summary>
        /// Gets or sets invite redeem url.
        /// The URL the user can use to redeem their invitation. Read-only.
        /// </summary>
        [JsonPropertyName("inviteRedeemUrl")]
        public string InviteRedeemUrl { get; set; }
    
        /// <summary>
        /// Gets or sets invite redirect url.
        /// The URL user should be redirected to once the invitation is redeemed. Required.
        /// </summary>
        [JsonPropertyName("inviteRedirectUrl")]
        public string InviteRedirectUrl { get; set; }
    
        /// <summary>
        /// Gets or sets reset redemption.
        /// </summary>
        [JsonPropertyName("resetRedemption")]
        public bool? ResetRedemption { get; set; }
    
        /// <summary>
        /// Gets or sets send invitation message.
        /// Indicates whether an email should be sent to the user being invited or not. The default is false.
        /// </summary>
        [JsonPropertyName("sendInvitationMessage")]
        public bool? SendInvitationMessage { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the invitation. Possible values: PendingAcceptance, Completed, InProgress, and Error
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets invited user.
        /// The user created as part of the invitation creation. Read-Only
        /// </summary>
        [JsonPropertyName("invitedUser")]
        public User InvitedUser { get; set; }
    
    }
}

