// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Microsoft Launcher Dock Presence selection.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum MicrosoftLauncherDockPresence
    {
        /// <summary>Not configured; this value is ignored.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Indicates the device&apos;s dock will be displayed on the device.</summary>
        [EnumMember(Value = "show")]
        Show,
        /// <summary>Indicates the device&apos;s dock will be hidden on the device, but the user can access the dock by dragging the handler on the bottom of the screen.</summary>
        [EnumMember(Value = "hide")]
        Hide,
        /// <summary>Indicates the device&apos;s dock will be disabled on the device.</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
    }
}
