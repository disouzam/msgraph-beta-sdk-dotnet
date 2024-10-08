// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    #pragma warning disable CS1591
    public partial class KubernetesControllerEvidence : global::Microsoft.Graph.Beta.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The labels for the Kubernetes pod.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.Dictionary? Labels
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.Dictionary?>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.Dictionary Labels
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.Dictionary>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#endif
        /// <summary>The controller name.</summary>
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
        /// <summary>The service account namespace.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.KubernetesNamespaceEvidence? Namespace
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.KubernetesNamespaceEvidence?>("namespace"); }
            set { BackingStore?.Set("namespace", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.KubernetesNamespaceEvidence Namespace
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.KubernetesNamespaceEvidence>("namespace"); }
            set { BackingStore?.Set("namespace", value); }
        }
#endif
        /// <summary>The controller type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type
        {
            get { return BackingStore?.Get<string?>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#nullable restore
#else
        public string Type
        {
            get { return BackingStore?.Get<string>("type"); }
            set { BackingStore?.Set("type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Security.KubernetesControllerEvidence"/> and sets the default values.
        /// </summary>
        public KubernetesControllerEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.kubernetesControllerEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.KubernetesControllerEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.KubernetesControllerEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.KubernetesControllerEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "labels", n => { Labels = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.Dictionary>(global::Microsoft.Graph.Beta.Models.Security.Dictionary.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "namespace", n => { Namespace = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.KubernetesNamespaceEvidence>(global::Microsoft.Graph.Beta.Models.Security.KubernetesNamespaceEvidence.CreateFromDiscriminatorValue); } },
                { "type", n => { Type = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.Dictionary>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.KubernetesNamespaceEvidence>("namespace", Namespace);
            writer.WriteStringValue("type", Type);
        }
    }
}
#pragma warning restore CS0618
