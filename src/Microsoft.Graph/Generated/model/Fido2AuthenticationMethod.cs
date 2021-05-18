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
    /// The type Fido2Authentication Method.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Fido2AuthenticationMethod>))]
    public partial class Fido2AuthenticationMethod : AuthenticationMethod
    {
    
		///<summary>
		/// The Fido2AuthenticationMethod constructor
		///</summary>
        public Fido2AuthenticationMethod()
        {
            this.ODataType = "microsoft.graph.fido2AuthenticationMethod";
        }
	
        /// <summary>
        /// Gets or sets aa guid.
        /// Authenticator Attestation GUID, an identifier that indicates the type (e.g. make and model) of the authenticator.
        /// </summary>
        [JsonPropertyName("aaGuid")]
        public string AaGuid { get; set; }
    
        /// <summary>
        /// Gets or sets attestation certificates.
        /// The attestation certificate(s) attached to this security key.
        /// </summary>
        [JsonPropertyName("attestationCertificates")]
        public IEnumerable<string> AttestationCertificates { get; set; }
    
        /// <summary>
        /// Gets or sets attestation level.
        /// The attestation level of this FIDO2 security key. Possible values are: attested, notAttested, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("attestationLevel")]
        public AttestationLevel? AttestationLevel { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The timestamp when this key was registered to the user.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets creation date time.
        /// </summary>
        [Obsolete("The creationDateTime property is deprecated and will stop returning data on December 31, 2020. Please use the createdDateTime property.")]
        [JsonPropertyName("creationDateTime")]
        public DateTimeOffset? CreationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name of the key as given by the user.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets model.
        /// The manufacturer-assigned model of the FIDO2 security key.
        /// </summary>
        [JsonPropertyName("model")]
        public string Model { get; set; }
    
    }
}

