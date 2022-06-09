using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AndroidVpnConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Authentication method. Possible values are: certificate, usernameAndPassword, sharedSecret, derivedCredential, azureAD.</summary>
        public VpnAuthenticationMethod? AuthenticationMethod {
            get { return BackingStore?.Get<VpnAuthenticationMethod?>(nameof(AuthenticationMethod)); }
            set { BackingStore?.Set(nameof(AuthenticationMethod), value); }
        }
        /// <summary>Connection name displayed to the user.</summary>
        public string ConnectionName {
            get { return BackingStore?.Get<string>(nameof(ConnectionName)); }
            set { BackingStore?.Set(nameof(ConnectionName), value); }
        }
        /// <summary>Connection type. Possible values are: ciscoAnyConnect, pulseSecure, f5EdgeClient, dellSonicWallMobileConnect, checkPointCapsuleVpn, citrix, microsoftTunnel, netMotionMobility, microsoftProtect.</summary>
        public AndroidVpnConnectionType? ConnectionType {
            get { return BackingStore?.Get<AndroidVpnConnectionType?>(nameof(ConnectionType)); }
            set { BackingStore?.Set(nameof(ConnectionType), value); }
        }
        /// <summary>Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.</summary>
        public List<KeyValue> CustomData {
            get { return BackingStore?.Get<List<KeyValue>>(nameof(CustomData)); }
            set { BackingStore?.Set(nameof(CustomData), value); }
        }
        /// <summary>Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.</summary>
        public List<KeyValuePair> CustomKeyValueData {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(CustomKeyValueData)); }
            set { BackingStore?.Set(nameof(CustomKeyValueData), value); }
        }
        /// <summary>Fingerprint is a string that will be used to verify the VPN server can be trusted, which is only applicable when connection type is Check Point Capsule VPN.</summary>
        public string Fingerprint {
            get { return BackingStore?.Get<string>(nameof(Fingerprint)); }
            set { BackingStore?.Set(nameof(Fingerprint), value); }
        }
        /// <summary>Identity certificate for client authentication when authentication method is certificate.</summary>
        public AndroidCertificateProfileBase IdentityCertificate {
            get { return BackingStore?.Get<AndroidCertificateProfileBase>(nameof(IdentityCertificate)); }
            set { BackingStore?.Set(nameof(IdentityCertificate), value); }
        }
        /// <summary>Realm when connection type is set to Pulse Secure.</summary>
        public string Realm {
            get { return BackingStore?.Get<string>(nameof(Realm)); }
            set { BackingStore?.Set(nameof(Realm), value); }
        }
        /// <summary>Role when connection type is set to Pulse Secure.</summary>
        public string Role {
            get { return BackingStore?.Get<string>(nameof(Role)); }
            set { BackingStore?.Set(nameof(Role), value); }
        }
        /// <summary>List of VPN Servers on the network. Make sure end users can access these network locations. This collection can contain a maximum of 500 elements.</summary>
        public List<VpnServer> Servers {
            get { return BackingStore?.Get<List<VpnServer>>(nameof(Servers)); }
            set { BackingStore?.Set(nameof(Servers), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AndroidVpnConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidVpnConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationMethod", n => { AuthenticationMethod = n.GetEnumValue<VpnAuthenticationMethod>(); } },
                {"connectionName", n => { ConnectionName = n.GetStringValue(); } },
                {"connectionType", n => { ConnectionType = n.GetEnumValue<AndroidVpnConnectionType>(); } },
                {"customData", n => { CustomData = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"customKeyValueData", n => { CustomKeyValueData = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"fingerprint", n => { Fingerprint = n.GetStringValue(); } },
                {"identityCertificate", n => { IdentityCertificate = n.GetObjectValue<AndroidCertificateProfileBase>(AndroidCertificateProfileBase.CreateFromDiscriminatorValue); } },
                {"realm", n => { Realm = n.GetStringValue(); } },
                {"role", n => { Role = n.GetStringValue(); } },
                {"servers", n => { Servers = n.GetCollectionOfObjectValues<VpnServer>(VpnServer.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<VpnAuthenticationMethod>("authenticationMethod", AuthenticationMethod);
            writer.WriteStringValue("connectionName", ConnectionName);
            writer.WriteEnumValue<AndroidVpnConnectionType>("connectionType", ConnectionType);
            writer.WriteCollectionOfObjectValues<KeyValue>("customData", CustomData);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("customKeyValueData", CustomKeyValueData);
            writer.WriteStringValue("fingerprint", Fingerprint);
            writer.WriteObjectValue<AndroidCertificateProfileBase>("identityCertificate", IdentityCertificate);
            writer.WriteStringValue("realm", Realm);
            writer.WriteStringValue("role", Role);
            writer.WriteCollectionOfObjectValues<VpnServer>("servers", Servers);
        }
    }
}
