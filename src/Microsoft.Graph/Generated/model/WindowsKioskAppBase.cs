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
    /// The type WindowsKioskAppBase.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsKioskAppBase>))]
    public abstract partial class WindowsKioskAppBase
    {

        /// <summary>
        /// Gets or sets appType.
        /// The app type. Possible values are: unknown, store, desktop, aumId.
        /// </summary>
        [JsonPropertyName("appType")]
        public WindowsKioskAppType? AppType { get; set; }
    
        /// <summary>
        /// Gets or sets autoLaunch.
        /// Allow the app to be auto-launched in multi-app kiosk mode
        /// </summary>
        [JsonPropertyName("autoLaunch")]
        public bool? AutoLaunch { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Represents the friendly name of an app
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets startLayoutTileSize.
        /// The app tile size for the start layout. Possible values are: hidden, small, medium, wide, large.
        /// </summary>
        [JsonPropertyName("startLayoutTileSize")]
        public WindowsAppStartLayoutTileSize? StartLayoutTileSize { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
