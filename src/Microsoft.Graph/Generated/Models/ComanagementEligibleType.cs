// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    public enum ComanagementEligibleType {
        [EnumMember(Value = "comanaged")]
        Comanaged,
        [EnumMember(Value = "eligible")]
        Eligible,
        [EnumMember(Value = "eligibleButNotAzureAdJoined")]
        EligibleButNotAzureAdJoined,
        [EnumMember(Value = "needsOsUpdate")]
        NeedsOsUpdate,
        [EnumMember(Value = "ineligible")]
        Ineligible,
        /// <summary>Devices scheduled for Co-Management enrollment</summary>
        [EnumMember(Value = "scheduledForEnrollment")]
        ScheduledForEnrollment,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
