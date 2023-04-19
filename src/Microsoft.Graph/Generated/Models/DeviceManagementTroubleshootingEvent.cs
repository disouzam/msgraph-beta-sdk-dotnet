using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementTroubleshootingEvent : Entity, IParsable {
        /// <summary>A set of string key and string value pairs which provides additional information on the Troubleshooting event</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<KeyValuePair>? AdditionalInformation {
            get { return BackingStore?.Get<List<KeyValuePair>?>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#nullable restore
#else
        public List<KeyValuePair> AdditionalInformation {
            get { return BackingStore?.Get<List<KeyValuePair>>("additionalInformation"); }
            set { BackingStore?.Set("additionalInformation", value); }
        }
#endif
        /// <summary>Id used for tracing the failure in the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CorrelationId {
            get { return BackingStore?.Get<string?>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#nullable restore
#else
        public string CorrelationId {
            get { return BackingStore?.Get<string>("correlationId"); }
            set { BackingStore?.Set("correlationId", value); }
        }
#endif
        /// <summary>Time when the event occurred .</summary>
        public DateTimeOffset? EventDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("eventDateTime"); }
            set { BackingStore?.Set("eventDateTime", value); }
        }
        /// <summary>Event Name corresponding to the Troubleshooting Event. It is an Optional field</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventName {
            get { return BackingStore?.Get<string?>("eventName"); }
            set { BackingStore?.Set("eventName", value); }
        }
#nullable restore
#else
        public string EventName {
            get { return BackingStore?.Get<string>("eventName"); }
            set { BackingStore?.Set("eventName", value); }
        }
#endif
        /// <summary>Object containing detailed information about the error and its remediation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementTroubleshootingErrorDetails? TroubleshootingErrorDetails {
            get { return BackingStore?.Get<DeviceManagementTroubleshootingErrorDetails?>("troubleshootingErrorDetails"); }
            set { BackingStore?.Set("troubleshootingErrorDetails", value); }
        }
#nullable restore
#else
        public DeviceManagementTroubleshootingErrorDetails TroubleshootingErrorDetails {
            get { return BackingStore?.Get<DeviceManagementTroubleshootingErrorDetails>("troubleshootingErrorDetails"); }
            set { BackingStore?.Set("troubleshootingErrorDetails", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagementTroubleshootingEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.appleVppTokenTroubleshootingEvent" => new AppleVppTokenTroubleshootingEvent(),
                "#microsoft.graph.enrollmentTroubleshootingEvent" => new EnrollmentTroubleshootingEvent(),
                "#microsoft.graph.mobileAppTroubleshootingEvent" => new MobileAppTroubleshootingEvent(),
                _ => new DeviceManagementTroubleshootingEvent(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"additionalInformation", n => { AdditionalInformation = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"eventName", n => { EventName = n.GetStringValue(); } },
                {"troubleshootingErrorDetails", n => { TroubleshootingErrorDetails = n.GetObjectValue<DeviceManagementTroubleshootingErrorDetails>(DeviceManagementTroubleshootingErrorDetails.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("additionalInformation", AdditionalInformation);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("eventName", EventName);
            writer.WriteObjectValue<DeviceManagementTroubleshootingErrorDetails>("troubleshootingErrorDetails", TroubleshootingErrorDetails);
        }
    }
}
