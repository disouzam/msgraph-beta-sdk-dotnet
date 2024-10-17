// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Possible values of Secure Boot with DMA</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum SecureBootWithDMAType
    {
        /// <summary>Not configured, no operation</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Turns on VBS with Secure Boot</summary>
        [EnumMember(Value = "withoutDMA")]
        WithoutDMA,
        /// <summary>Turns on VBS with Secure Boot and DMA</summary>
        [EnumMember(Value = "withDMA")]
        WithDMA,
    }
}
