using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CallRecordingEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Unique identifier of the call.</summary>
        public string CallId {
            get { return BackingStore?.Get<string>(nameof(CallId)); }
            set { BackingStore?.Set(nameof(CallId), value); }
        }
        /// <summary>Display name for the call recording.</summary>
        public string CallRecordingDisplayName {
            get { return BackingStore?.Get<string>(nameof(CallRecordingDisplayName)); }
            set { BackingStore?.Set(nameof(CallRecordingDisplayName), value); }
        }
        /// <summary>Duration of the call recording.</summary>
        public TimeSpan? CallRecordingDuration {
            get { return BackingStore?.Get<TimeSpan?>(nameof(CallRecordingDuration)); }
            set { BackingStore?.Set(nameof(CallRecordingDuration), value); }
        }
        /// <summary>Status of the call recording. Possible values are: success, failure, initial, chunkFinished, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.CallRecordingStatus? CallRecordingStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.CallRecordingStatus?>(nameof(CallRecordingStatus)); }
            set { BackingStore?.Set(nameof(CallRecordingStatus), value); }
        }
        /// <summary>Call recording URL.</summary>
        public string CallRecordingUrl {
            get { return BackingStore?.Get<string>(nameof(CallRecordingUrl)); }
            set { BackingStore?.Set(nameof(CallRecordingUrl), value); }
        }
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator {
            get { return BackingStore?.Get<IdentitySet>(nameof(Initiator)); }
            set { BackingStore?.Set(nameof(Initiator), value); }
        }
        /// <summary>Organizer of the meeting.</summary>
        public IdentitySet MeetingOrganizer {
            get { return BackingStore?.Get<IdentitySet>(nameof(MeetingOrganizer)); }
            set { BackingStore?.Set(nameof(MeetingOrganizer), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CallRecordingEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CallRecordingEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"callId", n => { CallId = n.GetStringValue(); } },
                {"callRecordingDisplayName", n => { CallRecordingDisplayName = n.GetStringValue(); } },
                {"callRecordingDuration", n => { CallRecordingDuration = n.GetTimeSpanValue(); } },
                {"callRecordingStatus", n => { CallRecordingStatus = n.GetEnumValue<CallRecordingStatus>(); } },
                {"callRecordingUrl", n => { CallRecordingUrl = n.GetStringValue(); } },
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"meetingOrganizer", n => { MeetingOrganizer = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("callId", CallId);
            writer.WriteStringValue("callRecordingDisplayName", CallRecordingDisplayName);
            writer.WriteTimeSpanValue("callRecordingDuration", CallRecordingDuration);
            writer.WriteEnumValue<CallRecordingStatus>("callRecordingStatus", CallRecordingStatus);
            writer.WriteStringValue("callRecordingUrl", CallRecordingUrl);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteObjectValue<IdentitySet>("meetingOrganizer", MeetingOrganizer);
        }
    }
}
