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
    /// The type Booking Person.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<BookingPerson>))]
    public partial class BookingPerson : BookingNamedEntity
    {
    
        ///<summary>
        /// The BookingPerson constructor
        ///</summary>
        public BookingPerson()
        {
            this.ODataType = "microsoft.graph.bookingPerson";
        }

        /// <summary>
        /// Gets or sets email address.
        /// The email address of the person.
        /// </summary>
        [JsonPropertyName("emailAddress")]
        public string EmailAddress { get; set; }
    
    }
}

