// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Possible sync statuses associated with an Apple Volume Purchase Program token.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum VppTokenSyncStatus
    {
        /// <summary>Default status.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Last Sync in progress.</summary>
        [EnumMember(Value = "inProgress")]
        InProgress,
        /// <summary>Last Sync completed successfully.</summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>Last Sync failed.</summary>
        [EnumMember(Value = "failed")]
        Failed,
    }
}
