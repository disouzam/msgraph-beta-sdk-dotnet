// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AuthenticationMethodsRegistrationCampaignIncludeTarget.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AuthenticationMethodsRegistrationCampaignIncludeTarget>))]
    public partial class AuthenticationMethodsRegistrationCampaignIncludeTarget
    {

        /// <summary>
        /// Gets or sets id.
        /// The object identifier of an Azure AD user or group.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or sets targetedAuthenticationMethod.
        /// The authentication method that the user is prompted to register. The value must be microsoftAuthenticator.
        /// </summary>
        [JsonPropertyName("targetedAuthenticationMethod")]
        public string TargetedAuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets targetType.
        /// The type of the authentication method target. Possible values are: user, group, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("targetType")]
        public AuthenticationMethodTargetType? TargetType { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
