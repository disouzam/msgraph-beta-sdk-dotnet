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
    /// The type MacOsVppAppAssignmentSettings.
    /// </summary>
    public partial class MacOsVppAppAssignmentSettings : MobileAppAssignmentSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MacOsVppAppAssignmentSettings"/> class.
        /// </summary>
        public MacOsVppAppAssignmentSettings()
        {
            this.ODataType = "microsoft.graph.macOsVppAppAssignmentSettings";
        }

        /// <summary>
        /// Gets or sets uninstallOnDeviceRemoval.
        /// Whether or not to uninstall the app when device is removed from Intune.
        /// </summary>
        [JsonPropertyName("uninstallOnDeviceRemoval")]
        public bool? UninstallOnDeviceRemoval { get; set; }
    
        /// <summary>
        /// Gets or sets useDeviceLicensing.
        /// Whether or not to use device licensing.
        /// </summary>
        [JsonPropertyName("useDeviceLicensing")]
        public bool? UseDeviceLicensing { get; set; }
    
    }
}
