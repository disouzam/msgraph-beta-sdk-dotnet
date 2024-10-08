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
    public partial class KubernetesServiceEvidence : global::Microsoft.Graph.Beta.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The service cluster IP.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.IpEvidence? ClusterIP
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.IpEvidence?>("clusterIP"); }
            set { BackingStore?.Set("clusterIP", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.IpEvidence ClusterIP
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>("clusterIP"); }
            set { BackingStore?.Set("clusterIP", value); }
        }
#endif
        /// <summary>The service external IPs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>? ExternalIPs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>?>("externalIPs"); }
            set { BackingStore?.Set("externalIPs", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.IpEvidence> ExternalIPs
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>>("externalIPs"); }
            set { BackingStore?.Set("externalIPs", value); }
        }
#endif
        /// <summary>The service labels.</summary>
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
        /// <summary>The service name.</summary>
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
        /// <summary>The service namespace.</summary>
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
        /// <summary>The service selector.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Security.Dictionary? Selector
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.Dictionary?>("selector"); }
            set { BackingStore?.Set("selector", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Security.Dictionary Selector
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.Dictionary>("selector"); }
            set { BackingStore?.Set("selector", value); }
        }
#endif
        /// <summary>The list of service ports.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Security.KubernetesServicePort>? ServicePorts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.KubernetesServicePort>?>("servicePorts"); }
            set { BackingStore?.Set("servicePorts", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Security.KubernetesServicePort> ServicePorts
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Security.KubernetesServicePort>>("servicePorts"); }
            set { BackingStore?.Set("servicePorts", value); }
        }
#endif
        /// <summary>The serviceType property</summary>
        public global::Microsoft.Graph.Beta.Models.Security.KubernetesServiceType? ServiceType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Security.KubernetesServiceType?>("serviceType"); }
            set { BackingStore?.Set("serviceType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.Security.KubernetesServiceEvidence"/> and sets the default values.
        /// </summary>
        public KubernetesServiceEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.kubernetesServiceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.Security.KubernetesServiceEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.Security.KubernetesServiceEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.Security.KubernetesServiceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "clusterIP", n => { ClusterIP = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>(global::Microsoft.Graph.Beta.Models.Security.IpEvidence.CreateFromDiscriminatorValue); } },
                { "externalIPs", n => { ExternalIPs = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>(global::Microsoft.Graph.Beta.Models.Security.IpEvidence.CreateFromDiscriminatorValue)?.AsList(); } },
                { "labels", n => { Labels = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.Dictionary>(global::Microsoft.Graph.Beta.Models.Security.Dictionary.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "namespace", n => { Namespace = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.KubernetesNamespaceEvidence>(global::Microsoft.Graph.Beta.Models.Security.KubernetesNamespaceEvidence.CreateFromDiscriminatorValue); } },
                { "selector", n => { Selector = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Security.Dictionary>(global::Microsoft.Graph.Beta.Models.Security.Dictionary.CreateFromDiscriminatorValue); } },
                { "servicePorts", n => { ServicePorts = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.KubernetesServicePort>(global::Microsoft.Graph.Beta.Models.Security.KubernetesServicePort.CreateFromDiscriminatorValue)?.AsList(); } },
                { "serviceType", n => { ServiceType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.Security.KubernetesServiceType>(); } },
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
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>("clusterIP", ClusterIP);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.IpEvidence>("externalIPs", ExternalIPs);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.Dictionary>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.KubernetesNamespaceEvidence>("namespace", Namespace);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Security.Dictionary>("selector", Selector);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Security.KubernetesServicePort>("servicePorts", ServicePorts);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.Security.KubernetesServiceType>("serviceType", ServiceType);
        }
    }
}
#pragma warning restore CS0618
