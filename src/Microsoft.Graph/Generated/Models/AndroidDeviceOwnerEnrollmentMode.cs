// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>The enrollment mode for an enrollment profile.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum AndroidDeviceOwnerEnrollmentMode
    {
        [EnumMember(Value = "corporateOwnedDedicatedDevice")]
        #pragma warning disable CS1591
        CorporateOwnedDedicatedDevice,
        #pragma warning restore CS1591
        [EnumMember(Value = "corporateOwnedFullyManaged")]
        #pragma warning disable CS1591
        CorporateOwnedFullyManaged,
        #pragma warning restore CS1591
        [EnumMember(Value = "corporateOwnedWorkProfile")]
        #pragma warning disable CS1591
        CorporateOwnedWorkProfile,
        #pragma warning restore CS1591
        /// <summary>Corporate owned, userless Android Open Source Project (AOSP) device, without Google Mobile Services.</summary>
        [EnumMember(Value = "corporateOwnedAOSPUserlessDevice")]
        CorporateOwnedAOSPUserlessDevice,
        /// <summary>Corporate owned, user-associated Android Open Source Project (AOSP) device, without Google Mobile Services.</summary>
        [EnumMember(Value = "corporateOwnedAOSPUserAssociatedDevice")]
        CorporateOwnedAOSPUserAssociatedDevice,
    }
}
