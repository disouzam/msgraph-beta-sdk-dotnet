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
    public partial class AudioRoutingGroup : global::Microsoft.Graph.Beta.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>List of receiving participant ids.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Receivers
        {
            get { return BackingStore?.Get<List<string>?>("receivers"); }
            set { BackingStore?.Set("receivers", value); }
        }
#nullable restore
#else
        public List<string> Receivers
        {
            get { return BackingStore?.Get<List<string>>("receivers"); }
            set { BackingStore?.Set("receivers", value); }
        }
#endif
        /// <summary>The routingMode property</summary>
        public global::Microsoft.Graph.Beta.Models.RoutingMode? RoutingMode
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.RoutingMode?>("routingMode"); }
            set { BackingStore?.Set("routingMode", value); }
        }
        /// <summary>List of source participant ids.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Sources
        {
            get { return BackingStore?.Get<List<string>?>("sources"); }
            set { BackingStore?.Set("sources", value); }
        }
#nullable restore
#else
        public List<string> Sources
        {
            get { return BackingStore?.Get<List<string>>("sources"); }
            set { BackingStore?.Set("sources", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.AudioRoutingGroup"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.AudioRoutingGroup CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.AudioRoutingGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "receivers", n => { Receivers = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "routingMode", n => { RoutingMode = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.RoutingMode>(); } },
                { "sources", n => { Sources = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("receivers", Receivers);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.RoutingMode>("routingMode", RoutingMode);
            writer.WriteCollectionOfPrimitiveValues<string>("sources", Sources);
        }
    }
}
#pragma warning restore CS0618
