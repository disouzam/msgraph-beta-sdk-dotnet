// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    [Flags]
    #pragma warning disable CS1591
    public enum SignInAccessType
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "b2bCollaboration")]
        #pragma warning disable CS1591
        B2bCollaboration = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "b2bDirectConnect")]
        #pragma warning disable CS1591
        B2bDirectConnect = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "microsoftSupport")]
        #pragma warning disable CS1591
        MicrosoftSupport = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "serviceProvider")]
        #pragma warning disable CS1591
        ServiceProvider = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 32,
        #pragma warning restore CS1591
        [EnumMember(Value = "passthrough")]
        #pragma warning disable CS1591
        Passthrough = 64,
        #pragma warning restore CS1591
    }
}
