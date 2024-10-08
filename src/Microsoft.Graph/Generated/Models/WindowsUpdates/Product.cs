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
    public partial class Product : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents an edition of a particular Windows product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.Edition>? Editions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.Edition>?>("editions"); }
            set { BackingStore?.Set("editions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.Edition> Editions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.Edition>>("editions"); }
            set { BackingStore?.Set("editions", value); }
        }
#endif
        /// <summary>The friendly names of the product. For example, Version 22H2 (OS build 22621). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? FriendlyNames
        {
            get { return BackingStore?.Get<List<string>?>("friendlyNames"); }
            set { BackingStore?.Set("friendlyNames", value); }
        }
#nullable restore
#else
        public List<string> FriendlyNames
        {
            get { return BackingStore?.Get<List<string>>("friendlyNames"); }
            set { BackingStore?.Set("friendlyNames", value); }
        }
#endif
        /// <summary>The name of the product group. For example, Windows 11. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupName
        {
            get { return BackingStore?.Get<string?>("groupName"); }
            set { BackingStore?.Set("groupName", value); }
        }
#nullable restore
#else
        public string GroupName
        {
            get { return BackingStore?.Get<string>("groupName"); }
            set { BackingStore?.Set("groupName", value); }
        }
#endif
        /// <summary>Represents a known issue related to a Windows product.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnownIssue>? KnownIssues
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnownIssue>?>("knownIssues"); }
            set { BackingStore?.Set("knownIssues", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnownIssue> KnownIssues
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnownIssue>>("knownIssues"); }
            set { BackingStore?.Set("knownIssues", value); }
        }
#endif
        /// <summary>The name of the product. For example, Windows 11, version 22H2. Read-only.</summary>
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
        /// <summary>Represents a product revision.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ProductRevision>? Revisions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ProductRevision>?>("revisions"); }
            set { BackingStore?.Set("revisions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ProductRevision> Revisions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ProductRevision>>("revisions"); }
            set { BackingStore?.Set("revisions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.WindowsUpdates.Product"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.WindowsUpdates.Product CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.WindowsUpdates.Product();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "editions", n => { Editions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.Edition>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.Edition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "friendlyNames", n => { FriendlyNames = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "groupName", n => { GroupName = n.GetStringValue(); } },
                { "knownIssues", n => { KnownIssues = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnownIssue>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnownIssue.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "revisions", n => { Revisions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ProductRevision>(global::Microsoft.Graph.Beta.Models.WindowsUpdates.ProductRevision.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.Edition>("editions", Editions);
            writer.WriteCollectionOfPrimitiveValues<string>("friendlyNames", FriendlyNames);
            writer.WriteStringValue("groupName", GroupName);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.KnownIssue>("knownIssues", KnownIssues);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.WindowsUpdates.ProductRevision>("revisions", Revisions);
        }
    }
}
#pragma warning restore CS0618
