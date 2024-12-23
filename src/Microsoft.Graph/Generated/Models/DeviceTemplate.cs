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
    public partial class DeviceTemplate : global::Microsoft.Graph.Beta.Models.DirectoryObject, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The deviceAuthority property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceAuthority
        {
            get { return BackingStore?.Get<string?>("deviceAuthority"); }
            set { BackingStore?.Set("deviceAuthority", value); }
        }
#nullable restore
#else
        public string DeviceAuthority
        {
            get { return BackingStore?.Get<string>("deviceAuthority"); }
            set { BackingStore?.Set("deviceAuthority", value); }
        }
#endif
        /// <summary>The deviceInstances property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Device>? DeviceInstances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Device>?>("deviceInstances"); }
            set { BackingStore?.Set("deviceInstances", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Device> DeviceInstances
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Device>>("deviceInstances"); }
            set { BackingStore?.Set("deviceInstances", value); }
        }
#endif
        /// <summary>The manufacturer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer
        {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer
        {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>The model property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model
        {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model
        {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>The mutualTlsOauthConfigurationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MutualTlsOauthConfigurationId
        {
            get { return BackingStore?.Get<string?>("mutualTlsOauthConfigurationId"); }
            set { BackingStore?.Set("mutualTlsOauthConfigurationId", value); }
        }
#nullable restore
#else
        public string MutualTlsOauthConfigurationId
        {
            get { return BackingStore?.Get<string>("mutualTlsOauthConfigurationId"); }
            set { BackingStore?.Set("mutualTlsOauthConfigurationId", value); }
        }
#endif
        /// <summary>The mutualTlsOauthConfigurationTenantId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MutualTlsOauthConfigurationTenantId
        {
            get { return BackingStore?.Get<string?>("mutualTlsOauthConfigurationTenantId"); }
            set { BackingStore?.Set("mutualTlsOauthConfigurationTenantId", value); }
        }
#nullable restore
#else
        public string MutualTlsOauthConfigurationTenantId
        {
            get { return BackingStore?.Get<string>("mutualTlsOauthConfigurationTenantId"); }
            set { BackingStore?.Set("mutualTlsOauthConfigurationTenantId", value); }
        }
#endif
        /// <summary>The operatingSystem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem
        {
            get { return BackingStore?.Get<string?>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#nullable restore
#else
        public string OperatingSystem
        {
            get { return BackingStore?.Get<string>("operatingSystem"); }
            set { BackingStore?.Set("operatingSystem", value); }
        }
#endif
        /// <summary>The owners property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DirectoryObject>? Owners
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DirectoryObject>?>("owners"); }
            set { BackingStore?.Set("owners", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DirectoryObject> Owners
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DirectoryObject>>("owners"); }
            set { BackingStore?.Set("owners", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.DeviceTemplate"/> and sets the default values.
        /// </summary>
        public DeviceTemplate() : base()
        {
            OdataType = "#microsoft.graph.deviceTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.DeviceTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.DeviceTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.DeviceTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "deviceAuthority", n => { DeviceAuthority = n.GetStringValue(); } },
                { "deviceInstances", n => { DeviceInstances = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Device>(global::Microsoft.Graph.Beta.Models.Device.CreateFromDiscriminatorValue)?.AsList(); } },
                { "manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                { "model", n => { Model = n.GetStringValue(); } },
                { "mutualTlsOauthConfigurationId", n => { MutualTlsOauthConfigurationId = n.GetStringValue(); } },
                { "mutualTlsOauthConfigurationTenantId", n => { MutualTlsOauthConfigurationTenantId = n.GetStringValue(); } },
                { "operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                { "owners", n => { Owners = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DirectoryObject>(global::Microsoft.Graph.Beta.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("deviceAuthority", DeviceAuthority);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Device>("deviceInstances", DeviceInstances);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("mutualTlsOauthConfigurationId", MutualTlsOauthConfigurationId);
            writer.WriteStringValue("mutualTlsOauthConfigurationTenantId", MutualTlsOauthConfigurationTenantId);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DirectoryObject>("owners", Owners);
        }
    }
}
#pragma warning restore CS0618
