// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Source of the action on the approval request.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum OperationApprovalSource
    {
        /// <summary>Default. Indicates the source of the action on the approval request is unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates the source of the action on the approval request is from an interactive session using the Intune Admin Console.</summary>
        [EnumMember(Value = "adminConsole")]
        AdminConsole,
        /// <summary>Indicates the source of the action on the approval request is from an email based form.</summary>
        [EnumMember(Value = "email")]
        Email,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
