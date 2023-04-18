using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsInformationProtectionDeviceRegistration : Entity, IParsable {
        /// <summary>Device Mac address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceMacAddress {
            get { return BackingStore?.Get<string?>("deviceMacAddress"); }
            set { BackingStore?.Set("deviceMacAddress", value); }
        }
#nullable restore
#else
        public string DeviceMacAddress {
            get { return BackingStore?.Get<string>("deviceMacAddress"); }
            set { BackingStore?.Set("deviceMacAddress", value); }
        }
#endif
        /// <summary>Device name.</summary>
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
        /// <summary>Device identifier for this device registration record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceRegistrationId {
            get { return BackingStore?.Get<string?>("deviceRegistrationId"); }
            set { BackingStore?.Set("deviceRegistrationId", value); }
        }
#nullable restore
#else
        public string DeviceRegistrationId {
            get { return BackingStore?.Get<string>("deviceRegistrationId"); }
            set { BackingStore?.Set("deviceRegistrationId", value); }
        }
#endif
        /// <summary>Device type, for example, Windows laptop VS Windows phone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceType {
            get { return BackingStore?.Get<string?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
#nullable restore
#else
        public string DeviceType {
            get { return BackingStore?.Get<string>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
#endif
        /// <summary>Last checkin time of the device.</summary>
        public DateTimeOffset? LastCheckInDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastCheckInDateTime"); }
            set { BackingStore?.Set("lastCheckInDateTime", value); }
        }
        /// <summary>UserId associated with this device registration record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsInformationProtectionDeviceRegistration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionDeviceRegistration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceMacAddress", n => { DeviceMacAddress = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceRegistrationId", n => { DeviceRegistrationId = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetStringValue(); } },
                {"lastCheckInDateTime", n => { LastCheckInDateTime = n.GetDateTimeOffsetValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceMacAddress", DeviceMacAddress);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("deviceRegistrationId", DeviceRegistrationId);
            writer.WriteStringValue("deviceType", DeviceType);
            writer.WriteDateTimeOffsetValue("lastCheckInDateTime", LastCheckInDateTime);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
