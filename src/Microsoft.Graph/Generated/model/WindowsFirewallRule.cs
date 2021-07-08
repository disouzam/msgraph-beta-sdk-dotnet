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
    /// The type WindowsFirewallRule.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<WindowsFirewallRule>))]
    public partial class WindowsFirewallRule
    {

        /// <summary>
        /// Gets or sets action.
        /// The action the rule enforces. If not specified, the default is Allowed. Possible values are: notConfigured, blocked, allowed.
        /// </summary>
        [JsonPropertyName("action")]
        public StateManagementSetting? Action { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// The description of the rule.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// The display name of the rule. Does not need to be unique.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets edgeTraversal.
        /// Indicates whether edge traversal is enabled or disabled for this rule. The EdgeTraversal setting indicates that specific inbound traffic is allowed to tunnel through NATs and other edge devices using the Teredo tunneling technology. In order for this setting to work correctly, the application or service with the inbound firewall rule needs to support IPv6. The primary application of this setting allows listeners on the host to be globally addressable through a Teredo IPv6 address. New rules have the EdgeTraversal property disabled by default. Possible values are: notConfigured, blocked, allowed.
        /// </summary>
        [JsonPropertyName("edgeTraversal")]
        public StateManagementSetting? EdgeTraversal { get; set; }
    
        /// <summary>
        /// Gets or sets filePath.
        /// The full file path of an app that's affected by the firewall rule.
        /// </summary>
        [JsonPropertyName("filePath")]
        public string FilePath { get; set; }
    
        /// <summary>
        /// Gets or sets interfaceTypes.
        /// The interface types of the rule. Possible values are: notConfigured, remoteAccess, wireless, lan.
        /// </summary>
        [JsonPropertyName("interfaceTypes")]
        public WindowsFirewallRuleInterfaceTypes? InterfaceTypes { get; set; }
    
        /// <summary>
        /// Gets or sets localAddressRanges.
        /// List of local addresses covered by the rule. Default is any address. Valid tokens include:'' indicates any local address. If present, this must be the only token included.A subnet can be specified using either the subnet mask or network prefix notation. If neither a subnet mask nor a network prefix is specified, the subnet mask defaults to 255.255.255.255.A valid IPv6 address.An IPv4 address range in the format of 'start address - end address' with no spaces included.An IPv6 address range in the format of 'start address - end address' with no spaces included.
        /// </summary>
        [JsonPropertyName("localAddressRanges")]
        public IEnumerable<string> LocalAddressRanges { get; set; }
    
        /// <summary>
        /// Gets or sets localPortRanges.
        /// List of local port ranges. For example, '100-120', '200', '300-320'. If not specified, the default is All.
        /// </summary>
        [JsonPropertyName("localPortRanges")]
        public IEnumerable<string> LocalPortRanges { get; set; }
    
        /// <summary>
        /// Gets or sets localUserAuthorizations.
        /// Specifies the list of authorized local users for the app container. This is a string in Security Descriptor Definition Language (SDDL) format.
        /// </summary>
        [JsonPropertyName("localUserAuthorizations")]
        public string LocalUserAuthorizations { get; set; }
    
        /// <summary>
        /// Gets or sets packageFamilyName.
        /// The package family name of a Microsoft Store application that's affected by the firewall rule.
        /// </summary>
        [JsonPropertyName("packageFamilyName")]
        public string PackageFamilyName { get; set; }
    
        /// <summary>
        /// Gets or sets profileTypes.
        /// Specifies the profiles to which the rule belongs. If not specified, the default is All. Possible values are: notConfigured, domain, private, public.
        /// </summary>
        [JsonPropertyName("profileTypes")]
        public WindowsFirewallRuleNetworkProfileTypes? ProfileTypes { get; set; }
    
        /// <summary>
        /// Gets or sets protocol.
        /// 0-255 number representing the IP protocol (TCP = 6, UDP = 17). If not specified, the default is All. Valid values 0 to 255
        /// </summary>
        [JsonPropertyName("protocol")]
        public Int32? Protocol { get; set; }
    
        /// <summary>
        /// Gets or sets remoteAddressRanges.
        /// List of tokens specifying the remote addresses covered by the rule. Tokens are case insensitive. Default is any address. Valid tokens include:'' indicates any remote address. If present, this must be the only token included.'Defaultgateway''DHCP''DNS''WINS''Intranet' (supported on Windows versions 1809+)'RmtIntranet' (supported on Windows versions 1809+)'Internet' (supported on Windows versions 1809+)'Ply2Renders' (supported on Windows versions 1809+)'LocalSubnet' indicates any local address on the local subnet.A subnet can be specified using either the subnet mask or network prefix notation. If neither a subnet mask nor a network prefix is specified, the subnet mask defaults to 255.255.255.255.A valid IPv6 address.An IPv4 address range in the format of 'start address - end address' with no spaces included.An IPv6 address range in the format of 'start address - end address' with no spaces included.
        /// </summary>
        [JsonPropertyName("remoteAddressRanges")]
        public IEnumerable<string> RemoteAddressRanges { get; set; }
    
        /// <summary>
        /// Gets or sets remotePortRanges.
        /// List of remote port ranges. For example, '100-120', '200', '300-320'. If not specified, the default is All.
        /// </summary>
        [JsonPropertyName("remotePortRanges")]
        public IEnumerable<string> RemotePortRanges { get; set; }
    
        /// <summary>
        /// Gets or sets serviceName.
        /// The name used in cases when a service, not an application, is sending or receiving traffic.
        /// </summary>
        [JsonPropertyName("serviceName")]
        public string ServiceName { get; set; }
    
        /// <summary>
        /// Gets or sets trafficDirection.
        /// The traffic direction that the rule is enabled for. If not specified, the default is Out. Possible values are: notConfigured, out, in.
        /// </summary>
        [JsonPropertyName("trafficDirection")]
        public WindowsFirewallRuleTrafficDirectionType? TrafficDirection { get; set; }
    
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
