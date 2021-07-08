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
    /// The type Risky User.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<RiskyUser>))]
    public partial class RiskyUser : Entity
    {
    
        /// <summary>
        /// Gets or sets is deleted.
        /// Indicates whether the user is deleted. Possible values are: true, false.
        /// </summary>
        [JsonPropertyName("isDeleted")]
        public bool? IsDeleted { get; set; }
    
        /// <summary>
        /// Gets or sets is processing.
        /// Indicates whether a user's risky state is being processed by the backend.
        /// </summary>
        [JsonPropertyName("isProcessing")]
        public bool? IsProcessing { get; set; }
    
        /// <summary>
        /// Gets or sets risk detail.
        /// The possible values are none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("riskDetail")]
        public RiskDetail? RiskDetail { get; set; }
    
        /// <summary>
        /// Gets or sets risk last updated date time.
        /// The date and time that the risky user was last updated.  The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: 2014-01-01T00:00:00Z
        /// </summary>
        [JsonPropertyName("riskLastUpdatedDateTime")]
        public DateTimeOffset? RiskLastUpdatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets risk level.
        /// Level of the detected risky user. The possible values are low, medium, high, hidden, none, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("riskLevel")]
        public RiskLevel? RiskLevel { get; set; }
    
        /// <summary>
        /// Gets or sets risk state.
        /// State of the user's risk. Possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("riskState")]
        public RiskState? RiskState { get; set; }
    
        /// <summary>
        /// Gets or sets user display name.
        /// Risky user display name.
        /// </summary>
        [JsonPropertyName("userDisplayName")]
        public string UserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// Risky user principal name.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets history.
        /// The activity related to user risk level change
        /// </summary>
        [JsonPropertyName("history")]
        public IRiskyUserHistoryCollectionPage History { get; set; }

        /// <summary>
        /// Gets or sets historyNextLink.
        /// </summary>
        [JsonPropertyName("history@odata.nextLink")]
        public string HistoryNextLink { get; set; }
    
    }
}

