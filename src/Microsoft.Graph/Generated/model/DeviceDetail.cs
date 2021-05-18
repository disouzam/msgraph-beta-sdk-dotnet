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
    /// The type DeviceDetail.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceDetail>))]
    public partial class DeviceDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceDetail"/> class.
        /// </summary>
        public DeviceDetail()
        {
            this.ODataType = "microsoft.graph.deviceDetail";
        }

        /// <summary>
        /// Gets or sets browser.
        /// Indicates the browser information of the used for signing-in.
        /// </summary>
        [JsonPropertyName("browser")]
        public string Browser { get; set; }
    
        /// <summary>
        /// Gets or sets browserId.
        /// </summary>
        [JsonPropertyName("browserId")]
        public string BrowserId { get; set; }
    
        /// <summary>
        /// Gets or sets deviceId.
        /// Refers to the UniqueID of the device used for signing-in.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// Refers to the name of the device used for signing-in.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets isCompliant.
        /// Indicates whether the device is compliant or not.
        /// </summary>
        [JsonPropertyName("isCompliant")]
        public bool? IsCompliant { get; set; }
    
        /// <summary>
        /// Gets or sets isManaged.
        /// Indicates if the device is managed or not.
        /// </summary>
        [JsonPropertyName("isManaged")]
        public bool? IsManaged { get; set; }
    
        /// <summary>
        /// Gets or sets operatingSystem.
        /// Indicates the OS name and version used for signing-in.
        /// </summary>
        [JsonPropertyName("operatingSystem")]
        public string OperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets trustType.
        /// Indicates information on whether the signed-in device is Workplace Joined, AzureAD Joined, Domain Joined.
        /// </summary>
        [JsonPropertyName("trustType")]
        public string TrustType { get; set; }
    
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
