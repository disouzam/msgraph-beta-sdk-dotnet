// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class RetentionEvent : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The user who created the retentionEvent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentitySet? CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentitySet CreatedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The date time when the retentionEvent was created.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Optional information about the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description
        {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description
        {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Name of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Represents the success status of a created event and additional information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.EventPropagationResult>? EventPropagationResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EventPropagationResult>?>("eventPropagationResults"); }
            set { BackingStore?.Set("eventPropagationResults", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.EventPropagationResult> EventPropagationResults
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EventPropagationResult>>("eventPropagationResults"); }
            set { BackingStore?.Set("eventPropagationResults", value); }
        }
#endif
        /// <summary>Represents the workload (SharePoint Online, OneDrive for Business, Exchange Online) and identification information associated with a retention event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.EventQuery>? EventQueries
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EventQuery>?>("eventQueries"); }
            set { BackingStore?.Set("eventQueries", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.EventQuery> EventQueries
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.EventQuery>>("eventQueries"); }
            set { BackingStore?.Set("eventQueries", value); }
        }
#endif
        /// <summary>Status of event propogation to the scoped locations after the event has been created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.RetentionEventStatus? EventStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.RetentionEventStatus?>("eventStatus"); }
            set { BackingStore?.Set("eventStatus", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.RetentionEventStatus EventStatus
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.RetentionEventStatus>("eventStatus"); }
            set { BackingStore?.Set("eventStatus", value); }
        }
#endif
        /// <summary>Optional time when the event should be triggered.</summary>
        public DateTimeOffset? EventTriggerDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("eventTriggerDateTime"); }
            set { BackingStore?.Set("eventTriggerDateTime", value); }
        }
        /// <summary>The user who last modified the retentionEvent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.IdentitySet? LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.IdentitySet LastModifiedBy
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The latest date time when the retentionEvent was modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Last time the status of the event was updated.</summary>
        public DateTimeOffset? LastStatusUpdateDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastStatusUpdateDateTime"); }
            set { BackingStore?.Set("lastStatusUpdateDateTime", value); }
        }
        /// <summary>Specifies the event that will start the retention period for labels that use this event type when an event is created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.RetentionEventType? RetentionEventType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.RetentionEventType?>("retentionEventType"); }
            set { BackingStore?.Set("retentionEventType", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.RetentionEventType RetentionEventType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.RetentionEventType>("retentionEventType"); }
            set { BackingStore?.Set("retentionEventType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.RetentionEvent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.RetentionEvent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.RetentionEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>(global::Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "eventPropagationResults", n => { EventPropagationResults = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EventPropagationResult>(global::Microsoft.Graph.Beta.Models.Security.EventPropagationResult.CreateFromDiscriminatorValue)?.AsList(); } },
                { "eventQueries", n => { EventQueries = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EventQuery>(global::Microsoft.Graph.Beta.Models.Security.EventQuery.CreateFromDiscriminatorValue)?.AsList(); } },
                { "eventStatus", n => { EventStatus = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.RetentionEventStatus>(global::Microsoft.Graph.Beta.Models.Security.RetentionEventStatus.CreateFromDiscriminatorValue); } },
                { "eventTriggerDateTime", n => { EventTriggerDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>(global::Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastStatusUpdateDateTime", n => { LastStatusUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "retentionEventType", n => { RetentionEventType = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.RetentionEventType>(global::Microsoft.Graph.Beta.Models.Security.RetentionEventType.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EventPropagationResult>("eventPropagationResults", EventPropagationResults);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.EventQuery>("eventQueries", EventQueries);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.RetentionEventStatus>("eventStatus", EventStatus);
            writer.WriteDateTimeOffsetValue("eventTriggerDateTime", EventTriggerDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastStatusUpdateDateTime", LastStatusUpdateDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.RetentionEventType>("retentionEventType", RetentionEventType);
        }
    }
}
#pragma warning restore CS0618
