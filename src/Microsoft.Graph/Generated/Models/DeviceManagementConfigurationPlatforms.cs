// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Supported platform types.</summary>
    [Flags]
    public enum DeviceManagementConfigurationPlatforms {
        /// <summary>Default. No platform type specified.</summary>
        [EnumMember(Value = "none")]
        None = 1,
        /// <summary>Settings for Android platform.</summary>
        [EnumMember(Value = "android")]
        Android = 2,
        /// <summary>Settings for iOS platform.</summary>
        [EnumMember(Value = "iOS")]
        IOS = 4,
        /// <summary>Settings for MacOS platform.</summary>
        [EnumMember(Value = "macOS")]
        MacOS = 8,
        /// <summary>Windows 10 X.</summary>
        [EnumMember(Value = "windows10X")]
        Windows10X = 16,
        /// <summary>Settings for Windows 10 platform.</summary>
        [EnumMember(Value = "windows10")]
        Windows10 = 32,
        /// <summary>Settings for Linux platform.</summary>
        [EnumMember(Value = "linux")]
        Linux = 64,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue = 128,
    }
}
