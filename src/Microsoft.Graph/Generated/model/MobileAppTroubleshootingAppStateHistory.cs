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
    /// The type MobileAppTroubleshootingAppStateHistory.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<MobileAppTroubleshootingAppStateHistory>))]
    public partial class MobileAppTroubleshootingAppStateHistory : MobileAppTroubleshootingHistoryItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MobileAppTroubleshootingAppStateHistory"/> class.
        /// </summary>
        public MobileAppTroubleshootingAppStateHistory()
        {
            this.ODataType = "microsoft.graph.mobileAppTroubleshootingAppStateHistory";
        }

        /// <summary>
        /// Gets or sets actionType.
        /// Action type for Intune Application. Possible values are: unknown, installCommandSent, installed, uninstalled, userRequestedInstall.
        /// </summary>
        [JsonPropertyName("actionType")]
        public MobileAppActionType? ActionType { get; set; }
    
        /// <summary>
        /// Gets or sets errorCode.
        /// Error code for the failure, empty if no failure.
        /// </summary>
        [JsonPropertyName("errorCode")]
        public string ErrorCode { get; set; }
    
        /// <summary>
        /// Gets or sets runState.
        /// Status of the item. Possible values are: unknown, success, fail, scriptError, pending, notApplicable.
        /// </summary>
        [JsonPropertyName("runState")]
        public RunState? RunState { get; set; }
    
    }
}
