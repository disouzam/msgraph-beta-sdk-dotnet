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
    /// The type TranslationLanguageOverride.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TranslationLanguageOverride>))]
    public partial class TranslationLanguageOverride
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslationLanguageOverride"/> class.
        /// </summary>
        public TranslationLanguageOverride()
        {
            this.ODataType = "microsoft.graph.translationLanguageOverride";
        }

        /// <summary>
        /// Gets or sets languageTag.
        /// The language to apply the override.Returned by default. Not nullable.
        /// </summary>
        [JsonPropertyName("languageTag")]
        public string LanguageTag { get; set; }
    
        /// <summary>
        /// Gets or sets translationBehavior.
        /// The translation override behavior for the language, if any.Returned by default. Not nullable.
        /// </summary>
        [JsonPropertyName("translationBehavior")]
        public TranslationBehavior? TranslationBehavior { get; set; }
    
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
