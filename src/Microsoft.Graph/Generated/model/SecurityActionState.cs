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
    /// The type SecurityActionState.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SecurityActionState>))]
    public partial class SecurityActionState
    {

        /// <summary>
        /// Gets or sets appId.
        /// The Application ID of the calling application that submitted an update (PATCH) to the action. The appId should be extracted from the auth token and not entered manually by the calling application.
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Status of the securityAction in this update. Possible values are: NotStarted, Running, Completed, Failed.
        /// </summary>
        [JsonPropertyName("status")]
        public OperationStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets updatedDateTime.
        /// Timestamp when the actionState was updated. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("updatedDateTime")]
        public DateTimeOffset? UpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets user.
        /// The user principal name of the signed-in user that submitted an update (PATCH) to the action. The user should be extracted from the auth token and not entered manually by the calling application.
        /// </summary>
        [JsonPropertyName("user")]
        public string User { get; set; }
    
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
