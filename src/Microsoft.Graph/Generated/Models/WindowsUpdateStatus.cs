// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Windows update for business configuration device states</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum WindowsUpdateStatus
    {
        /// <summary>There are no pending updates, no pending reboot updates and no failed updates.</summary>
        [EnumMember(Value = "upToDate")]
        UpToDate,
        /// <summary>There are updates that’s pending installation which includes updates that are not approved. There are no Pending reboot updates, no failed updates.</summary>
        [EnumMember(Value = "pendingInstallation")]
        PendingInstallation,
        /// <summary>There are updates that requires reboot. There are not failed updates.</summary>
        [EnumMember(Value = "pendingReboot")]
        PendingReboot,
        /// <summary>There are updates failed to install on the device.</summary>
        [EnumMember(Value = "failed")]
        Failed,
    }
}
