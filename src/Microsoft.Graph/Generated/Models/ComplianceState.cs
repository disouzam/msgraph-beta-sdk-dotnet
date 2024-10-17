// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Compliance state.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ComplianceState
    {
        /// <summary>Unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Compliant.</summary>
        [EnumMember(Value = "compliant")]
        Compliant,
        /// <summary>Device is non-compliant and is blocked from corporate resources.</summary>
        [EnumMember(Value = "noncompliant")]
        Noncompliant,
        /// <summary>Conflict with other rules.</summary>
        [EnumMember(Value = "conflict")]
        Conflict,
        /// <summary>Error.</summary>
        [EnumMember(Value = "error")]
        Error,
        /// <summary>Device is non-compliant but still has access to corporate resources</summary>
        [EnumMember(Value = "inGracePeriod")]
        InGracePeriod,
        /// <summary>Managed by Config Manager</summary>
        [EnumMember(Value = "configManager")]
        ConfigManager,
    }
}
