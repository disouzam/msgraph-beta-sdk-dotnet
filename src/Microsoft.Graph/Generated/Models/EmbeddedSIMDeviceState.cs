// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Describes the embedded SIM activation code deployment state in relation to a device.
    /// </summary>
    public class EmbeddedSIMDeviceState : Entity, IParsable {
        /// <summary>The time the embedded SIM device status was created. Generated service side.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Device name to which the subscription was provisioned e.g. DESKTOP-JOE</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>The time the embedded SIM device last checked in. Updated service side.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>The time the embedded SIM device status was last modified. Updated service side.</summary>
        public DateTimeOffset? ModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("modifiedDateTime"); }
            set { BackingStore?.Set("modifiedDateTime", value); }
        }
        /// <summary>Describes the various states for an embedded SIM activation code.</summary>
        public EmbeddedSIMDeviceStateValue? State {
            get { return BackingStore?.Get<EmbeddedSIMDeviceStateValue?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>String description of the provisioning state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateDetails {
            get { return BackingStore?.Get<string?>("stateDetails"); }
            set { BackingStore?.Set("stateDetails", value); }
        }
#nullable restore
#else
        public string StateDetails {
            get { return BackingStore?.Get<string>("stateDetails"); }
            set { BackingStore?.Set("stateDetails", value); }
        }
#endif
        /// <summary>The Universal Integrated Circuit Card Identifier (UICCID) identifying the hardware onto which a profile is to be deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UniversalIntegratedCircuitCardIdentifier {
            get { return BackingStore?.Get<string?>("universalIntegratedCircuitCardIdentifier"); }
            set { BackingStore?.Set("universalIntegratedCircuitCardIdentifier", value); }
        }
#nullable restore
#else
        public string UniversalIntegratedCircuitCardIdentifier {
            get { return BackingStore?.Get<string>("universalIntegratedCircuitCardIdentifier"); }
            set { BackingStore?.Set("universalIntegratedCircuitCardIdentifier", value); }
        }
#endif
        /// <summary>Username which the subscription was provisioned to e.g. joe@contoso.com</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName {
            get { return BackingStore?.Get<string?>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#nullable restore
#else
        public string UserName {
            get { return BackingStore?.Get<string>("userName"); }
            set { BackingStore?.Set("userName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EmbeddedSIMDeviceState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EmbeddedSIMDeviceState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"state", n => { State = n.GetEnumValue<EmbeddedSIMDeviceStateValue>(); } },
                {"stateDetails", n => { StateDetails = n.GetStringValue(); } },
                {"universalIntegratedCircuitCardIdentifier", n => { UniversalIntegratedCircuitCardIdentifier = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteEnumValue<EmbeddedSIMDeviceStateValue>("state", State);
            writer.WriteStringValue("stateDetails", StateDetails);
            writer.WriteStringValue("universalIntegratedCircuitCardIdentifier", UniversalIntegratedCircuitCardIdentifier);
            writer.WriteStringValue("userName", UserName);
        }
    }
}
