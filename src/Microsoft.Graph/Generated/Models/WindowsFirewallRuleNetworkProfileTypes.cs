// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Flags representing which network profile types apply to a firewall rule.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    [Flags]
    public enum WindowsFirewallRuleNetworkProfileTypes
    {
        /// <summary>No flags set.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured = 1,
        /// <summary>The profile for networks that are connected to domains.</summary>
        [EnumMember(Value = "domain")]
        Domain = 2,
        /// <summary>The profile for private networks.</summary>
        [EnumMember(Value = "private")]
        Private = 4,
        /// <summary>The profile for public networks.</summary>
        [EnumMember(Value = "public")]
        Public = 8,
    }
}
