// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Android Device Owner Location Mode Type</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum AndroidDeviceOwnerLocationMode
    {
        /// <summary>No restrictions on the location setting and no specific behavior is set or enforced. This is the default</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Location setting is disabled on the device</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
        /// <summary>Evolvable enumeration sentinel value. Do not use</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
