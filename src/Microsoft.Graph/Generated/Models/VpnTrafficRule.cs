// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    /// <summary>
    /// VPN Traffic Rule definition.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.20.0")]
    public partial class VpnTrafficRule : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>App identifier, if this traffic rule is triggered by an app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId
        {
            get { return BackingStore?.Get<string?>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#nullable restore
#else
        public string AppId
        {
            get { return BackingStore?.Get<string>("appId"); }
            set { BackingStore?.Set("appId", value); }
        }
#endif
        /// <summary>Indicates the type of app that a VPN traffic rule is associated with.</summary>
        public global::Microsoft.Graph.Beta.Models.VpnTrafficRuleAppType? AppType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VpnTrafficRuleAppType?>("appType"); }
            set { BackingStore?.Set("appType", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Claims associated with this traffic rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Claims
        {
            get { return BackingStore?.Get<string?>("claims"); }
            set { BackingStore?.Set("claims", value); }
        }
#nullable restore
#else
        public string Claims
        {
            get { return BackingStore?.Get<string>("claims"); }
            set { BackingStore?.Set("claims", value); }
        }
#endif
        /// <summary>Local address range. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IPv4Range>? LocalAddressRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IPv4Range>?>("localAddressRanges"); }
            set { BackingStore?.Set("localAddressRanges", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IPv4Range> LocalAddressRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IPv4Range>>("localAddressRanges"); }
            set { BackingStore?.Set("localAddressRanges", value); }
        }
#endif
        /// <summary>Local port range can be set only when protocol is either TCP or UDP (6 or 17). This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.NumberRange>? LocalPortRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.NumberRange>?>("localPortRanges"); }
            set { BackingStore?.Set("localPortRanges", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.NumberRange> LocalPortRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.NumberRange>>("localPortRanges"); }
            set { BackingStore?.Set("localPortRanges", value); }
        }
#endif
        /// <summary>Name.</summary>
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
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Protocols (0-255). Valid values 0 to 255</summary>
        public int? Protocols
        {
            get { return BackingStore?.Get<int?>("protocols"); }
            set { BackingStore?.Set("protocols", value); }
        }
        /// <summary>Remote address range. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.IPv4Range>? RemoteAddressRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IPv4Range>?>("remoteAddressRanges"); }
            set { BackingStore?.Set("remoteAddressRanges", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.IPv4Range> RemoteAddressRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.IPv4Range>>("remoteAddressRanges"); }
            set { BackingStore?.Set("remoteAddressRanges", value); }
        }
#endif
        /// <summary>Remote port range can be set only when protocol is either TCP or UDP (6 or 17). This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.NumberRange>? RemotePortRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.NumberRange>?>("remotePortRanges"); }
            set { BackingStore?.Set("remotePortRanges", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.NumberRange> RemotePortRanges
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.NumberRange>>("remotePortRanges"); }
            set { BackingStore?.Set("remotePortRanges", value); }
        }
#endif
        /// <summary>Specifies the routing policy for a VPN traffic rule.</summary>
        public global::Microsoft.Graph.Beta.Models.VpnTrafficRuleRoutingPolicyType? RoutingPolicyType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VpnTrafficRuleRoutingPolicyType?>("routingPolicyType"); }
            set { BackingStore?.Set("routingPolicyType", value); }
        }
        /// <summary>Specify whether the rule applies to inbound traffic or outbound traffic.</summary>
        public global::Microsoft.Graph.Beta.Models.VpnTrafficDirection? VpnTrafficDirection
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.VpnTrafficDirection?>("vpnTrafficDirection"); }
            set { BackingStore?.Set("vpnTrafficDirection", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.VpnTrafficRule"/> and sets the default values.
        /// </summary>
        public VpnTrafficRule()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.VpnTrafficRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::Microsoft.Graph.Beta.Models.VpnTrafficRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.VpnTrafficRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "appType", n => { AppType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.VpnTrafficRuleAppType>(); } },
                { "claims", n => { Claims = n.GetStringValue(); } },
                { "localAddressRanges", n => { LocalAddressRanges = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IPv4Range>(global::Microsoft.Graph.Beta.Models.IPv4Range.CreateFromDiscriminatorValue)?.AsList(); } },
                { "localPortRanges", n => { LocalPortRanges = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.NumberRange>(global::Microsoft.Graph.Beta.Models.NumberRange.CreateFromDiscriminatorValue)?.AsList(); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "protocols", n => { Protocols = n.GetIntValue(); } },
                { "remoteAddressRanges", n => { RemoteAddressRanges = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IPv4Range>(global::Microsoft.Graph.Beta.Models.IPv4Range.CreateFromDiscriminatorValue)?.AsList(); } },
                { "remotePortRanges", n => { RemotePortRanges = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.NumberRange>(global::Microsoft.Graph.Beta.Models.NumberRange.CreateFromDiscriminatorValue)?.AsList(); } },
                { "routingPolicyType", n => { RoutingPolicyType = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.VpnTrafficRuleRoutingPolicyType>(); } },
                { "vpnTrafficDirection", n => { VpnTrafficDirection = n.GetEnumValue<global::Microsoft.Graph.Beta.Models.VpnTrafficDirection>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appId", AppId);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.VpnTrafficRuleAppType>("appType", AppType);
            writer.WriteStringValue("claims", Claims);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IPv4Range>("localAddressRanges", LocalAddressRanges);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.NumberRange>("localPortRanges", LocalPortRanges);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("protocols", Protocols);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.IPv4Range>("remoteAddressRanges", RemoteAddressRanges);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.NumberRange>("remotePortRanges", RemotePortRanges);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.VpnTrafficRuleRoutingPolicyType>("routingPolicyType", RoutingPolicyType);
            writer.WriteEnumValue<global::Microsoft.Graph.Beta.Models.VpnTrafficDirection>("vpnTrafficDirection", VpnTrafficDirection);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
