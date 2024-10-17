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
    public partial class BaseItem : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Identity of the user, device, or application that created the item. Read-only.</summary>
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
        /// <summary>The createdByUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.User? CreatedByUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.User?>("createdByUser"); }
            set { BackingStore?.Set("createdByUser", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.User CreatedByUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.User>("createdByUser"); }
            set { BackingStore?.Set("createdByUser", value); }
        }
#endif
        /// <summary>Date and time of item creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The description of the item.</summary>
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
        /// <summary>ETag for the item. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ETag
        {
            get { return BackingStore?.Get<string?>("eTag"); }
            set { BackingStore?.Set("eTag", value); }
        }
#nullable restore
#else
        public string ETag
        {
            get { return BackingStore?.Get<string>("eTag"); }
            set { BackingStore?.Set("eTag", value); }
        }
#endif
        /// <summary>Identity of the user, device, and application that last modified the item. Read-only.</summary>
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
        /// <summary>The lastModifiedByUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.User? LastModifiedByUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.User?>("lastModifiedByUser"); }
            set { BackingStore?.Set("lastModifiedByUser", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.User LastModifiedByUser
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.User>("lastModifiedByUser"); }
            set { BackingStore?.Set("lastModifiedByUser", value); }
        }
#endif
        /// <summary>Date and time the item was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The name of the item. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name
        {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name
        {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>Parent information, if the item has a parent. Read-write.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ItemReference? ParentReference
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemReference?>("parentReference"); }
            set { BackingStore?.Set("parentReference", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ItemReference ParentReference
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemReference>("parentReference"); }
            set { BackingStore?.Set("parentReference", value); }
        }
#endif
        /// <summary>URL that either displays the resource in the browser (for Office file formats), or is a direct link to the file (for other formats). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl
        {
            get { return BackingStore?.Get<string?>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#nullable restore
#else
        public string WebUrl
        {
            get { return BackingStore?.Get<string>("webUrl"); }
            set { BackingStore?.Set("webUrl", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.BaseItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.BaseItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.baseSitePage" => new global::Microsoft.Graph.Beta.Models.BaseSitePage(),
                "#microsoft.graph.drive" => new global::Microsoft.Graph.Beta.Models.Drive(),
                "#microsoft.graph.driveItem" => new global::Microsoft.Graph.Beta.Models.DriveItem(),
                "#microsoft.graph.list" => new global::Microsoft.Graph.Beta.Models.List(),
                "#microsoft.graph.listItem" => new global::Microsoft.Graph.Beta.Models.ListItem(),
                "#microsoft.graph.newsLinkPage" => new global::Microsoft.Graph.Beta.Models.NewsLinkPage(),
                "#microsoft.graph.pageTemplate" => new global::Microsoft.Graph.Beta.Models.PageTemplate(),
                "#microsoft.graph.recycleBin" => new global::Microsoft.Graph.Beta.Models.RecycleBin(),
                "#microsoft.graph.recycleBinItem" => new global::Microsoft.Graph.Beta.Models.RecycleBinItem(),
                "#microsoft.graph.sharedDriveItem" => new global::Microsoft.Graph.Beta.Models.SharedDriveItem(),
                "#microsoft.graph.site" => new global::Microsoft.Graph.Beta.Models.Site(),
                "#microsoft.graph.sitePage" => new global::Microsoft.Graph.Beta.Models.SitePage(),
                "#microsoft.graph.videoNewsLinkPage" => new global::Microsoft.Graph.Beta.Models.VideoNewsLinkPage(),
                _ => new global::Microsoft.Graph.Beta.Models.BaseItem(),
            };
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
                { "createdByUser", n => { CreatedByUser = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.User>(global::Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "eTag", n => { ETag = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>(global::Microsoft.Graph.Beta.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedByUser", n => { LastModifiedByUser = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.User>(global::Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "parentReference", n => { ParentReference = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ItemReference>(global::Microsoft.Graph.Beta.Models.ItemReference.CreateFromDiscriminatorValue); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.User>("createdByUser", CreatedByUser);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("eTag", ETag);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.User>("lastModifiedByUser", LastModifiedByUser);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ItemReference>("parentReference", ParentReference);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
#pragma warning restore CS0618
