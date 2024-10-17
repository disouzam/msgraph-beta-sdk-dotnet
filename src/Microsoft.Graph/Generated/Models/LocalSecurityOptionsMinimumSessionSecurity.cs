// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Possible values for LocalSecurityOptionsMinimumSessionSecurity</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum LocalSecurityOptionsMinimumSessionSecurity
    {
        /// <summary>Send LM &amp; NTLM responses</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Send LM &amp; NTLM-use NTLMv2 session security if negotiated</summary>
        [EnumMember(Value = "requireNtmlV2SessionSecurity")]
        RequireNtmlV2SessionSecurity,
        /// <summary>Send LM &amp; NTLM responses only</summary>
        [EnumMember(Value = "require128BitEncryption")]
        Require128BitEncryption,
        /// <summary>Send LM &amp; NTLMv2 responses only</summary>
        [EnumMember(Value = "ntlmV2And128BitEncryption")]
        NtlmV2And128BitEncryption,
    }
}
