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
    /// The type CallStartedEventMessageDetail.
    /// </summary>
    public partial class CallStartedEventMessageDetail : EventMessageDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallStartedEventMessageDetail"/> class.
        /// </summary>
        public CallStartedEventMessageDetail()
        {
            this.ODataType = "microsoft.graph.callStartedEventMessageDetail";
        }

        /// <summary>
        /// Gets or sets callId.
        /// </summary>
        [JsonPropertyName("callId")]
        public string CallId { get; set; }
    
        /// <summary>
        /// Gets or sets initiator.
        /// </summary>
        [JsonPropertyName("initiator")]
        public IdentitySet Initiator { get; set; }
    
    }
}
