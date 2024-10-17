// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Supported values for the intended purpose of a user PFX certificate.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum UserPfxIntendedPurpose
    {
        /// <summary>No roles/usages assigned.</summary>
        [EnumMember(Value = "unassigned")]
        Unassigned,
        /// <summary>Valid for S/MIME encryption.</summary>
        [EnumMember(Value = "smimeEncryption")]
        SmimeEncryption,
        /// <summary>Valid for S/MIME signing.</summary>
        [EnumMember(Value = "smimeSigning")]
        SmimeSigning,
        /// <summary>Valid for use in VPN.</summary>
        [EnumMember(Value = "vpn")]
        Vpn,
        /// <summary>Valid for use in WiFi.</summary>
        [EnumMember(Value = "wifi")]
        Wifi,
    }
}
