// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Defines the Action Types for an Intune Application.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum MobileAppActionType
    {
        /// <summary>Unknown result.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Application install command was sent.</summary>
        [EnumMember(Value = "installCommandSent")]
        InstallCommandSent,
        /// <summary>Application installed.</summary>
        [EnumMember(Value = "installed")]
        Installed,
        /// <summary>Application uninstalled.</summary>
        [EnumMember(Value = "uninstalled")]
        Uninstalled,
        /// <summary>User requested installation</summary>
        [EnumMember(Value = "userRequestedInstall")]
        UserRequestedInstall,
    }
}
