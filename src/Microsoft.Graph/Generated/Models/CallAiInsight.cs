// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class CallAiInsight : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The actionItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ActionItem>? ActionItems
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ActionItem>?>("actionItems"); }
            set { BackingStore?.Set("actionItems", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ActionItem> ActionItems
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ActionItem>>("actionItems"); }
            set { BackingStore?.Set("actionItems", value); }
        }
#endif
        /// <summary>The callId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallId
        {
            get { return BackingStore?.Get<string?>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#nullable restore
#else
        public string CallId
        {
            get { return BackingStore?.Get<string>("callId"); }
            set { BackingStore?.Set("callId", value); }
        }
#endif
        /// <summary>The contentCorrelationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentCorrelationId
        {
            get { return BackingStore?.Get<string?>("contentCorrelationId"); }
            set { BackingStore?.Set("contentCorrelationId", value); }
        }
#nullable restore
#else
        public string ContentCorrelationId
        {
            get { return BackingStore?.Get<string>("contentCorrelationId"); }
            set { BackingStore?.Set("contentCorrelationId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The endDateTime property</summary>
        public DateTimeOffset? EndDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The meetingNotes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.MeetingNote>? MeetingNotes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MeetingNote>?>("meetingNotes"); }
            set { BackingStore?.Set("meetingNotes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.MeetingNote> MeetingNotes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.MeetingNote>>("meetingNotes"); }
            set { BackingStore?.Set("meetingNotes", value); }
        }
#endif
        /// <summary>The viewpoint property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.CallAiInsightViewPoint? Viewpoint
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CallAiInsightViewPoint?>("viewpoint"); }
            set { BackingStore?.Set("viewpoint", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.CallAiInsightViewPoint Viewpoint
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.CallAiInsightViewPoint>("viewpoint"); }
            set { BackingStore?.Set("viewpoint", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.CallAiInsight"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.CallAiInsight CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.CallAiInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionItems", n => { ActionItems = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ActionItem>(global::Microsoft.Graph.Beta.Models.ActionItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "callId", n => { CallId = n.GetStringValue(); } },
                { "contentCorrelationId", n => { ContentCorrelationId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                { "meetingNotes", n => { MeetingNotes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MeetingNote>(global::Microsoft.Graph.Beta.Models.MeetingNote.CreateFromDiscriminatorValue)?.AsList(); } },
                { "viewpoint", n => { Viewpoint = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.CallAiInsightViewPoint>(global::Microsoft.Graph.Beta.Models.CallAiInsightViewPoint.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ActionItem>("actionItems", ActionItems);
            writer.WriteStringValue("callId", CallId);
            writer.WriteStringValue("contentCorrelationId", ContentCorrelationId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.MeetingNote>("meetingNotes", MeetingNotes);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.CallAiInsightViewPoint>("viewpoint", Viewpoint);
        }
    }
}
#pragma warning restore CS0618
