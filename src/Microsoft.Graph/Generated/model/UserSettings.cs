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
    /// The type User Settings.
    /// </summary>
    public partial class UserSettings : Entity
    {
    
		///<summary>
		/// The UserSettings constructor
		///</summary>
        public UserSettings()
        {
            this.ODataType = "microsoft.graph.userSettings";
        }
	
        /// <summary>
        /// Gets or sets contribution to content discovery as organization disabled.
        /// Reflects the organization level setting controlling delegate access to the trending API. When set to true, the organization doesn't have access to Office Delve. The relevancy of the content displayed in Microsoft 365, for example in Suggested sites in SharePoint Home and the Discover view in OneDrive for Business is affected for the whole organization. This setting is read-only and can only be changed by administrators in the SharePoint admin center.
        /// </summary>
        [JsonPropertyName("contributionToContentDiscoveryAsOrganizationDisabled")]
        public bool? ContributionToContentDiscoveryAsOrganizationDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets contribution to content discovery disabled.
        /// When set to true, the delegate access to the user's trending API is disabled. When set to true, documents in the user's Office Delve are disabled. When set to true, the relevancy of the content displayed in Microsoft 365, for example in Suggested sites in SharePoint Home and the Discover view in OneDrive for Business is affected. Users can control this setting in Office Delve.
        /// </summary>
        [JsonPropertyName("contributionToContentDiscoveryDisabled")]
        public bool? ContributionToContentDiscoveryDisabled { get; set; }
    
        /// <summary>
        /// Gets or sets item insights.
        /// </summary>
        [JsonPropertyName("itemInsights")]
        public UserInsightsSettings ItemInsights { get; set; }
    
        /// <summary>
        /// Gets or sets regional and language settings.
        /// The user's preferences for languages, regional locale and date/time formatting.
        /// </summary>
        [JsonPropertyName("regionalAndLanguageSettings")]
        public RegionalAndLanguageSettings RegionalAndLanguageSettings { get; set; }
    
        /// <summary>
        /// Gets or sets shift preferences.
        /// The shift preferences for the user.
        /// </summary>
        [JsonPropertyName("shiftPreferences")]
        public ShiftPreferences ShiftPreferences { get; set; }
    
    }
}

