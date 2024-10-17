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
    public partial class SynchronizationSchema : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Contains the collection of directories and all of their objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DirectoryDefinition>? Directories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DirectoryDefinition>?>("directories"); }
            set { BackingStore?.Set("directories", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DirectoryDefinition> Directories
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DirectoryDefinition>>("directories"); }
            set { BackingStore?.Set("directories", value); }
        }
#endif
        /// <summary>A collection of synchronization rules configured for the synchronizationJob or synchronizationTemplate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.SynchronizationRule>? SynchronizationRules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SynchronizationRule>?>("synchronizationRules"); }
            set { BackingStore?.Set("synchronizationRules", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.SynchronizationRule> SynchronizationRules
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.SynchronizationRule>>("synchronizationRules"); }
            set { BackingStore?.Set("synchronizationRules", value); }
        }
#endif
        /// <summary>The version of the schema, updated automatically with every schema change.</summary>
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
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.SynchronizationSchema"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.SynchronizationSchema CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.SynchronizationSchema();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "directories", n => { Directories = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DirectoryDefinition>(global::Microsoft.Graph.Beta.Models.DirectoryDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "synchronizationRules", n => { SynchronizationRules = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SynchronizationRule>(global::Microsoft.Graph.Beta.Models.SynchronizationRule.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DirectoryDefinition>("directories", Directories);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.SynchronizationRule>("synchronizationRules", SynchronizationRules);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
