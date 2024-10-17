// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Indicates state of elevation request</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum ElevationRequestState
    {
        /// <summary>Default Value. Indicates that elevation request status is unavailable</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Initial state when request is submitted but no approval/denial action taken</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Indicates elevation request has been approved by IT Admin.</summary>
        [EnumMember(Value = "approved")]
        Approved,
        /// <summary>Indicates elevation request has been denied by IT Admin.</summary>
        [EnumMember(Value = "denied")]
        Denied,
        /// <summary>Set to expire when Approved for is elapsed or ExpireDate is elapsed, whichever is sooner.</summary>
        [EnumMember(Value = "expired")]
        Expired,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        /// <summary>Set to expire when Approved for is elapsed or ExpireDate is elapsed, whichever is sooner.</summary>
        [EnumMember(Value = "revoked")]
        Revoked,
        /// <summary>Indicates an elevation request that was previously approved and expired has been completed.</summary>
        [EnumMember(Value = "completed")]
        Completed,
    }
}
