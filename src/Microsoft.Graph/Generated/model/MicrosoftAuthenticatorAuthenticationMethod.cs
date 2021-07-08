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
    /// The type Microsoft Authenticator Authentication Method.
    /// </summary>
    [Obsolete("")]
    public partial class MicrosoftAuthenticatorAuthenticationMethod : AuthenticationMethod
    {
    
        ///<summary>
        /// The MicrosoftAuthenticatorAuthenticationMethod constructor
        ///</summary>
        public MicrosoftAuthenticatorAuthenticationMethod()
        {
            this.ODataType = "microsoft.graph.microsoftAuthenticatorAuthenticationMethod";
        }

        /// <summary>
        /// Gets or sets created date time.
        /// The date and time that this app was registered. This property is null if the device is not registered for passwordless Phone Sign-In.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets device tag.
        /// Tags containing app metadata.
        /// </summary>
        [JsonPropertyName("deviceTag")]
        public string DeviceTag { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the device on which this app is registered.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets phone app version.
        /// Numerical version of this instance of the Authenticator app.
        /// </summary>
        [JsonPropertyName("phoneAppVersion")]
        public string PhoneAppVersion { get; set; }
    
        /// <summary>
        /// Gets or sets device.
        /// The registered device on which Microsoft Authenticator resides. This property is null if the device is not registered for passwordless Phone Sign-In.
        /// </summary>
        [JsonPropertyName("device")]
        public Device Device { get; set; }
    
    }
}

