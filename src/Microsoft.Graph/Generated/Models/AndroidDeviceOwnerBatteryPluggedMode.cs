// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Android Device Owner possible values for states of the device&apos;s plugged-in power modes.</summary>
    public enum AndroidDeviceOwnerBatteryPluggedMode {
        /// <summary>Not configured; this value is ignored.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Power source is an AC charger.</summary>
        [EnumMember(Value = "ac")]
        Ac,
        /// <summary>Power source is a USB port.</summary>
        [EnumMember(Value = "usb")]
        Usb,
        /// <summary>Power source is wireless.</summary>
        [EnumMember(Value = "wireless")]
        Wireless,
    }
}
