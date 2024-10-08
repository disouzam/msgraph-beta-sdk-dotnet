// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Certificate Revocation Status.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum CertificateRevocationStatus
    {
        /// <summary>Not revoked.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Revocation pending.</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Revocation command issued.</summary>
        [EnumMember(Value = "issued")]
        Issued,
        /// <summary>Revocation failed.</summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>Revoked.</summary>
        [EnumMember(Value = "revoked")]
        Revoked,
    }
}
