using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AospDeviceOwnerWiFiConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Connect automatically when this network is in range. Setting this to true will skip the user prompt and automatically connect the device to Wi-Fi network.</summary>
        public bool? ConnectAutomatically {
            get { return BackingStore?.Get<bool?>(nameof(ConnectAutomatically)); }
            set { BackingStore?.Set(nameof(ConnectAutomatically), value); }
        }
        /// <summary>When set to true, this profile forces the device to connect to a network that doesn&apos;t broadcast its SSID to all devices.</summary>
        public bool? ConnectWhenNetworkNameIsHidden {
            get { return BackingStore?.Get<bool?>(nameof(ConnectWhenNetworkNameIsHidden)); }
            set { BackingStore?.Set(nameof(ConnectWhenNetworkNameIsHidden), value); }
        }
        /// <summary>Network Name</summary>
        public string NetworkName {
            get { return BackingStore?.Get<string>(nameof(NetworkName)); }
            set { BackingStore?.Set(nameof(NetworkName), value); }
        }
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
        public string PreSharedKey {
            get { return BackingStore?.Get<string>(nameof(PreSharedKey)); }
            set { BackingStore?.Set(nameof(PreSharedKey), value); }
        }
        /// <summary>This is the pre-shared key for WPA Personal Wi-Fi network.</summary>
        public bool? PreSharedKeyIsSet {
            get { return BackingStore?.Get<bool?>(nameof(PreSharedKeyIsSet)); }
            set { BackingStore?.Set(nameof(PreSharedKeyIsSet), value); }
        }
        /// <summary>This is the name of the Wi-Fi network that is broadcast to all devices.</summary>
        public string Ssid {
            get { return BackingStore?.Get<string>(nameof(Ssid)); }
            set { BackingStore?.Set(nameof(Ssid), value); }
        }
        /// <summary>Indicates whether Wi-Fi endpoint uses an EAP based security type. Possible values are: open, wep, wpaPersonal, wpaEnterprise.</summary>
        public AospDeviceOwnerWiFiSecurityType? WiFiSecurityType {
            get { return BackingStore?.Get<AospDeviceOwnerWiFiSecurityType?>(nameof(WiFiSecurityType)); }
            set { BackingStore?.Set(nameof(WiFiSecurityType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AospDeviceOwnerWiFiConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AospDeviceOwnerWiFiConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectAutomatically", n => { ConnectAutomatically = n.GetBoolValue(); } },
                {"connectWhenNetworkNameIsHidden", n => { ConnectWhenNetworkNameIsHidden = n.GetBoolValue(); } },
                {"networkName", n => { NetworkName = n.GetStringValue(); } },
                {"preSharedKey", n => { PreSharedKey = n.GetStringValue(); } },
                {"preSharedKeyIsSet", n => { PreSharedKeyIsSet = n.GetBoolValue(); } },
                {"ssid", n => { Ssid = n.GetStringValue(); } },
                {"wiFiSecurityType", n => { WiFiSecurityType = n.GetEnumValue<AospDeviceOwnerWiFiSecurityType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("connectAutomatically", ConnectAutomatically);
            writer.WriteBoolValue("connectWhenNetworkNameIsHidden", ConnectWhenNetworkNameIsHidden);
            writer.WriteStringValue("networkName", NetworkName);
            writer.WriteStringValue("preSharedKey", PreSharedKey);
            writer.WriteBoolValue("preSharedKeyIsSet", PreSharedKeyIsSet);
            writer.WriteStringValue("ssid", Ssid);
            writer.WriteEnumValue<AospDeviceOwnerWiFiSecurityType>("wiFiSecurityType", WiFiSecurityType);
        }
    }
}
