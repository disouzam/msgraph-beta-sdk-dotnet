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
    /// The type Win32LobAppRegistryDetection.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Win32LobAppRegistryDetection>))]
    public partial class Win32LobAppRegistryDetection : Win32LobAppDetection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppRegistryDetection"/> class.
        /// </summary>
        public Win32LobAppRegistryDetection()
        {
            this.ODataType = "microsoft.graph.win32LobAppRegistryDetection";
        }

        /// <summary>
        /// Gets or sets check32BitOn64System.
        /// A value indicating whether this registry path is for checking 32-bit app on 64-bit system
        /// </summary>
        [JsonPropertyName("check32BitOn64System")]
        public bool? Check32BitOn64System { get; set; }
    
        /// <summary>
        /// Gets or sets detectionType.
        /// The registry data detection type. Possible values are: notConfigured, exists, doesNotExist, string, integer, version.
        /// </summary>
        [JsonPropertyName("detectionType")]
        public Win32LobAppRegistryDetectionType? DetectionType { get; set; }
    
        /// <summary>
        /// Gets or sets detectionValue.
        /// The registry detection value
        /// </summary>
        [JsonPropertyName("detectionValue")]
        public string DetectionValue { get; set; }
    
        /// <summary>
        /// Gets or sets keyPath.
        /// The registry key path to detect Win32 Line of Business (LoB) app
        /// </summary>
        [JsonPropertyName("keyPath")]
        public string KeyPath { get; set; }
    
        /// <summary>
        /// Gets or sets operator.
        /// The operator for registry data detection. Possible values are: notConfigured, equal, notEqual, greaterThan, greaterThanOrEqual, lessThan, lessThanOrEqual.
        /// </summary>
        [JsonPropertyName("operator")]
        public Win32LobAppDetectionOperator? Operator { get; set; }
    
        /// <summary>
        /// Gets or sets valueName.
        /// The registry value name
        /// </summary>
        [JsonPropertyName("valueName")]
        public string ValueName { get; set; }
    
    }
}
