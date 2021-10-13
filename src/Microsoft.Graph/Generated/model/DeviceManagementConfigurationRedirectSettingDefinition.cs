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
    /// The type Device Management Configuration Redirect Setting Definition.
    /// </summary>
    public partial class DeviceManagementConfigurationRedirectSettingDefinition : DeviceManagementConfigurationSettingDefinition
    {
    
        ///<summary>
        /// The DeviceManagementConfigurationRedirectSettingDefinition constructor
        ///</summary>
        public DeviceManagementConfigurationRedirectSettingDefinition()
        {
            this.ODataType = "microsoft.graph.deviceManagementConfigurationRedirectSettingDefinition";
        }

        /// <summary>
        /// Gets or sets deep link.
        /// A deep link that points to the specific location in the Intune console where feature support must be managed from.
        /// </summary>
        [JsonPropertyName("deepLink")]
        public string DeepLink { get; set; }
    
        /// <summary>
        /// Gets or sets redirect message.
        /// A message that explains that clicking the link will redirect the user to a supported page to manage the settings.
        /// </summary>
        [JsonPropertyName("redirectMessage")]
        public string RedirectMessage { get; set; }
    
        /// <summary>
        /// Gets or sets redirect reason.
        /// Indicates the reason for redirecting the user to an alternative location in the console.  For example: WiFi profiles are not supported in the settings catalog and must be created with a template policy.
        /// </summary>
        [JsonPropertyName("redirectReason")]
        public string RedirectReason { get; set; }
    
    }
}

