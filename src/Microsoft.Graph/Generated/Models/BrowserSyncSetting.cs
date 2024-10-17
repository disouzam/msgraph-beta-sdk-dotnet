// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Allow(Not Configured) or prevent(Block) the syncing of Microsoft Edge Browser settings. Option to prevent syncing across devices, but allow user override.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum BrowserSyncSetting
    {
        /// <summary>Default – Allow syncing of browser settings across devices.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Prevent syncing of browser settings across user devices, allow user override of setting.</summary>
        [EnumMember(Value = "blockedWithUserOverride")]
        BlockedWithUserOverride,
        /// <summary>Absolutely prevent syncing of browser settings across user devices.</summary>
        [EnumMember(Value = "blocked")]
        Blocked,
    }
}
