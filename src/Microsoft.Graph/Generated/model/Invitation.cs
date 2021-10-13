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
        /// The email address of the user being invited. Required. The following special characters are not permitted in the email address:Tilde (~)Exclamation point (!)Number sign (#)Dollar sign ($)Percent (%)Circumflex (^)Ampersand (&amp;)Asterisk (*)Parentheses (( ))Plus sign (+)Equal sign (=)Brackets ([ ])Braces ({ })Backslash (/)Slash mark (/)Pipe (/|)Semicolon (;)Colon (:)Quotation marks (')Angle brackets (&amp;lt; &amp;gt;)Question mark (?)Comma (,)However, the following exceptions apply:A period (.) or a hyphen (-) is permitted anywhere in the user name, except at the beginning or end of the name.An underscore (_) is permitted anywhere in the user name. This includes at the beginning or end of the name.
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
        /// The userType of the user being invited. By default, this is Guest. You can invite as Member if you are a company administrator.
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
        /// The URL the user should be redirected to once the invitation is redeemed. Required.
        /// </summary>
        [JsonPropertyName("inviteRedirectUrl")]
        public string InviteRedirectUrl { get; set; }
    
        /// <summary>
        /// Gets or sets reset redemption.
        /// Reset the user's redemption status and reinvite a user while retaining their user identifier, group memberships, and app assignments. This property allows you to enable a user to sign-in using a different email address from the one in the previous invitation. For more information about using this property, see Reset redemption status for a guest user (Preview).
        /// </summary>
        [JsonPropertyName("resetRedemption")]
        public bool? ResetRedemption { get; set; }
    
        /// <summary>
        /// Gets or sets send invitation message.
        /// Indicates whether an email should be sent to the user being invited. The default is false.
        /// </summary>
        [JsonPropertyName("sendInvitationMessage")]
        public bool? SendInvitationMessage { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// The status of the invitation. Possible values are: PendingAcceptance, Completed, InProgress, and Error.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets invited user.
        /// The user created as part of the invitation creation. Read-Only
        /// </summary>
        [Obsolete("")]
        [JsonPropertyName("invitedUser")]
        public User InvitedUser { get; set; }
    
    }
}

