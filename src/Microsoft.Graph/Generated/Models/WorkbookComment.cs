// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class WorkbookComment : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The content of the comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Content
        {
            get { return BackingStore?.Get<string?>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#nullable restore
#else
        public string Content
        {
            get { return BackingStore?.Get<string>("content"); }
            set { BackingStore?.Set("content", value); }
        }
#endif
        /// <summary>The content type of the comment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentType
        {
            get { return BackingStore?.Get<string?>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#nullable restore
#else
        public string ContentType
        {
            get { return BackingStore?.Get<string>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#endif
        /// <summary>The list of replies to the comment. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WorkbookCommentReply>? Replies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WorkbookCommentReply>?>("replies"); }
            set { BackingStore?.Set("replies", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WorkbookCommentReply> Replies
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WorkbookCommentReply>>("replies"); }
            set { BackingStore?.Set("replies", value); }
        }
#endif
        /// <summary>The task associated with the comment. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WorkbookDocumentTask? Task
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookDocumentTask?>("task"); }
            set { BackingStore?.Set("task", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WorkbookDocumentTask Task
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WorkbookDocumentTask>("task"); }
            set { BackingStore?.Set("task", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WorkbookComment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WorkbookComment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WorkbookComment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "content", n => { Content = n.GetStringValue(); } },
                { "contentType", n => { ContentType = n.GetStringValue(); } },
                { "replies", n => { Replies = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WorkbookCommentReply>(global::Microsoft.Graph.Beta.Models.WorkbookCommentReply.CreateFromDiscriminatorValue)?.AsList(); } },
                { "task", n => { Task = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookDocumentTask>(global::Microsoft.Graph.Beta.Models.WorkbookDocumentTask.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("content", Content);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WorkbookCommentReply>("replies", Replies);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WorkbookDocumentTask>("task", Task);
        }
    }
}
#pragma warning restore CS0618
