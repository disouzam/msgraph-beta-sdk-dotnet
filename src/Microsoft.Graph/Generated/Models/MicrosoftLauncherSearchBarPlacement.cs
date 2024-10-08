// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Microsoft Launcher Search Bar Placement selection.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum MicrosoftLauncherSearchBarPlacement
    {
        /// <summary>Not configured; this value is ignored.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Indicates that the search bar will be displayed on the top of the device.</summary>
        [EnumMember(Value = "top")]
        Top,
        /// <summary>Indicates that the search bar will be displayed on the bottom of the device.</summary>
        [EnumMember(Value = "bottom")]
        Bottom,
        /// <summary>Indicates that the search bar will be hidden on the device.</summary>
        [EnumMember(Value = "hide")]
        Hide,
    }
}
