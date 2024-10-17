// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// The category entity stores the category of a group policy definition
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GroupPolicyCategory : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    {
        /// <summary>The children categories</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.GroupPolicyCategory>? Children
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GroupPolicyCategory>?>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.GroupPolicyCategory> Children
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GroupPolicyCategory>>("children"); }
            set { BackingStore?.Set("children", value); }
        }
#endif
        /// <summary>The id of the definition file the category came from</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile? DefinitionFile
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile?>("definitionFile"); }
            set { BackingStore?.Set("definitionFile", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile DefinitionFile
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile>("definitionFile"); }
            set { BackingStore?.Set("definitionFile", value); }
        }
#endif
        /// <summary>The immediate GroupPolicyDefinition children of the category</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.GroupPolicyDefinition>? Definitions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GroupPolicyDefinition>?>("definitions"); }
            set { BackingStore?.Set("definitions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.GroupPolicyDefinition> Definitions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.GroupPolicyDefinition>>("definitions"); }
            set { BackingStore?.Set("definitions", value); }
        }
#endif
        /// <summary>The string id of the category&apos;s display name</summary>
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
        /// <summary>Category Ingestion source</summary>
        public global::Microsoft.Graph.Beta.Models.IngestionSource? IngestionSource
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.IngestionSource?>("ingestionSource"); }
            set { BackingStore?.Set("ingestionSource", value); }
        }
        /// <summary>Defines if the category is a root category</summary>
        public bool? IsRoot
        {
            get { return BackingStore?.Get<bool?>("isRoot"); }
            set { BackingStore?.Set("isRoot", value); }
        }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The parent category</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.GroupPolicyCategory? Parent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GroupPolicyCategory?>("parent"); }
            set { BackingStore?.Set("parent", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.GroupPolicyCategory Parent
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.GroupPolicyCategory>("parent"); }
            set { BackingStore?.Set("parent", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.GroupPolicyCategory"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.GroupPolicyCategory CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.GroupPolicyCategory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "children", n => { Children = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GroupPolicyCategory>(global::Microsoft.Graph.Beta.Models.GroupPolicyCategory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "definitionFile", n => { DefinitionFile = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile>(global::Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile.CreateFromDiscriminatorValue); } },
                { "definitions", n => { Definitions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GroupPolicyDefinition>(global::Microsoft.Graph.Beta.Models.GroupPolicyDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "ingestionSource", n => { IngestionSource = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.IngestionSource>(); } },
                { "isRoot", n => { IsRoot = n.GetBoolValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "parent", n => { Parent = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.GroupPolicyCategory>(global::Microsoft.Graph.Beta.Models.GroupPolicyCategory.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GroupPolicyCategory>("children", Children);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.GroupPolicyDefinitionFile>("definitionFile", DefinitionFile);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.GroupPolicyDefinition>("definitions", Definitions);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.IngestionSource>("ingestionSource", IngestionSource);
            writer.WriteBoolValue("isRoot", IsRoot);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.GroupPolicyCategory>("parent", Parent);
        }
    }
}
#pragma warning restore CS0618
