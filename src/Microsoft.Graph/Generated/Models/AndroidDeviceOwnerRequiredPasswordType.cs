// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android Device Owner policy required password type.</summary>
    public enum AndroidDeviceOwnerRequiredPasswordType {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>There must be a password set, but there are no restrictions on type.</summary>
        [EnumMember(Value = "required")]
        Required,
        /// <summary>At least numeric.</summary>
        [EnumMember(Value = "numeric")]
        Numeric,
        /// <summary>At least numeric with no repeating or ordered sequences.</summary>
        [EnumMember(Value = "numericComplex")]
        NumericComplex,
        /// <summary>At least alphabetic password.</summary>
        [EnumMember(Value = "alphabetic")]
        Alphabetic,
        /// <summary>At least alphanumeric password</summary>
        [EnumMember(Value = "alphanumeric")]
        Alphanumeric,
        /// <summary>At least alphanumeric with symbols.</summary>
        [EnumMember(Value = "alphanumericWithSymbols")]
        AlphanumericWithSymbols,
        /// <summary>Low security biometrics based password required.</summary>
        [EnumMember(Value = "lowSecurityBiometric")]
        LowSecurityBiometric,
        /// <summary>Custom password set by the admin.</summary>
        [EnumMember(Value = "customPassword")]
        CustomPassword,
    }
}
