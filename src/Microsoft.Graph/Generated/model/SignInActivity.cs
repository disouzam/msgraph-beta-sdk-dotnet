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
    /// The type SignInActivity.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SignInActivity>))]
    public partial class SignInActivity
    {

        /// <summary>
        /// Gets or sets lastSignInDateTime.
        /// The last interactive sign-in date for a specific user. You can use this field to calculate the last time a user signed in to the directory with an interactive authentication method. This field can be used to build reports, such as inactive users. The timestamp represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is: '2014-01-01T00:00:00Z'. For more information about using the value of this property, see Manage inactive user accounts in Azure AD.
        /// </summary>
        [JsonPropertyName("lastSignInDateTime")]
        public DateTimeOffset? LastSignInDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets lastSignInRequestId.
        /// Request ID of the last sign-in performed by this user.
        /// </summary>
        [JsonPropertyName("lastSignInRequestId")]
        public string LastSignInRequestId { get; set; }
    
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
