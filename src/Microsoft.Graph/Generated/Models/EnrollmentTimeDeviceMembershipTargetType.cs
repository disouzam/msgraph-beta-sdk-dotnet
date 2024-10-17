// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Represents the type of the targets that devices will become members of when enrolled with the associated profile. Possible values are staticSecurityGroup.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum EnrollmentTimeDeviceMembershipTargetType
    {
        /// <summary>Default value. Do not use.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates the device membership target specified refer to static Entra Security Groups.</summary>
        [EnumMember(Value = "staticSecurityGroup")]
        StaticSecurityGroup,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
