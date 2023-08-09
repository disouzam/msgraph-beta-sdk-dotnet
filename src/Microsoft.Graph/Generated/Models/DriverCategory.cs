// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>An enum type to represent which category a driver belongs to.</summary>
    public enum DriverCategory {
        /// <summary>This indicates a driver is recommended by Microsoft.</summary>
        [EnumMember(Value = "recommended")]
        Recommended,
        /// <summary>This indicates a driver was recommended by Microsoft and IT admin has taken some approval action on it.</summary>
        [EnumMember(Value = "previouslyApproved")]
        PreviouslyApproved,
        /// <summary>This indicates a driver is never recommended by Microsoft.</summary>
        [EnumMember(Value = "other")]
        Other,
    }
}
