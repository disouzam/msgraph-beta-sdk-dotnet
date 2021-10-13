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
    /// The type Cloud Pc Gallery Image.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<CloudPcGalleryImage>))]
    public partial class CloudPcGalleryImage : Entity
    {
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets end date.
        /// </summary>
        [JsonPropertyName("endDate")]
        public Date EndDate { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date.
        /// </summary>
        [JsonPropertyName("expirationDate")]
        public Date ExpirationDate { get; set; }
    
        /// <summary>
        /// Gets or sets offer.
        /// </summary>
        [JsonPropertyName("offer")]
        public string Offer { get; set; }
    
        /// <summary>
        /// Gets or sets offer display name.
        /// </summary>
        [JsonPropertyName("offerDisplayName")]
        public string OfferDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets publisher.
        /// </summary>
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }
    
        /// <summary>
        /// Gets or sets recommended sku.
        /// </summary>
        [JsonPropertyName("recommendedSku")]
        public string RecommendedSku { get; set; }
    
        /// <summary>
        /// Gets or sets size in gb.
        /// </summary>
        [JsonPropertyName("sizeInGB")]
        public Int32? SizeInGB { get; set; }
    
        /// <summary>
        /// Gets or sets sku.
        /// </summary>
        [JsonPropertyName("sku")]
        public string Sku { get; set; }
    
        /// <summary>
        /// Gets or sets sku display name.
        /// </summary>
        [JsonPropertyName("skuDisplayName")]
        public string SkuDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets start date.
        /// </summary>
        [JsonPropertyName("startDate")]
        public Date StartDate { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// </summary>
        [JsonPropertyName("status")]
        public CloudPcGalleryImageStatus? Status { get; set; }
    
    }
}

