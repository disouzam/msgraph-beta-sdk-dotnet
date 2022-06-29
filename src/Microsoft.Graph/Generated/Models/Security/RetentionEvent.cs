using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class RetentionEvent : Entity, IParsable {
        /// <summary>The user who created the retentionEvent.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet CreatedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The date time when the retentionEvent was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Optional information about the event.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Name of the event.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The eventPropagationResults property</summary>
        public List<EventPropagationResult> EventPropagationResults {
            get { return BackingStore?.Get<List<EventPropagationResult>>(nameof(EventPropagationResults)); }
            set { BackingStore?.Set(nameof(EventPropagationResults), value); }
        }
        /// <summary>Represents the workload (SharePoint Online, OneDrive for Business, Exchange Online) and identification information associated with a retention event.</summary>
        public List<EventQuery> EventQueries {
            get { return BackingStore?.Get<List<EventQuery>>(nameof(EventQueries)); }
            set { BackingStore?.Set(nameof(EventQueries), value); }
        }
        /// <summary>The eventStatus property</summary>
        public RetentionEventStatus EventStatus {
            get { return BackingStore?.Get<RetentionEventStatus>(nameof(EventStatus)); }
            set { BackingStore?.Set(nameof(EventStatus), value); }
        }
        /// <summary>Optional time when the event should be triggered.</summary>
        public DateTimeOffset? EventTriggerDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EventTriggerDateTime)); }
            set { BackingStore?.Set(nameof(EventTriggerDateTime), value); }
        }
        /// <summary>The user who last modified the retentionEvent.</summary>
        public Microsoft.Graph.Beta.Models.IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdentitySet>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>The latest date time when the retentionEvent was modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Last time the status of the event was updated.</summary>
        public DateTimeOffset? LastStatusUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastStatusUpdateDateTime)); }
            set { BackingStore?.Set(nameof(LastStatusUpdateDateTime), value); }
        }
        /// <summary>Specifies the event that will start the retention period for labels that use this event type when an event is created.</summary>
        public Microsoft.Graph.Beta.Models.Security.RetentionEventType RetentionEventType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.RetentionEventType>(nameof(RetentionEventType)); }
            set { BackingStore?.Set(nameof(RetentionEventType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RetentionEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RetentionEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"eventPropagationResults", n => { EventPropagationResults = n.GetCollectionOfObjectValues<EventPropagationResult>(EventPropagationResult.CreateFromDiscriminatorValue).ToList(); } },
                {"eventQueries", n => { EventQueries = n.GetCollectionOfObjectValues<EventQuery>(EventQuery.CreateFromDiscriminatorValue).ToList(); } },
                {"eventStatus", n => { EventStatus = n.GetObjectValue<RetentionEventStatus>(RetentionEventStatus.CreateFromDiscriminatorValue); } },
                {"eventTriggerDateTime", n => { EventTriggerDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>(Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastStatusUpdateDateTime", n => { LastStatusUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"retentionEventType", n => { RetentionEventType = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.RetentionEventType>(Microsoft.Graph.Beta.Models.Security.RetentionEventType.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<EventPropagationResult>("eventPropagationResults", EventPropagationResults);
            writer.WriteCollectionOfObjectValues<EventQuery>("eventQueries", EventQueries);
            writer.WriteObjectValue<RetentionEventStatus>("eventStatus", EventStatus);
            writer.WriteDateTimeOffsetValue("eventTriggerDateTime", EventTriggerDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastStatusUpdateDateTime", LastStatusUpdateDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.RetentionEventType>("retentionEventType", RetentionEventType);
        }
    }
}
