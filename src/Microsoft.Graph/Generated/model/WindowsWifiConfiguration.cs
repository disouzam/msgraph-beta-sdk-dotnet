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
    /// The type Windows Wifi Configuration.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsWifiConfiguration>))]
    public partial class WindowsWifiConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The WindowsWifiConfiguration constructor
        ///</summary>
        public WindowsWifiConfiguration()
        {
            this.ODataType = "microsoft.graph.windowsWifiConfiguration";
        }

        /// <summary>
        /// Gets or sets connect automatically.
        /// Specify whether the wifi connection should connect automatically when in range.
        /// </summary>
        [JsonPropertyName("connectAutomatically")]
        public bool? ConnectAutomatically { get; set; }
    
        /// <summary>
        /// Gets or sets connect to preferred network.
        /// Specify whether the wifi connection should connect to more preferred networks when already connected to this one.  Requires ConnectAutomatically to be true.
        /// </summary>
        [JsonPropertyName("connectToPreferredNetwork")]
        public bool? ConnectToPreferredNetwork { get; set; }
    
        /// <summary>
        /// Gets or sets connect when network name is hidden.
        /// Specify whether the wifi connection should connect automatically even when the SSID is not broadcasting.
        /// </summary>
        [JsonPropertyName("connectWhenNetworkNameIsHidden")]
        public bool? ConnectWhenNetworkNameIsHidden { get; set; }
    
        /// <summary>
        /// Gets or sets force fipscompliance.
        /// Specify whether to force FIPS compliance.
        /// </summary>
        [JsonPropertyName("forceFIPSCompliance")]
        public bool? ForceFIPSCompliance { get; set; }
    
        /// <summary>
        /// Gets or sets metered connection limit.
        /// Specify the metered connection limit type for the wifi connection. Possible values are: unrestricted, fixed, variable.
        /// </summary>
        [JsonPropertyName("meteredConnectionLimit")]
        public MeteredConnectionLimitType? MeteredConnectionLimit { get; set; }
    
        /// <summary>
        /// Gets or sets network name.
        /// Specify the network configuration name.
        /// </summary>
        [JsonPropertyName("networkName")]
        public string NetworkName { get; set; }
    
        /// <summary>
        /// Gets or sets pre shared key.
        /// This is the pre-shared key for WPA Personal Wi-Fi network.
        /// </summary>
        [JsonPropertyName("preSharedKey")]
        public string PreSharedKey { get; set; }
    
        /// <summary>
        /// Gets or sets proxy automatic configuration url.
        /// Specify the URL for the proxy server configuration script.
        /// </summary>
        [JsonPropertyName("proxyAutomaticConfigurationUrl")]
        public string ProxyAutomaticConfigurationUrl { get; set; }
    
        /// <summary>
        /// Gets or sets proxy manual address.
        /// Specify the IP address for the proxy server.
        /// </summary>
        [JsonPropertyName("proxyManualAddress")]
        public string ProxyManualAddress { get; set; }
    
        /// <summary>
        /// Gets or sets proxy manual port.
        /// Specify the port for the proxy server.
        /// </summary>
        [JsonPropertyName("proxyManualPort")]
        public Int32? ProxyManualPort { get; set; }
    
        /// <summary>
        /// Gets or sets proxy setting.
        /// Specify the proxy setting for Wi-Fi configuration. Possible values are: none, manual, automatic.
        /// </summary>
        [JsonPropertyName("proxySetting")]
        public WiFiProxySetting? ProxySetting { get; set; }
    
        /// <summary>
        /// Gets or sets ssid.
        /// Specify the SSID of the wifi connection.
        /// </summary>
        [JsonPropertyName("ssid")]
        public string Ssid { get; set; }
    
        /// <summary>
        /// Gets or sets wifi security type.
        /// Specify the Wifi Security Type. Possible values are: open, wpaPersonal, wpaEnterprise, wep, wpa2Personal, wpa2Enterprise.
        /// </summary>
        [JsonPropertyName("wifiSecurityType")]
        public WiFiSecurityType? WifiSecurityType { get; set; }
    
    }
}

