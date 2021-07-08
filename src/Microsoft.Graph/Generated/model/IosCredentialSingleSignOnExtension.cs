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
    /// The type IosCredentialSingleSignOnExtension.
    /// </summary>
    public partial class IosCredentialSingleSignOnExtension : IosSingleSignOnExtension
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosCredentialSingleSignOnExtension"/> class.
        /// </summary>
        public IosCredentialSingleSignOnExtension()
        {
            this.ODataType = "microsoft.graph.iosCredentialSingleSignOnExtension";
        }

        /// <summary>
        /// Gets or sets configurations.
        /// Gets or sets a list of typed key-value pairs used to configure Credential-type profiles. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonPropertyName("configurations")]
        public IEnumerable<KeyTypedValuePair> Configurations { get; set; }
    
        /// <summary>
        /// Gets or sets domains.
        /// Gets or sets a list of hosts or domain names for which the app extension performs SSO.
        /// </summary>
        [JsonPropertyName("domains")]
        public IEnumerable<string> Domains { get; set; }
    
        /// <summary>
        /// Gets or sets extensionIdentifier.
        /// Gets or sets the bundle ID of the app extension that performs SSO for the specified URLs.
        /// </summary>
        [JsonPropertyName("extensionIdentifier")]
        public string ExtensionIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets realm.
        /// Gets or sets the case-sensitive realm name for this profile.
        /// </summary>
        [JsonPropertyName("realm")]
        public string Realm { get; set; }
    
        /// <summary>
        /// Gets or sets teamIdentifier.
        /// Gets or sets the team ID of the app extension that performs SSO for the specified URLs.
        /// </summary>
        [JsonPropertyName("teamIdentifier")]
        public string TeamIdentifier { get; set; }
    
    }
}
