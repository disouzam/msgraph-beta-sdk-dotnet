// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public enum LifecycleWorkflowProcessingStatus
    #pragma warning restore CS1591
    {
        [EnumMember(Value = "queued")]
        #pragma warning disable CS1591
        Queued,
        #pragma warning restore CS1591
        [EnumMember(Value = "inProgress")]
        #pragma warning disable CS1591
        InProgress,
        #pragma warning restore CS1591
        [EnumMember(Value = "completed")]
        #pragma warning disable CS1591
        Completed,
        #pragma warning restore CS1591
        [EnumMember(Value = "completedWithErrors")]
        #pragma warning disable CS1591
        CompletedWithErrors,
        #pragma warning restore CS1591
        [EnumMember(Value = "canceled")]
        #pragma warning disable CS1591
        Canceled,
        #pragma warning restore CS1591
        [EnumMember(Value = "failed")]
        #pragma warning disable CS1591
        Failed,
        #pragma warning restore CS1591
        [EnumMember(Value = "unknownFutureValue")]
        #pragma warning disable CS1591
        UnknownFutureValue,
        #pragma warning restore CS1591
    }
}
