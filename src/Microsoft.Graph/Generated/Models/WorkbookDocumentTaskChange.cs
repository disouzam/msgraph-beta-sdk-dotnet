// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class WorkbookDocumentTaskChange : Entity, IParsable {
        /// <summary>The assignee property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookEmailIdentity? Assignee {
            get { return BackingStore?.Get<WorkbookEmailIdentity?>("assignee"); }
            set { BackingStore?.Set("assignee", value); }
        }
#nullable restore
#else
        public WorkbookEmailIdentity Assignee {
            get { return BackingStore?.Get<WorkbookEmailIdentity>("assignee"); }
            set { BackingStore?.Set("assignee", value); }
        }
#endif
        /// <summary>The changedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookEmailIdentity? ChangedBy {
            get { return BackingStore?.Get<WorkbookEmailIdentity?>("changedBy"); }
            set { BackingStore?.Set("changedBy", value); }
        }
#nullable restore
#else
        public WorkbookEmailIdentity ChangedBy {
            get { return BackingStore?.Get<WorkbookEmailIdentity>("changedBy"); }
            set { BackingStore?.Set("changedBy", value); }
        }
#endif
        /// <summary>The commentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommentId {
            get { return BackingStore?.Get<string?>("commentId"); }
            set { BackingStore?.Set("commentId", value); }
        }
#nullable restore
#else
        public string CommentId {
            get { return BackingStore?.Get<string>("commentId"); }
            set { BackingStore?.Set("commentId", value); }
        }
#endif
        /// <summary>The createdDateTime property</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The dueDateTime property</summary>
        public DateTimeOffset? DueDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("dueDateTime"); }
            set { BackingStore?.Set("dueDateTime", value); }
        }
        /// <summary>The percentComplete property</summary>
        public int? PercentComplete {
            get { return BackingStore?.Get<int?>("percentComplete"); }
            set { BackingStore?.Set("percentComplete", value); }
        }
        /// <summary>The priority property</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>The startDateTime property</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title {
            get { return BackingStore?.Get<string?>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#nullable restore
#else
        public string Title {
            get { return BackingStore?.Get<string>("title"); }
            set { BackingStore?.Set("title", value); }
        }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>The undoChangeId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UndoChangeId {
            get { return BackingStore?.Get<string?>("undoChangeId"); }
            set { BackingStore?.Set("undoChangeId", value); }
        }
#nullable restore
#else
        public string UndoChangeId {
            get { return BackingStore?.Get<string>("undoChangeId"); }
            set { BackingStore?.Set("undoChangeId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookDocumentTaskChange CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookDocumentTaskChange();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignee", n => { Assignee = n.GetObjectValue<WorkbookEmailIdentity>(WorkbookEmailIdentity.CreateFromDiscriminatorValue); } },
                {"changedBy", n => { ChangedBy = n.GetObjectValue<WorkbookEmailIdentity>(WorkbookEmailIdentity.CreateFromDiscriminatorValue); } },
                {"commentId", n => { CommentId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"dueDateTime", n => { DueDateTime = n.GetDateTimeOffsetValue(); } },
                {"percentComplete", n => { PercentComplete = n.GetIntValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"undoChangeId", n => { UndoChangeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookEmailIdentity>("assignee", Assignee);
            writer.WriteObjectValue<WorkbookEmailIdentity>("changedBy", ChangedBy);
            writer.WriteStringValue("commentId", CommentId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("dueDateTime", DueDateTime);
            writer.WriteIntValue("percentComplete", PercentComplete);
            writer.WriteIntValue("priority", Priority);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("undoChangeId", UndoChangeId);
        }
    }
}
