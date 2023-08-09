// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates the type of app that a VPN traffic rule is associated with.</summary>
    public enum VpnTrafficRuleAppType {
        /// <summary>The traffic rule is not associated with an app.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>The traffic rule is associated with a desktop app.</summary>
        [EnumMember(Value = "desktop")]
        Desktop,
        /// <summary>The traffic rule is associated with a Universal app.</summary>
        [EnumMember(Value = "universal")]
        Universal,
    }
}
