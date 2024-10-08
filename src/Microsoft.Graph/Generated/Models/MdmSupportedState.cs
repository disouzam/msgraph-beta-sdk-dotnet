// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Mdm Support Status of the setting.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum MdmSupportedState
    {
        /// <summary>Mdm support status of the setting is not known.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Setting is supported.</summary>
        [EnumMember(Value = "supported")]
        Supported,
        /// <summary>Setting is unsupported.</summary>
        [EnumMember(Value = "unsupported")]
        Unsupported,
        /// <summary>Setting is depcrecated.</summary>
        [EnumMember(Value = "deprecated")]
        Deprecated,
    }
}
