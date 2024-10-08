// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>This enum indicates the platform type for which the enrollment restriction applies.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public enum EnrollmentRestrictionPlatformType
    {
        /// <summary>Indicates that the enrollment configuration applies to all platforms</summary>
        [EnumMember(Value = "allPlatforms")]
        AllPlatforms,
        /// <summary>Indicates that the enrollment configuration applies only to iOS/iPadOS devices</summary>
        [EnumMember(Value = "ios")]
        Ios,
        /// <summary>Indicates that the enrollment configuration applies only to Windows devices</summary>
        [EnumMember(Value = "windows")]
        Windows,
        /// <summary>Indicates that the enrollment configuration applies only to Windows Phone devices</summary>
        [EnumMember(Value = "windowsPhone")]
        WindowsPhone,
        /// <summary>Indicates that the enrollment configuration applies only to Android devices</summary>
        [EnumMember(Value = "android")]
        Android,
        /// <summary>Indicates that the enrollment configuration applies only to Android for Work devices</summary>
        [EnumMember(Value = "androidForWork")]
        AndroidForWork,
        /// <summary>Indicates that the enrollment configuration applies only to macOS devices</summary>
        [EnumMember(Value = "mac")]
        Mac,
        /// <summary>Indicates that the enrollment configuration applies only to Linux devices</summary>
        [EnumMember(Value = "linux")]
        Linux,
        /// <summary>Evolvable enumeration sentinel value. Do not use</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
