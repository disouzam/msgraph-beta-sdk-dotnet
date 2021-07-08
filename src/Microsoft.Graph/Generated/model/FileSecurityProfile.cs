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
    /// The type File Security Profile.
    /// </summary>
    public partial class FileSecurityProfile : Entity
    {
    
        /// <summary>
        /// Gets or sets activity group names.
        /// </summary>
        [JsonPropertyName("activityGroupNames")]
        public IEnumerable<string> ActivityGroupNames { get; set; }
    
        /// <summary>
        /// Gets or sets azure subscription id.
        /// </summary>
        [JsonPropertyName("azureSubscriptionId")]
        public string AzureSubscriptionId { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// </summary>
        [JsonPropertyName("azureTenantId")]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets certificate thumbprint.
        /// </summary>
        [JsonPropertyName("certificateThumbprint")]
        public string CertificateThumbprint { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// </summary>
        [JsonPropertyName("extensions")]
        public IEnumerable<string> Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets file type.
        /// </summary>
        [JsonPropertyName("fileType")]
        public string FileType { get; set; }
    
        /// <summary>
        /// Gets or sets first seen date time.
        /// </summary>
        [JsonPropertyName("firstSeenDateTime")]
        public DateTimeOffset? FirstSeenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets hashes.
        /// </summary>
        [JsonPropertyName("hashes")]
        public IEnumerable<FileHash> Hashes { get; set; }
    
        /// <summary>
        /// Gets or sets last seen date time.
        /// </summary>
        [JsonPropertyName("lastSeenDateTime")]
        public DateTimeOffset? LastSeenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets malware states.
        /// </summary>
        [JsonPropertyName("malwareStates")]
        public IEnumerable<MalwareState> MalwareStates { get; set; }
    
        /// <summary>
        /// Gets or sets names.
        /// </summary>
        [JsonPropertyName("names")]
        public IEnumerable<string> Names { get; set; }
    
        /// <summary>
        /// Gets or sets risk score.
        /// </summary>
        [JsonPropertyName("riskScore")]
        public string RiskScore { get; set; }
    
        /// <summary>
        /// Gets or sets size.
        /// </summary>
        [JsonPropertyName("size")]
        public Int64? Size { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets vendor information.
        /// </summary>
        [JsonPropertyName("vendorInformation")]
        public SecurityVendorInformation VendorInformation { get; set; }
    
        /// <summary>
        /// Gets or sets vulnerability states.
        /// </summary>
        [JsonPropertyName("vulnerabilityStates")]
        public IEnumerable<VulnerabilityState> VulnerabilityStates { get; set; }
    
    }
}

