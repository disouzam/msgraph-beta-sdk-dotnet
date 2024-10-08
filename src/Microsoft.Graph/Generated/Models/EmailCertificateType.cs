// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Supported certificate sources for email signing and encryption.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum EmailCertificateType
    {
        /// <summary>Do not use a certificate as a source.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Use an certificate for certificate source.</summary>
        [EnumMember(Value = "certificate")]
        Certificate,
        /// <summary>Use a derived credential for certificate source.</summary>
        [EnumMember(Value = "derivedCredential")]
        DerivedCredential,
    }
}
