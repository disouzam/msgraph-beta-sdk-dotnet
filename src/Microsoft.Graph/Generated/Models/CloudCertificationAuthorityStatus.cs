// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Enum type of possible certification authority statuses. These statuses indicate whether a certification authority is currently able to issue certificates or temporarily paused or permanently revoked.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum CloudCertificationAuthorityStatus
    {
        /// <summary>Default. Indicates certification authority has an unknown or invalid status.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates certification authority is active and can issue certificates.</summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>Indicates certification authority has been paused from issuing certificates. Paused certification authorities can be put back in an active status to continue issuing certificates.</summary>
        [EnumMember(Value = "paused")]
        Paused,
        /// <summary>Indicates certification authority has been revoked. This is a permanent state that cannot be changed.</summary>
        [EnumMember(Value = "revoked")]
        Revoked,
        /// <summary>Indicates certification authority certificate signing request has been created and can be downloaded for signing and then be uploaded.</summary>
        [EnumMember(Value = "signingPending")]
        SigningPending,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
