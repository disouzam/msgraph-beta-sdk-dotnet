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
    /// The type Office365Active User Counts.
    /// </summary>
    public partial class Office365ActiveUserCounts : Entity
    {
    
        /// <summary>
        /// Gets or sets exchange.
        /// The number of active users in Exchange. Any user who can read and send email is considered an active user.
        /// </summary>
        [JsonPropertyName("exchange")]
        public Int64? Exchange { get; set; }
    
        /// <summary>
        /// Gets or sets office365.
        /// The number of active users in Microsoft 365. This number includes all the active users in Exchange, OneDrive, SharePoint, Skype For Business, Yammer, and Microsoft Teams. You can find the definition of active user for each product in the respective property description.
        /// </summary>
        [JsonPropertyName("office365")]
        public Int64? Office365 { get; set; }
    
        /// <summary>
        /// Gets or sets one drive.
        /// The number of active users in OneDrive. Any user who viewed or edited files, shared files internally or externally, or synced files is considered an active user.
        /// </summary>
        [JsonPropertyName("oneDrive")]
        public Int64? OneDrive { get; set; }
    
        /// <summary>
        /// Gets or sets report date.
        /// The date on which a number of users were active.
        /// </summary>
        [JsonPropertyName("reportDate")]
        public Date ReportDate { get; set; }
    
        /// <summary>
        /// Gets or sets report period.
        /// The number of days the report covers.
        /// </summary>
        [JsonPropertyName("reportPeriod")]
        public string ReportPeriod { get; set; }
    
        /// <summary>
        /// Gets or sets report refresh date.
        /// The latest date of the content.
        /// </summary>
        [JsonPropertyName("reportRefreshDate")]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets share point.
        /// The number of active users in SharePoint. Any user who viewed or edited files, shared files internally or externally, synced files, or viewed SharePoint pages is considered an active user.
        /// </summary>
        [JsonPropertyName("sharePoint")]
        public Int64? SharePoint { get; set; }
    
        /// <summary>
        /// Gets or sets skype for business.
        /// The number of active users in Skype For Business. Any user who organized or participated in conferences, or joined peer-to-peer sessions is considered an active user.
        /// </summary>
        [JsonPropertyName("skypeForBusiness")]
        public Int64? SkypeForBusiness { get; set; }
    
        /// <summary>
        /// Gets or sets teams.
        /// The number of active users in Microsoft Teams. Any user who posted messages in team channels, sent messages in private chat sessions, or participated in meetings or calls is considered an active user.
        /// </summary>
        [JsonPropertyName("teams")]
        public Int64? Teams { get; set; }
    
        /// <summary>
        /// Gets or sets yammer.
        /// The number of active users in Yammer. Any user who can post, read, or like messages is considered an active user.
        /// </summary>
        [JsonPropertyName("yammer")]
        public Int64? Yammer { get; set; }
    
    }
}

