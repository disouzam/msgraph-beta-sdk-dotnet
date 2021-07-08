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
    /// The type Booking Named Entity.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<BookingNamedEntity>))]
    public partial class BookingNamedEntity : Entity
    {
    
        ///<summary>
        /// The internal BookingNamedEntity constructor
        ///</summary>
        protected internal BookingNamedEntity()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name is suitable for human-readable interfaces.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
    }
}

