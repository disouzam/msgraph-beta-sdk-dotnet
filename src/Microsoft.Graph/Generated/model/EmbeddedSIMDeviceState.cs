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
    /// The type Embedded SIMDevice State.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EmbeddedSIMDeviceState>))]
    public partial class EmbeddedSIMDeviceState : Entity
    {
    
        /// <summary>
        /// Gets or sets created date time.
        /// The time the embedded SIM device status was created. Generated service side.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device name.
        /// Device name to which the subscription was provisioned e.g. DESKTOP-JOE
        /// </summary>
        [JsonPropertyName("deviceName")]
        public string DeviceName { get; set; }
    
        /// <summary>
        /// Gets or sets last sync date time.
        /// The time the embedded SIM device last checked in. Updated service side.
        /// </summary>
        [JsonPropertyName("lastSyncDateTime")]
        public DateTimeOffset? LastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets modified date time.
        /// The time the embedded SIM device status was last modified. Updated service side.
        /// </summary>
        [JsonPropertyName("modifiedDateTime")]
        public DateTimeOffset? ModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The state of the profile operation applied to the device. Possible values are: notEvaluated, failed, installing, installed, deleting, error, deleted, removedByUser.
        /// </summary>
        [JsonPropertyName("state")]
        public EmbeddedSIMDeviceStateValue? State { get; set; }
    
        /// <summary>
        /// Gets or sets state details.
        /// String description of the provisioning state.
        /// </summary>
        [JsonPropertyName("stateDetails")]
        public string StateDetails { get; set; }
    
        /// <summary>
        /// Gets or sets universal integrated circuit card identifier.
        /// The Universal Integrated Circuit Card Identifier (UICCID) identifying the hardware onto which a profile is to be deployed.
        /// </summary>
        [JsonPropertyName("universalIntegratedCircuitCardIdentifier")]
        public string UniversalIntegratedCircuitCardIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets user name.
        /// Username which the subscription was provisioned to e.g. joe@contoso.com
        /// </summary>
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    
    }
}

