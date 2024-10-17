// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Types of communityPrivacy.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum CommunityPrivacy
    {
        /// <summary>Any user from the tenant can join and participate in the community.</summary>
        [EnumMember(Value = "public")]
        Public,
        /// <summary>A community administrator must add tenant users to the community before they can participate.</summary>
        [EnumMember(Value = "private")]
        Private,
        /// <summary>A marker value for members added after the release of this API.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
