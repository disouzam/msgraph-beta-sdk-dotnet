// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    [Flags]
    #pragma warning disable CS1591
    public enum SynchronizationJobRestartScope
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "None")]
        #pragma warning disable CS1591
        None = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "ConnectorDataStore")]
        #pragma warning disable CS1591
        ConnectorDataStore = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "Escrows")]
        #pragma warning disable CS1591
        Escrows = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "Watermark")]
        #pragma warning disable CS1591
        Watermark = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "QuarantineState")]
        #pragma warning disable CS1591
        QuarantineState = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "Full")]
        #pragma warning disable CS1591
        Full = 32,
        #pragma warning restore CS1591
        [EnumMember(Value = "ForceDeletes")]
        #pragma warning disable CS1591
        ForceDeletes = 64,
        #pragma warning restore CS1591
    }
}
