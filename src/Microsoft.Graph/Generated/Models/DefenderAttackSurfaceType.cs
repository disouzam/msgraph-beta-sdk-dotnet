// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Possible values of Defender Attack Surface Reduction Rules</summary>
    public enum DefenderAttackSurfaceType {
        /// <summary>Default, which disables attack surface reduction rule.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Enable the attack surface reduction rule.</summary>
        [EnumMember(Value = "block")]
        Block,
        /// <summary>Evaluate how the ASR rule would impact your organization if enabled. Does not change functionality but generate logs.</summary>
        [EnumMember(Value = "auditMode")]
        AuditMode,
        /// <summary>Warning message to end user with ability to bypass block from attack surface reduction rule.</summary>
        [EnumMember(Value = "warn")]
        Warn,
        /// <summary>Disable the attack surface reduction rule</summary>
        [EnumMember(Value = "disable")]
        Disable,
    }
}
