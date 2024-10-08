// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Apps rating as in media content</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum RatingAppsType
    {
        /// <summary>Default value, allow all apps content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any apps content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>4+, age 4 and above</summary>
        [EnumMember(Value = "agesAbove4")]
        AgesAbove4,
        /// <summary>9+, age 9 and above</summary>
        [EnumMember(Value = "agesAbove9")]
        AgesAbove9,
        /// <summary>12+, age 12 and above </summary>
        [EnumMember(Value = "agesAbove12")]
        AgesAbove12,
        /// <summary>17+, age 17 and above</summary>
        [EnumMember(Value = "agesAbove17")]
        AgesAbove17,
    }
}
