// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Indicates if the Group Policy Object file is covered and ready for Intune migration.</summary>
    public enum GroupPolicyMigrationReadiness {
        /// <summary>No Intune coverage</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Partial Intune coverage</summary>
        [EnumMember(Value = "partial")]
        Partial,
        /// <summary>Complete Intune coverage</summary>
        [EnumMember(Value = "complete")]
        Complete,
        /// <summary>Error when analyzing coverage</summary>
        [EnumMember(Value = "error")]
        Error,
        /// <summary>No Group Policy settings in GPO</summary>
        [EnumMember(Value = "notApplicable")]
        NotApplicable,
    }
}
