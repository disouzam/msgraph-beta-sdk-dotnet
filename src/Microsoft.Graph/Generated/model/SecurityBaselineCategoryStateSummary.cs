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
    /// The type Security Baseline Category State Summary.
    /// </summary>
    public partial class SecurityBaselineCategoryStateSummary : SecurityBaselineStateSummary
    {
    
        ///<summary>
        /// The SecurityBaselineCategoryStateSummary constructor
        ///</summary>
        public SecurityBaselineCategoryStateSummary()
        {
            this.ODataType = "microsoft.graph.securityBaselineCategoryStateSummary";
        }

        /// <summary>
        /// Gets or sets display name.
        /// The category name
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
    }
}

