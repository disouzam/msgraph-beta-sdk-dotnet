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
    public partial class ContentType : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of canonical URLs for hub sites with which this content type is associated to. This contains all hub sites where this content type is queued to be enforced or is already enforced. Enforcing a content type means that the content type is applied to the lists in the enforced sites.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AssociatedHubsUrls
        {
            get { return BackingStore?.Get<List<string>?>("associatedHubsUrls"); }
            set { BackingStore?.Set("associatedHubsUrls", value); }
        }
#nullable restore
#else
        public List<string> AssociatedHubsUrls
        {
            get { return BackingStore?.Get<List<string>>("associatedHubsUrls"); }
            set { BackingStore?.Set("associatedHubsUrls", value); }
        }
#endif
        /// <summary>Parent contentType from which this content type is derived.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ContentType? Base
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContentType?>("base"); }
            set { BackingStore?.Set("base", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ContentType Base
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContentType>("base"); }
            set { BackingStore?.Set("base", value); }
        }
#endif
        /// <summary>The collection of content types that are ancestors of this content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ContentType>? BaseTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ContentType>?>("baseTypes"); }
            set { BackingStore?.Set("baseTypes", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ContentType> BaseTypes
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ContentType>>("baseTypes"); }
            set { BackingStore?.Set("baseTypes", value); }
        }
#endif
        /// <summary>The collection of columns that are required by this content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ColumnLink>? ColumnLinks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ColumnLink>?>("columnLinks"); }
            set { BackingStore?.Set("columnLinks", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ColumnLink> ColumnLinks
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ColumnLink>>("columnLinks"); }
            set { BackingStore?.Set("columnLinks", value); }
        }
#endif
        /// <summary>Column order information in a content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>? ColumnPositions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>?>("columnPositions"); }
            set { BackingStore?.Set("columnPositions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ColumnDefinition> ColumnPositions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>>("columnPositions"); }
            set { BackingStore?.Set("columnPositions", value); }
        }
#endif
        /// <summary>The collection of column definitions for this content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>? Columns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>?>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ColumnDefinition> Columns
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ColumnDefinition>>("columns"); }
            set { BackingStore?.Set("columns", value); }
        }
#endif
        /// <summary>The descriptive text for the item.</summary>
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
        /// <summary>Document Set metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DocumentSet? DocumentSet
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DocumentSet?>("documentSet"); }
            set { BackingStore?.Set("documentSet", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DocumentSet DocumentSet
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DocumentSet>("documentSet"); }
            set { BackingStore?.Set("documentSet", value); }
        }
#endif
        /// <summary>Document template metadata. To make sure that documents have consistent content across a site and its subsites, you can associate a Word, Excel, or PowerPoint template with a site content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DocumentSetContent? DocumentTemplate
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DocumentSetContent?>("documentTemplate"); }
            set { BackingStore?.Set("documentTemplate", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DocumentSetContent DocumentTemplate
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DocumentSetContent>("documentTemplate"); }
            set { BackingStore?.Set("documentTemplate", value); }
        }
#endif
        /// <summary>The name of the group this content type belongs to. Helps organize related content types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Group
        {
            get { return BackingStore?.Get<string?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public string Group
        {
            get { return BackingStore?.Get<string>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>Indicates whether the content type is hidden in the list&apos;s &apos;New&apos; menu.</summary>
        public bool? Hidden
        {
            get { return BackingStore?.Get<bool?>("hidden"); }
            set { BackingStore?.Set("hidden", value); }
        }
        /// <summary>If this content type is inherited from another scope (like a site), provides a reference to the item where the content type is defined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ItemReference? InheritedFrom
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemReference?>("inheritedFrom"); }
            set { BackingStore?.Set("inheritedFrom", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ItemReference InheritedFrom
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemReference>("inheritedFrom"); }
            set { BackingStore?.Set("inheritedFrom", value); }
        }
#endif
        /// <summary>Specifies if a content type is a built-in content type.</summary>
        public bool? IsBuiltIn
        {
            get { return BackingStore?.Get<bool?>("isBuiltIn"); }
            set { BackingStore?.Set("isBuiltIn", value); }
        }
        /// <summary>The name of the content type.</summary>
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
        /// <summary>Specifies the order in which the content type appears in the selection UI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ContentTypeOrder? Order
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContentTypeOrder?>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ContentTypeOrder Order
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContentTypeOrder>("order"); }
            set { BackingStore?.Set("order", value); }
        }
#endif
        /// <summary>The unique identifier of the content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentId
        {
            get { return BackingStore?.Get<string?>("parentId"); }
            set { BackingStore?.Set("parentId", value); }
        }
#nullable restore
#else
        public string ParentId
        {
            get { return BackingStore?.Get<string>("parentId"); }
            set { BackingStore?.Set("parentId", value); }
        }
#endif
        /// <summary>If true, any changes made to the content type are pushed to inherited content types and lists that implement the content type.</summary>
        public bool? PropagateChanges
        {
            get { return BackingStore?.Get<bool?>("propagateChanges"); }
            set { BackingStore?.Set("propagateChanges", value); }
        }
        /// <summary>If true, the content type can&apos;t be modified unless this value is first set to false.</summary>
        public bool? ReadOnly
        {
            get { return BackingStore?.Get<bool?>("readOnly"); }
            set { BackingStore?.Set("readOnly", value); }
        }
        /// <summary>If true, the content type can&apos;t be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.</summary>
        public bool? Sealed
        {
            get { return BackingStore?.Get<bool?>("sealed"); }
            set { BackingStore?.Set("sealed", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ContentType"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ContentType CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ContentType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "associatedHubsUrls", n => { AssociatedHubsUrls = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "base", n => { Base = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ContentType>(global::Microsoft.Graph.Beta.Models.ContentType.CreateFromDiscriminatorValue); } },
                { "baseTypes", n => { BaseTypes = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ContentType>(global::Microsoft.Graph.Beta.Models.ContentType.CreateFromDiscriminatorValue)?.AsList(); } },
                { "columnLinks", n => { ColumnLinks = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ColumnLink>(global::Microsoft.Graph.Beta.Models.ColumnLink.CreateFromDiscriminatorValue)?.AsList(); } },
                { "columnPositions", n => { ColumnPositions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ColumnDefinition>(global::Microsoft.Graph.Beta.Models.ColumnDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "columns", n => { Columns = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ColumnDefinition>(global::Microsoft.Graph.Beta.Models.ColumnDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "documentSet", n => { DocumentSet = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DocumentSet>(global::Microsoft.Graph.Beta.Models.DocumentSet.CreateFromDiscriminatorValue); } },
                { "documentTemplate", n => { DocumentTemplate = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DocumentSetContent>(global::Microsoft.Graph.Beta.Models.DocumentSetContent.CreateFromDiscriminatorValue); } },
                { "group", n => { Group = n.GetStringValue(); } },
                { "hidden", n => { Hidden = n.GetBoolValue(); } },
                { "inheritedFrom", n => { InheritedFrom = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ItemReference>(global::Microsoft.Graph.Beta.Models.ItemReference.CreateFromDiscriminatorValue); } },
                { "isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "order", n => { Order = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ContentTypeOrder>(global::Microsoft.Graph.Beta.Models.ContentTypeOrder.CreateFromDiscriminatorValue); } },
                { "parentId", n => { ParentId = n.GetStringValue(); } },
                { "propagateChanges", n => { PropagateChanges = n.GetBoolValue(); } },
                { "readOnly", n => { ReadOnly = n.GetBoolValue(); } },
                { "sealed", n => { Sealed = n.GetBoolValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("associatedHubsUrls", AssociatedHubsUrls);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ContentType>("base", Base);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ContentType>("baseTypes", BaseTypes);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ColumnLink>("columnLinks", ColumnLinks);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ColumnDefinition>("columnPositions", ColumnPositions);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ColumnDefinition>("columns", Columns);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DocumentSet>("documentSet", DocumentSet);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DocumentSetContent>("documentTemplate", DocumentTemplate);
            writer.WriteStringValue("group", Group);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ItemReference>("inheritedFrom", InheritedFrom);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ContentTypeOrder>("order", Order);
            writer.WriteStringValue("parentId", ParentId);
            writer.WriteBoolValue("propagateChanges", PropagateChanges);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteBoolValue("sealed", Sealed);
        }
    }
}
#pragma warning restore CS0618
