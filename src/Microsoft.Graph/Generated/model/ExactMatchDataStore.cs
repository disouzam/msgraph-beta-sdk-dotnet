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
    /// The type Exact Match Data Store.
    /// </summary>
    public partial class ExactMatchDataStore : ExactMatchDataStoreBase
    {
    
        /// <summary>
        /// Gets or sets sessions.
        /// </summary>
        [JsonPropertyName("sessions")]
        public IExactMatchDataStoreSessionsCollectionPage Sessions { get; set; }

        /// <summary>
        /// Gets or sets sessionsNextLink.
        /// </summary>
        [JsonPropertyName("sessions@odata.nextLink")]
        public string SessionsNextLink { get; set; }
    
    }
}

