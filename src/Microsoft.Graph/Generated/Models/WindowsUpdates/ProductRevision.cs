// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class ProductRevision : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The catalogEntry property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry? CatalogEntry
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry?>("catalogEntry"); }
            set { BackingStore?.Set("catalogEntry", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry CatalogEntry
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry>("catalogEntry"); }
            set { BackingStore?.Set("catalogEntry", value); }
        }
#endif
        /// <summary>The display name of the content. Read-only.</summary>
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
        /// <summary>The knowledge base article associated with the product revision.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnowledgeBaseArticle? KnowledgeBaseArticle
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnowledgeBaseArticle?>("knowledgeBaseArticle"); }
            set { BackingStore?.Set("knowledgeBaseArticle", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnowledgeBaseArticle KnowledgeBaseArticle
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnowledgeBaseArticle>("knowledgeBaseArticle"); }
            set { BackingStore?.Set("knowledgeBaseArticle", value); }
        }
#endif
        /// <summary>The osBuild property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.BuildVersionDetails? OsBuild
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.BuildVersionDetails?>("osBuild"); }
            set { BackingStore?.Set("osBuild", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.WindowsUpdates.BuildVersionDetails OsBuild
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.WindowsUpdates.BuildVersionDetails>("osBuild"); }
            set { BackingStore?.Set("osBuild", value); }
        }
#endif
        /// <summary>The product of the revision. Possible values are: Windows 10, Windows 11. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Product
        {
            get { return BackingStore?.Get<string?>("product"); }
            set { BackingStore?.Set("product", value); }
        }
#nullable restore
#else
        public string Product
        {
            get { return BackingStore?.Get<string>("product"); }
            set { BackingStore?.Set("product", value); }
        }
#endif
        /// <summary>The release date for the content. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ReleaseDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("releaseDateTime"); }
            set { BackingStore?.Set("releaseDateTime", value); }
        }
        /// <summary>The version of the feature update. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version
        {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version
        {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.ProductRevision"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WindowsUpdates.ProductRevision CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsUpdates.ProductRevision();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "catalogEntry", n => { CatalogEntry = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "knowledgeBaseArticle", n => { KnowledgeBaseArticle = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnowledgeBaseArticle>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnowledgeBaseArticle.CreateFromDiscriminatorValue); } },
                { "osBuild", n => { OsBuild = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.BuildVersionDetails>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.BuildVersionDetails.CreateFromDiscriminatorValue); } },
                { "product", n => { Product = n.GetStringValue(); } },
                { "releaseDateTime", n => { ReleaseDateTime = n.GetDateTimeOffsetValue(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.CatalogEntry>("catalogEntry", CatalogEntry);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnowledgeBaseArticle>("knowledgeBaseArticle", KnowledgeBaseArticle);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.WindowsUpdates.BuildVersionDetails>("osBuild", OsBuild);
            writer.WriteStringValue("product", Product);
            writer.WriteDateTimeOffsetValue("releaseDateTime", ReleaseDateTime);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
