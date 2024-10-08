// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Possible values for WIP Protection enforcement levels</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum WindowsInformationProtectionEnforcementLevel
    {
        /// <summary>No protection enforcement</summary>
        [EnumMember(Value = "noProtection")]
        NoProtection,
        /// <summary>Encrypt and Audit only</summary>
        [EnumMember(Value = "encryptAndAuditOnly")]
        EncryptAndAuditOnly,
        /// <summary>Encrypt, Audit and Prompt</summary>
        [EnumMember(Value = "encryptAuditAndPrompt")]
        EncryptAuditAndPrompt,
        /// <summary>Encrypt, Audit and Block</summary>
        [EnumMember(Value = "encryptAuditAndBlock")]
        EncryptAuditAndBlock,
    }
}
