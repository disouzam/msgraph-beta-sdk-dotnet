// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    [Flags]
    public enum SensitivityLabelTarget {
        [EnumMember(Value = "email")]
        Email = 1,
        [EnumMember(Value = "site")]
        Site = 2,
        [EnumMember(Value = "unifiedGroup")]
        UnifiedGroup = 4,
        [EnumMember(Value = "teamwork")]
        Teamwork = 8,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 16,
    }
}
