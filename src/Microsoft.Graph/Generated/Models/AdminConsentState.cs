// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Admin consent state.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum AdminConsentState
    {
        /// <summary>Admin did not configure the item</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Admin granted item</summary>
        [EnumMember(Value = "granted")]
        Granted,
        /// <summary>Admin deos not grant item</summary>
        [EnumMember(Value = "notGranted")]
        NotGranted,
    }
}
