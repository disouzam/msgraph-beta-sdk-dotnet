// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>Partner App Type.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DeviceManagementPartnerAppType
    {
        /// <summary>Partner App type is unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Partner App is Single tenant in AAD.</summary>
        [EnumMember(Value = "singleTenantApp")]
        SingleTenantApp,
        /// <summary>Partner App is Multi tenant in AAD.</summary>
        [EnumMember(Value = "multiTenantApp")]
        MultiTenantApp,
    }
}
