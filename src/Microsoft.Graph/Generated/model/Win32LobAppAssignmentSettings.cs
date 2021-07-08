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
    /// The type Win32LobAppAssignmentSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Win32LobAppAssignmentSettings>))]
    public partial class Win32LobAppAssignmentSettings : MobileAppAssignmentSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppAssignmentSettings"/> class.
        /// </summary>
        public Win32LobAppAssignmentSettings()
        {
            this.ODataType = "microsoft.graph.win32LobAppAssignmentSettings";
        }

        /// <summary>
        /// Gets or sets deliveryOptimizationPriority.
        /// The delivery optimization priority for this app assignment. This setting is not supported in National Cloud environments. Possible values are: notConfigured, foreground.
        /// </summary>
        [JsonPropertyName("deliveryOptimizationPriority")]
        public Win32LobAppDeliveryOptimizationPriority? DeliveryOptimizationPriority { get; set; }
    
        /// <summary>
        /// Gets or sets installTimeSettings.
        /// The install time settings to apply for this app assignment.
        /// </summary>
        [JsonPropertyName("installTimeSettings")]
        public MobileAppInstallTimeSettings InstallTimeSettings { get; set; }
    
        /// <summary>
        /// Gets or sets notifications.
        /// The notification status for this app assignment. Possible values are: showAll, showReboot, hideAll.
        /// </summary>
        [JsonPropertyName("notifications")]
        public Win32LobAppNotification? Notifications { get; set; }
    
        /// <summary>
        /// Gets or sets restartSettings.
        /// The reboot settings to apply for this app assignment.
        /// </summary>
        [JsonPropertyName("restartSettings")]
        public Win32LobAppRestartSettings RestartSettings { get; set; }
    
    }
}
