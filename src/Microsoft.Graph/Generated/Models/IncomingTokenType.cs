// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    [Flags]
    #pragma warning disable CS1591
    public enum IncomingTokenType
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "none")]
        #pragma warning disable CS1591
        None = 1,
        #pragma warning restore CS1591
        [EnumMember(Value = "primaryRefreshToken")]
        #pragma warning disable CS1591
        PrimaryRefreshToken = 2,
        #pragma warning restore CS1591
        [EnumMember(Value = "saml11")]
        #pragma warning disable CS1591
        Saml11 = 4,
        #pragma warning restore CS1591
        [EnumMember(Value = "saml20")]
        #pragma warning disable CS1591
        Saml20 = 8,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue = 16,
        #pragma warning restore CS1591
        [EnumMember(Value = "remoteDesktopToken")]
        #pragma warning disable CS1591
        RemoteDesktopToken = 32,
        #pragma warning restore CS1591
        [EnumMember(Value = "refreshToken")]
        #pragma warning disable CS1591
        RefreshToken = 64,
        #pragma warning restore CS1591
    }
}
